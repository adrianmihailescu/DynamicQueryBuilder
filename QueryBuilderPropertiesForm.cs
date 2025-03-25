using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using ActiveDatabaseSoftware.ActiveQueryBuilder;


namespace SimpleDemo
{
	internal partial class QueryBuilderPropertiesForm : Form
	{
		private QueryBuilder fQueryBuilder;
		private BaseSyntaxProvider fSyntaxProvider;

		private SqlSyntaxPage sqlSyntaxPage;
		private OfflineModePage offlineModePage;
		private PanesVisibilityPage panesVisibilityPage;
		private QueryStructureTreePage queryStructureTreePage;
		private MetadataTreePage metadataTreePage;
		private MiscellaneousPage miscellaneousPage;
		private GeneralPage generalPage;
		private SqlBuilderPage mainQueryPage;
		private SqlBuilderPage derievedQueriesPage;
		private SqlBuilderPage expressionSubqueriesPage;

		private LinkLabel currentSelectedLink = null;


		[DefaultValue(false)]
		[Browsable(false)]
		public bool Modified
		{
			get
			{
				return ((sqlSyntaxPage != null && sqlSyntaxPage.Modified) ||
						(offlineModePage != null && offlineModePage.Modified) || 
						(panesVisibilityPage != null && panesVisibilityPage.Modified) ||
						(queryStructureTreePage != null && queryStructureTreePage.Modified) || 
						(metadataTreePage != null && metadataTreePage.Modified) || 
						(miscellaneousPage != null && miscellaneousPage.Modified) ||
						(generalPage != null && generalPage.Modified) || 
						(mainQueryPage != null && mainQueryPage.Modified) || 
						(derievedQueriesPage != null && derievedQueriesPage.Modified) || 
						(expressionSubqueriesPage != null && expressionSubqueriesPage.Modified));
			}
			set
			{
				if (sqlSyntaxPage != null) sqlSyntaxPage.Modified = value;
				if (offlineModePage != null) offlineModePage.Modified = value;
				if (panesVisibilityPage != null) panesVisibilityPage.Modified = value;
				if (queryStructureTreePage != null) queryStructureTreePage.Modified = value;
				if (metadataTreePage != null) metadataTreePage.Modified = value;
				if (miscellaneousPage != null) miscellaneousPage.Modified = value;
				if (generalPage != null) generalPage.Modified = value;
				if (mainQueryPage != null) mainQueryPage.Modified = value;
				if (derievedQueriesPage != null) derievedQueriesPage.Modified = value;
				if (expressionSubqueriesPage != null) expressionSubqueriesPage.Modified = value;
			}
		}


		public QueryBuilderPropertiesForm(QueryBuilder qb, string title, QueryBuilderProperties flags, BaseSQLBuilder builder)
		{
			Debug.Assert(qb != null);

			InitializeComponent();

			this.Text = title;
			this.labelHeader.Text = title;

 			fQueryBuilder = qb;

			if ((flags & QueryBuilderProperties.NonVisual) == QueryBuilderProperties.NonVisual)
			{
				fSyntaxProvider = qb.SyntaxProvider;

				sqlSyntaxPage = new SqlSyntaxPage(fQueryBuilder, fSyntaxProvider);
				offlineModePage = new OfflineModePage(fQueryBuilder, fSyntaxProvider);

				Menu_LinkClicked(linkSqlSyntax, new LinkLabelLinkClickedEventArgs(linkSqlSyntax.Links[0], MouseButtons.Left));
			}
			else
			{
				labelNonVisual.Visible = false;
				linkSqlSyntax.Visible = false;
				linkOfflineMode.Visible = false;
			}

			if ((flags & QueryBuilderProperties.Visual) == QueryBuilderProperties.Visual)
			{
				panesVisibilityPage = new PanesVisibilityPage(fQueryBuilder);
				queryStructureTreePage = new QueryStructureTreePage(fQueryBuilder);
				metadataTreePage = new MetadataTreePage(fQueryBuilder);
				miscellaneousPage = new MiscellaneousPage(fQueryBuilder);

				if ((flags & QueryBuilderProperties.NonVisual) != QueryBuilderProperties.NonVisual)
				{
					Menu_LinkClicked(linkPanesVisibility, new LinkLabelLinkClickedEventArgs(linkPanesVisibility.Links[0], MouseButtons.Left));
				}
			}
			else
			{
				labelVisual.Visible = false;
				linkPanesVisibility.Visible = false;
				linkQueryStructureTree.Visible = false;
				linkMetadataTree.Visible = false;
				linkMiscellaneous.Visible = false;
			}

			if ((flags & QueryBuilderProperties.SqlBuilder) == QueryBuilderProperties.SqlBuilder && builder != null)
			{
				generalPage = new GeneralPage(builder);
				mainQueryPage = new SqlBuilderPage(SqlBuilderOptionsPages.MainQuery, builder);
				derievedQueriesPage = new SqlBuilderPage(SqlBuilderOptionsPages.DerievedQueries, builder);
				expressionSubqueriesPage = new SqlBuilderPage(SqlBuilderOptionsPages.ExpressionSubqueries, builder);

				if ((flags & QueryBuilderProperties.NonVisual) != QueryBuilderProperties.NonVisual &&
					(flags & QueryBuilderProperties.Visual) != QueryBuilderProperties.Visual)
				{
					Menu_LinkClicked(linkGeneral, new LinkLabelLinkClickedEventArgs(linkGeneral.Links[0], MouseButtons.Left));
				}
			}
			else
			{
				labelSqlBuilder.Visible = false;
				linkGeneral.Visible = false;
				linkMainQuery.Visible = false;
				linkDerievedQueries.Visible = false;
				linkExpressionSubqueries.Visible = false;

				if (builder == null)
				{
					throw new Exception("Invalid SQLBuilder object.");
				}
			}

			Application.Idle += new EventHandler(Application_Idle);
		}

