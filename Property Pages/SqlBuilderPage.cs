using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ActiveDatabaseSoftware.ActiveQueryBuilder;

namespace SimpleDemo
{
	internal enum SqlBuilderOptionsPages { MainQuery, DerievedQueries, ExpressionSubqueries };

	[ToolboxItem(false)]
	internal partial class SqlBuilderPage : UserControl
	{
		private SqlBuilderOptionsPages fPage = SqlBuilderOptionsPages.MainQuery;
		private BaseSQLBuilder fBuilder = null;
		private SQLBuilderSelectFormat fFormat;
		private bool fModified = false;


		public bool Modified { get { return fModified; } set { fModified = value; } }


		public SqlBuilderPage(SqlBuilderOptionsPages page, BaseSQLBuilder builder)
		{
			fPage = page;
			fBuilder = builder;
			fFormat = new SQLBuilderSelectFormat(null);
			
			if (fPage == SqlBuilderOptionsPages.MainQuery)
			{
				fFormat.Assign(fBuilder.MainQueryFormat);
			}
			else if (fPage == SqlBuilderOptionsPages.DerievedQueries)
			{
				fFormat.Assign(fBuilder.DerievedQueryFormat);
			}
			else if (fPage == SqlBuilderOptionsPages.ExpressionSubqueries)
			{
				fFormat.Assign(fBuilder.ExpressionSubqueryFormat);
			}

			InitializeComponent();

			checkPartsOnNewLines.Checked = fFormat.MainPartsFromNewLine;
			checkNewLineAfterKeywords.Checked = fFormat.NewLineAfterPartKeywords;
			updownGlobalIndent.Value = fFormat.IndentGlobal;
			updownPartIndent.Value = fFormat.IndentInPart;

			checkNewLineAfterSelectItem.Checked = fFormat.SelectListFormat.NewLineAfterItem;

			checkNewLineAfterDatasource.Checked = fFormat.FromClauseFormat.NewLineAfterDatasource;
			checkNewLineAfterJoin.Checked = fFormat.FromClauseFormat.NewLineAfterJoin;

			checkNewLineWhereTop.Checked = (fFormat.WhereFormat.NewLineAfter == SQLBuilderConditionFormatNL.AllLogical || 
				fFormat.WhereFormat.NewLineAfter == SQLBuilderConditionFormatNL.TopmostOr ||
				fFormat.WhereFormat.NewLineAfter == SQLBuilderConditionFormatNL.TopmostLogical);
			checkNewLineWhereTop_CheckedChanged(null, new EventArgs());
			checkNewLineWhereRest.Checked = (fFormat.WhereFormat.NewLineAfter == SQLBuilderConditionFormatNL.AllLogical);
			checkNewLineWhereRest_CheckedChanged(null, new EventArgs());
			updownWhereIndent.Value = fFormat.WhereFormat.IndentNestedConditions;

			checkNewLineAfterGroupItem.Checked = fFormat.GroupByFormat.NewLineAfterItem;

			checkNewLineHavingTop.Checked = (fFormat.HavingFormat.NewLineAfter == SQLBuilderConditionFormatNL.AllLogical ||
				fFormat.HavingFormat.NewLineAfter == SQLBuilderConditionFormatNL.TopmostOr ||
				fFormat.HavingFormat.NewLineAfter == SQLBuilderConditionFormatNL.TopmostLogical);
			checkNewLineHavingTop_CheckedChanged(null, new EventArgs());
			checkNewLineHavingRest.Checked = (fFormat.HavingFormat.NewLineAfter == SQLBuilderConditionFormatNL.AllLogical);
			checkNewLineHavingRest_CheckedChanged(null, new EventArgs());
			updownHavingIndent.Value = fFormat.HavingFormat.IndentNestedConditions;

			updownHavingIndent.ValueChanged += new EventHandler(Changed);
			updownHavingIndent.TextChanged += new EventHandler(Changed);
			checkNewLineHavingRest.CheckedChanged += new EventHandler(checkNewLineHavingRest_CheckedChanged);
			checkNewLineHavingTop.CheckedChanged += new EventHandler(checkNewLineHavingTop_CheckedChanged);
			checkNewLineAfterGroupItem.CheckedChanged += new EventHandler(Changed);
			updownWhereIndent.ValueChanged += new EventHandler(Changed);
			updownWhereIndent.TextChanged += new EventHandler(Changed);
			checkNewLineWhereRest.CheckedChanged += new EventHandler(checkNewLineWhereRest_CheckedChanged);
			checkNewLineWhereTop.CheckedChanged += new EventHandler(checkNewLineWhereTop_CheckedChanged);
			checkNewLineAfterJoin.CheckedChanged += new EventHandler(Changed);
			checkNewLineAfterDatasource.CheckedChanged += new EventHandler(Changed);
			checkNewLineAfterSelectItem.CheckedChanged += new EventHandler(Changed);
			updownPartIndent.ValueChanged += new EventHandler(Changed);
			updownPartIndent.TextChanged += new EventHandler(Changed);
			updownGlobalIndent.ValueChanged += new EventHandler(Changed);
			updownGlobalIndent.TextChanged += new EventHandler(Changed);
			checkNewLineAfterKeywords.CheckedChanged += new EventHandler(Changed);
			checkPartsOnNewLines.CheckedChanged += new EventHandler(Changed);
		}

