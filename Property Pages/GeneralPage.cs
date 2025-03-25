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
	internal partial class GeneralPage : UserControl
	{
		private BaseSQLBuilder fBuilder = null;
		private bool fModified = false;


		public bool Modified { get { return fModified; } set { fModified = value; } }


		public GeneralPage(BaseSQLBuilder builder)
		{
			fBuilder = builder;

			InitializeComponent();

			checkWordWrap.Checked = (fBuilder.RightMargin != 0);
			updownRightMargin.Enabled = checkWordWrap.Checked;
			
			if (fBuilder.RightMargin == 0)
			{
				updownRightMargin.Value = 80;
			}
			else
			{
				updownRightMargin.Value = fBuilder.RightMargin;
			}

			checkWordWrap.CheckedChanged += new EventHandler(checkWordWrap_CheckedChanged);
			updownRightMargin.ValueChanged += new EventHandler(updownRightMargin_ValueChanged);			
		}

		private void checkWordWrap_CheckedChanged(object sender, EventArgs e)
		{
			updownRightMargin.Enabled = checkWordWrap.Checked;
			Modified = true;
		}

		private void updownRightMargin_ValueChanged(object sender, EventArgs e)
		{
			Modified = true;			
		}

		public void ApplyChanges()
		{
			if (this.Modified)
			{
				if (checkWordWrap.Checked)
				{
					fBuilder.RightMargin = (int) updownRightMargin.Value;
				}
				else
				{
					fBuilder.RightMargin = 0; 
				}
			}
		}		
	}
}
