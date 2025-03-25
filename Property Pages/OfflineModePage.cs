using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ActiveDatabaseSoftware.ActiveQueryBuilder;
using System.Diagnostics;


namespace SimpleDemo
{
	[ToolboxItem(false)]
	internal partial class OfflineModePage : UserControl
	{
		private QueryBuilder fQueryBuilder = null;
		private BaseSyntaxProvider fSyntaxProvider = null;
		bool fModified = false;


		public bool Modified { get { return fModified; } set { fModified = value; } }


		public OfflineModePage(QueryBuilder qb, BaseSyntaxProvider sp)
		{
			fQueryBuilder = qb;
			fSyntaxProvider = sp;

			InitializeComponent();

			checkOfflineMode.Checked = qb.OfflineMode;

			pictureInformation.Image = SystemIcons.Information.ToBitmap();

			UpdateMode();

			checkOfflineMode.CheckedChanged += new EventHandler(checkOfflineMode_CheckedChanged);
		}

		public void ApplyChanges()
		{
			if (this.Modified)
			{
			}
		}

		private void checkOfflineMode_CheckedChanged(object sender, EventArgs e)
		{
			Modified = true;

			UpdateMode();
		}

		private void buttonLoadMetadata_Click(object sender, EventArgs e)
		{
		}

		private void UpdateMode()
		{
			labelMetadataObjectCount.Font = new Font(labelMetadataObjectCount.Font, (checkOfflineMode.Checked) ? FontStyle.Bold : FontStyle.Regular);
			buttonLoadFromXML.Enabled = checkOfflineMode.Checked;
			buttonSaveToXML.Enabled = checkOfflineMode.Checked;
			buttonEditMetadata.Enabled = checkOfflineMode.Checked;
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.activequerybuilder.com/trequest.html");
		}
	}
}