		private void Changed(object sender, EventArgs e)
		{
			Modified = true;
		}

		private void checkNewLineWhereTop_CheckedChanged(object sender, EventArgs e)
		{
			checkNewLineWhereRest.Enabled = checkNewLineWhereTop.Checked;

			if (!checkNewLineWhereTop.Checked)
			{
				checkNewLineWhereRest.Checked = false;
				checkNewLineWhereRest_CheckedChanged(checkNewLineWhereRest, new EventArgs());
			}

			if (sender != null)
			{
				Modified = true;
			}
		}

		private void checkNewLineWhereRest_CheckedChanged(object sender, EventArgs e)
		{
			updownWhereIndent.Enabled = checkNewLineWhereRest.Checked;

			if (sender != null)
			{
				Modified = true;
			}
		}

		private void checkNewLineHavingTop_CheckedChanged(object sender, EventArgs e)
		{
			checkNewLineHavingRest.Enabled = checkNewLineHavingTop.Checked;

			if (!checkNewLineHavingTop.Checked)
			{
				checkNewLineHavingRest.Checked = false;
				checkNewLineHavingRest_CheckedChanged(checkNewLineHavingRest, new EventArgs());
			}

			if (sender != null)
			{
				Modified = true;
			}
		}

		private void checkNewLineHavingRest_CheckedChanged(object sender, EventArgs e)
		{
			updownHavingIndent.Enabled = checkNewLineHavingRest.Checked;

			if (sender != null)
			{
				Modified = true;
			}
		}

		public void ApplyChanges()
		{
			if (this.Modified)
			{
				fFormat.MainPartsFromNewLine = checkPartsOnNewLines.Checked;
				fFormat.NewLineAfterPartKeywords = checkNewLineAfterKeywords.Checked;
				fFormat.IndentInPart = (int) updownPartIndent.Value;
				fFormat.IndentGlobal = (int) updownGlobalIndent.Value;

				fFormat.SelectListFormat.NewLineAfterItem = checkNewLineAfterSelectItem.Checked;

				fFormat.FromClauseFormat.NewLineAfterDatasource = checkNewLineAfterDatasource.Checked;
				fFormat.FromClauseFormat.NewLineAfterJoin = checkNewLineAfterJoin.Checked;

				if (checkNewLineWhereRest.Checked)
				{
					fFormat.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNL.AllLogical;
				}
				else if (checkNewLineWhereTop.Checked)
				{
					fFormat.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNL.TopmostLogical;
				}
				else
				{
					fFormat.WhereFormat.NewLineAfter = SQLBuilderConditionFormatNL.None;
				}

				fFormat.WhereFormat.IndentNestedConditions = (int) updownWhereIndent.Value;

				fFormat.GroupByFormat.NewLineAfterItem = checkNewLineAfterGroupItem.Checked;

				if (checkNewLineHavingRest.Checked)
				{
					fFormat.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNL.AllLogical;
				}
				else if (checkNewLineHavingTop.Checked)
				{
					fFormat.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNL.TopmostLogical;
				}
				else
				{
					fFormat.HavingFormat.NewLineAfter = SQLBuilderConditionFormatNL.None;
				}

				fFormat.HavingFormat.IndentNestedConditions = (int) updownHavingIndent.Value;


				if (fPage == SqlBuilderOptionsPages.MainQuery)
				{
					fBuilder.MainQueryFormat.Assign(fFormat);
				}
				else if (fPage == SqlBuilderOptionsPages.DerievedQueries)
				{
					fBuilder.DerievedQueryFormat.Assign(fFormat);
				}
				else if (fPage == SqlBuilderOptionsPages.ExpressionSubqueries)
				{
					fBuilder.ExpressionSubqueryFormat.Assign(fFormat);
				}
			}
		}		
	}
}
