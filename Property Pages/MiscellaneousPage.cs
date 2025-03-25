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
	internal partial class MiscellaneousPage : UserControl
	{
		private QueryBuilder fQueryBuilder = null;
		bool fModified = false;


		public bool Modified { get { return fModified; } set { fModified = value; } }


		public MiscellaneousPage(QueryBuilder qb)
		{
			fQueryBuilder = qb;

			InitializeComponent();

			comboAddObjectViewStyle.SelectedIndex = (int) fQueryBuilder.AddObjectFormOptions.ListViewStyle;

			if (fQueryBuilder.LinkStyle is LinkPainterSimple)
			{
				comboLinksStyle.SelectedIndex = 0;
			}
			else if (fQueryBuilder.LinkStyle is LinkPainterAccess)
			{
				comboLinksStyle.SelectedIndex = 1;
			}
			else if (fQueryBuilder.LinkStyle is LinkPainterMSSQL)
			{
				comboLinksStyle.SelectedIndex = 2;
			}

			comboAddObjectViewStyle.SelectedIndexChanged += new EventHandler(Changed);
			comboLinksStyle.SelectedIndexChanged += new EventHandler(Changed);
		}

		public void ApplyChanges()
		{
			if (this.Modified)
			{
				fQueryBuilder.AddObjectFormOptions.ListViewStyle = (View) comboAddObjectViewStyle.SelectedIndex;

				switch (comboLinksStyle.SelectedIndex)
				{
					case 0: 
						fQueryBuilder.LinkStyle = new LinkPainterSimple(fQueryBuilder);
						break;
					case 2:
						fQueryBuilder.LinkStyle = new LinkPainterMSSQL(fQueryBuilder);
						break;
					default:
						fQueryBuilder.LinkStyle = new LinkPainterAccess(fQueryBuilder);
						break;
				}

				fQueryBuilder.RepaintDiagramPane();
			}
		}

		private void Changed(object sender, EventArgs e)
		{
			Modified = true;
		}
	}
}