		private void Application_Idle(object sender, EventArgs e)
		{
			buttonApply.Enabled = this.Modified;
		}

		private void QueryBuilderPropertiesForm_Paint(object sender, PaintEventArgs e)
		{
			Rectangle r = Rectangle.Inflate(panel1.Bounds, 1, 1);

			e.Graphics.DrawRectangle(SystemPens.ControlDark, r);
		}

		private void Menu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (currentSelectedLink != null)
			{
				currentSelectedLink.LinkColor = Color.Black;
			}

			if (sender == linkSqlSyntax) SwitchPage(sqlSyntaxPage);
			else if (sender == linkOfflineMode) SwitchPage(offlineModePage);
			else if (sender == linkPanesVisibility) SwitchPage(panesVisibilityPage);
			else if (sender == linkQueryStructureTree) SwitchPage(queryStructureTreePage);
			else if (sender == linkMetadataTree) SwitchPage(metadataTreePage);
			else if (sender == linkMiscellaneous) SwitchPage(miscellaneousPage);
			else if (sender == linkGeneral) SwitchPage(generalPage);
			else if (sender == linkMainQuery) SwitchPage(mainQueryPage);
			else if (sender == linkDerievedQueries) SwitchPage(derievedQueriesPage);
			else if (sender == linkExpressionSubqueries) SwitchPage(expressionSubqueriesPage);

			currentSelectedLink = (LinkLabel) sender;
			currentSelectedLink.LinkColor = Color.Red;
		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
			ApplyChanges();
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			ApplyChanges();
		}

		private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{
			Pen p = new Pen(SystemColors.ControlDark, 1);
			Point first = new Point(flowLayoutPanel1.ClientRectangle.Right-1, flowLayoutPanel1.ClientRectangle.Top + 10);
			Point second = new Point(flowLayoutPanel1.ClientRectangle.Right-1, flowLayoutPanel1.ClientRectangle.Bottom - 10);

			e.Graphics.DrawLine(p, first, second);
		}

		private void SwitchPage(UserControl page)
		{
			panelPages.Controls.Clear();
			page.Location = new Point(panelPages.Padding.Left, panelPages.Padding.Top);
			panelPages.Controls.Add(page);
			panelPages.AutoScrollPosition = new Point(0, 0);
		}

		public void ApplyChanges()
		{
			if (sqlSyntaxPage != null) sqlSyntaxPage.ApplyChanges();
			if (offlineModePage != null) offlineModePage.ApplyChanges();
			if (panesVisibilityPage != null) panesVisibilityPage.ApplyChanges();
			if (queryStructureTreePage != null) queryStructureTreePage.ApplyChanges();
			if (metadataTreePage != null) metadataTreePage.ApplyChanges();
			if (miscellaneousPage != null) miscellaneousPage.ApplyChanges();
			if (generalPage != null) generalPage.ApplyChanges();
			if (mainQueryPage != null) mainQueryPage.ApplyChanges();
			if (derievedQueriesPage != null) derievedQueriesPage.ApplyChanges();
			if (expressionSubqueriesPage != null) expressionSubqueriesPage.ApplyChanges();

			this.Modified = false;
		}
	}
}