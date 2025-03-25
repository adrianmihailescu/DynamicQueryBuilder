using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using ActiveDatabaseSoftware.ActiveQueryBuilder;


namespace SimpleDemo
{
	[ToolboxItem(false)]
	internal partial class SqlSyntaxPage : UserControl
	{
		private QueryBuilder fQueryBuilder = null;
		private BaseSyntaxProvider fSyntaxProvider = null;
		bool fModified = false;

		
		public bool Modified { get { return fModified; } set { fModified = value; } }


		public SqlSyntaxPage(QueryBuilder qb, BaseSyntaxProvider sp)
		{
			fQueryBuilder = qb;
			fSyntaxProvider = sp;

			InitializeComponent();

			comboSqlDialect.SelectedIndex = 0;

			comboIdentCaseSens.SelectedIndex = (int) fSyntaxProvider.IdentCaseSens;
			textBeginQuotationSymbol.Text = fSyntaxProvider.QuoteBegin;
			textEndQuotationSymbol.Text = fSyntaxProvider.QuoteEnd;
			checkQuoteAllIdentifiers.Checked = qb.QuoteAllIdentifiers;

			pictureInformation.Image = SystemIcons.Information.ToBitmap();

			comboIdentCaseSens.SelectedIndexChanged += new EventHandler(this.comboIdentCaseSens_SelectedIndexChanged);
			checkQuoteAllIdentifiers.CheckedChanged += new EventHandler(this.checkQuoteAllIdentifiers_CheckedChanged);
		}


		private void comboIdentCaseSens_SelectedIndexChanged(object sender, EventArgs e)
		{
			fSyntaxProvider.IdentCaseSens = (IdentCaseSensitivity) comboIdentCaseSens.SelectedIndex;
			comboIdentCaseSens.SelectedIndex = (int) fSyntaxProvider.IdentCaseSens;

			this.Modified = true;
		}

		private void checkQuoteAllIdentifiers_CheckedChanged(object sender, EventArgs e)
		{
			this.Modified = true;
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.activequerybuilder.com/trequest.html");
		}

		public void ApplyChanges()
		{
			if (this.Modified)
			{
				fQueryBuilder.QuoteAllIdentifiers = checkQuoteAllIdentifiers.Checked;
			}
		}
	}
}
