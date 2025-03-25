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
	internal partial class PanesVisibilityPage : UserControl
	{
		private QueryBuilder fQueryBuilder = null;
		bool fModified = false;


		public bool Modified { get { return fModified; } set { fModified = value; } }


		public PanesVisibilityPage(QueryBuilder qb)
		{
			fQueryBuilder = qb;
		
			InitializeComponent();

			checkShowStructurePane.Checked = fQueryBuilder.QueryStructureTreeOptions.TreeVisible;
			checkShowMetadataPane.Checked = fQueryBuilder.MetadataTreeOptions.TreeVisible;
			checkShowCriteriaPane.Checked = fQueryBuilder.CriteriaListOptions.CriteriaListVisible;

			checkShowCriteriaPane.CheckedChanged += new EventHandler(Changed);
			checkShowMetadataPane.CheckedChanged += new EventHandler(Changed);
			checkShowStructurePane.CheckedChanged += new EventHandler(Changed);
		}

		private void Changed(object sender, EventArgs e)
		{
			Modified = true;
		}
		
		public void ApplyChanges()
		{
			if (this.Modified)
			{
				fQueryBuilder.QueryStructureTreeOptions.TreeVisible = checkShowStructurePane.Checked;
				fQueryBuilder.MetadataTreeOptions.TreeVisible = checkShowMetadataPane.Checked;
				fQueryBuilder.CriteriaListOptions.CriteriaListVisible = checkShowCriteriaPane.Checked;
			}
		}
	}
}
