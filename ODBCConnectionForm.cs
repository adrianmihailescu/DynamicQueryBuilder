using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleDemo
{
	public partial class ODBCConnectionForm : Form
	{
		public string ConnectionString = "";

		public ODBCConnectionForm()
		{
			InitializeComponent();
		}

		private void buttonConnect_Click(object sender, EventArgs e)
		{
			OdbcConnectionStringBuilder builder = new OdbcConnectionStringBuilder();

			try
			{
				builder.ConnectionString = textBoxConnectionString.Text;

				this.Cursor = Cursors.WaitCursor;

				using (OdbcConnection connection = new OdbcConnection(builder.ConnectionString))
				{
					try
					{
						connection.Open();
						ConnectionString = builder.ConnectionString;
					}
					catch (System.Exception ex)
					{
						MessageBox.Show(ex.Message, "Failed to connect.");
						this.DialogResult = DialogResult.None;
					}
					finally
					{
						this.Cursor = Cursors.Default;
					}
				}
			}
			catch (ArgumentException ae)
			{
				MessageBox.Show(ae.Message, "Invalid OLE DB connection string.");
				this.DialogResult = DialogResult.None;
			}
		}
	}
}