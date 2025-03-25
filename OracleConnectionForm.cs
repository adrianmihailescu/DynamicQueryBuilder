using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleDemo
{
	public partial class OracleConnectionForm : Form
	{
		public string ConnectionString = "";

		public OracleConnectionForm()
		{
			InitializeComponent();

			comboBoxAuthentication.SelectedIndex = 1; //1 - Oracle Server Authentication

		}

		private void comboBoxAuthentication_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxAuthentication.SelectedIndex == 0)
			{
				//Windows Authentication
				textBoxLogin.Enabled = false;
				textBoxPassword.Enabled = false;
			}
			else
			{
				//Oracle Server Authentication
				textBoxLogin.Enabled = true;
				textBoxPassword.Enabled = true;
			}
		}

		private void buttonConnect_Click(object sender, EventArgs e)
		{
			OracleConnectionStringBuilder builder = new OracleConnectionStringBuilder();

			builder.DataSource = textBoxServerName.Text;

			if (comboBoxAuthentication.SelectedIndex == 0)
			{
				builder.IntegratedSecurity = true;
			}
			else
			{
				builder.IntegratedSecurity = false;
				builder.UserID = textBoxLogin.Text;
				builder.Password = textBoxPassword.Text;
			}

			// check the connection

			using (OracleConnection connection = new OracleConnection(builder.ConnectionString))
			{
				this.Cursor = Cursors.WaitCursor;

				try
				{
					connection.Open();
					ConnectionString = builder.ConnectionString;
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
	}
}