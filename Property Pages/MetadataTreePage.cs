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
	internal partial class MetadataTreePage : UserControl
	{
		private QueryBuilder fQueryBuilder = null;
		bool fModified = false;


		public bool Modified { get { return fModified; } set { fModified = value; } }


		public MetadataTreePage(QueryBuilder qb)
		{
			fQueryBuilder = qb;

			InitializeComponent();

			checkShowUserTables.Checked = fQueryBuilder.MetadataTreeOptions.ShowUserTables;
			checkShowUserViews.Checked = fQueryBuilder.MetadataTreeOptions.ShowUserViews;
			checkShowUserProcs.Checked = fQueryBuilder.MetadataTreeOptions.ShowUserProcedures;
			checkShowSystemTables.Checked = fQueryBuilder.MetadataTreeOptions.ShowSystemTables;
			checkShowSystemViews.Checked = fQueryBuilder.MetadataTreeOptions.ShowSystemViews;
			checkShowSystemProcs.Checked = fQueryBuilder.MetadataTreeOptions.ShowSystemProcedures;
			comboGroupObjectBy.SelectedIndex = (int) fQueryBuilder.MetadataTreeOptions.GroupingType;

			checkShowSystemTables.CheckedChanged += new EventHandler(Changed);
			checkShowSystemViews.CheckedChanged += new EventHandler(Changed);
			checkShowSystemProcs.CheckedChanged += new EventHandler(Changed);
			checkShowUserTables.CheckedChanged += new EventHandler(Changed);			
			checkShowUserViews.CheckedChanged += new EventHandler(Changed);
			checkShowUserProcs.CheckedChanged += new EventHandler(Changed);
			comboGroupObjectBy.SelectedIndexChanged += new EventHandler(Changed);			
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
					fQueryBuilder.MetadataTreeOptions.ShowUserTables = checkShowUserTables.Checked;
					fQueryBuilder.MetadataTreeOptions.ShowUserViews = checkShowUserViews.Checked;
					fQueryBuilder.MetadataTreeOptions.ShowUserProcedures = checkShowUserProcs.Checked;
					fQueryBuilder.MetadataTreeOptions.ShowSystemTables = checkShowSystemTables.Checked;
					fQueryBuilder.MetadataTreeOptions.ShowSystemViews = checkShowSystemViews.Checked;
					fQueryBuilder.MetadataTreeOptions.ShowSystemProcedures = checkShowSystemProcs.Checked;
					fQueryBuilder.MetadataTreeOptions.GroupingType = (ObjectsGroupingType) comboGroupObjectBy.SelectedIndex;
				}
				finally
				{
					fQueryBuilder.EndUpdate();
				}
			}
		}
	}
}
