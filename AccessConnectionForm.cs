using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleDemo
{
	public partial class AccessConnectionForm : Form
	{
		public string ConnectionString = "";

		public AccessConnectionForm()
		{
			InitializeComponent();
		}

		private void buttonConnect_Click(object sender, EventArgs e)
		{
			ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0";
			ConnectionString += ";Data Source=" + textboxDatabase.Text;
			ConnectionString += ";User Id=" + textboxUserName.Text;
			ConnectionString += ";Password=";

			if (textboxPassword.Text.Length > 0)
			{
				ConnectionString += textboxPassword.Text + ";";
			}

			// check the connection

			using (OleDbConnection connection = new OleDbConnection(ConnectionString))
			{
				this.Cursor = Cursors.WaitCursor;

				try
				{
					connection.Open();
				}
				catch (System.Exception ex)
				{
					MessageBox.Show(ex.Message, "Connection Failure.");
					this.DialogResult = DialogResult.None;
				}
				finally
				{
					this.Cursor = Cursors.Default;
				}
			}
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				textboxDatabase.Text = openFileDialog1.FileName;
			}
		}
	}
}