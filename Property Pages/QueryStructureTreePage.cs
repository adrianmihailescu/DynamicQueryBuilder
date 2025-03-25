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
	[ToolboxItem(false)]
	internal partial class QueryStructureTreePage : UserControl
	{
		private QueryBuilder fQueryBuilder = null;
		bool fModified = false;


		public bool Modified { get { return fModified; } set { fModified = value; } }


		public QueryStructureTreePage(QueryBuilder qb)
		{
			fQueryBuilder = qb;

			InitializeComponent();

			checkShowFieldList.Checked = fQueryBuilder.QueryStructureTreeOptions.ShowFields;
			checkShowDataSources.Checked = fQueryBuilder.QueryStructureTreeOptions.ExpandFromNodes;
			textFieldsNodeTitle.Text = fQueryBuilder.QueryStructureTreeOptions.FieldsNodeText;
			textFromNodeTitle.Text = fQueryBuilder.QueryStructureTreeOptions.FromNodeText;
			textUnionsNodeTitle.Text = fQueryBuilder.QueryStructureTreeOptions.UnionsNodeText;
			checkExpandFields.Checked = fQueryBuilder.QueryStructureTreeOptions.ExpandFieldsNodes;
			checkExpandDatasources.Checked = fQueryBuilder.QueryStructureTreeOptions.ExpandFromNodes;
			checkExpandSubqueries.Checked = fQueryBuilder.QueryStructureTreeOptions.ExpandQueryNodes;
			checkExpandUnions.Checked = fQueryBuilder.QueryStructureTreeOptions.ExpandUnionsNodes;

			checkShowFieldList.CheckedChanged += new EventHandler(Changed);
			checkShowDataSources.CheckedChanged += new EventHandler(Changed);
			textFromNodeTitle.TextChanged += new EventHandler(Changed);
			textFieldsNodeTitle.TextChanged += new EventHandler(Changed);
			textUnionsNodeTitle.TextChanged += new EventHandler(Changed);
			checkExpandFields.CheckedChanged += new EventHandler(Changed);
			checkExpandDatasources.CheckedChanged += new EventHandler(Changed);
			checkExpandSubqueries.CheckedChanged += new EventHandler(Changed);
			checkExpandUnions.CheckedChanged += new EventHandler(Changed);
		}

		private void Changed(object sender, EventArgs e)
		{
			Modified = true;
		}

		public void ApplyChanges()
		{
			if (this.Modified)
			{
				fQueryBuilder.BeginUpdate();

				try
				{
					fQueryBuilder.QueryStructureTreeOptions.ShowFields = checkShowFieldList.Checked;
					fQueryBuilder.QueryStructureTreeOptions.ExpandFromNodes = checkShowDataSources.Checked;
					fQueryBuilder.QueryStructureTreeOptions.FieldsNodeText = textFieldsNodeTitle.Text;
					fQueryBuilder.QueryStructureTreeOptions.FromNodeText = textFromNodeTitle.Text;
					fQueryBuilder.QueryStructureTreeOptions.UnionsNodeText = textUnionsNodeTitle.Text;
					fQueryBuilder.QueryStructureTreeOptions.ExpandFieldsNodes = checkExpandFields.Checked;
					fQueryBuilder.QueryStructureTreeOptions.ExpandFromNodes = checkExpandDatasources.Checked;
					fQueryBuilder.QueryStructureTreeOptions.ExpandQueryNodes = checkExpandSubqueries.Checked;
					fQueryBuilder.QueryStructureTreeOptions.ExpandUnionsNodes = checkExpandUnions.Checked;
				}
				finally
				{
					fQueryBuilder.EndUpdate();
				}
			}
		}
	}
}
