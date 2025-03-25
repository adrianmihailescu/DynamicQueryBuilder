using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Diagnostics;

using ActiveDatabaseSoftware.ActiveQueryBuilder;


namespace SimpleDemo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void aboutMenuItem_Click(object sender, EventArgs e)
		{
			QueryBuilder.ShowAboutDialog();
		}

		private void plainTextSQLBuilder1_SQLUpdated(object sender, EventArgs e)
		{
			// Handle the event raised by SQL builder object that the text of SQL query is changed

			// update the text box
			textBox1.Text = plainTextSQLBuilder1.SQL;
		}

		private void connectToMSSQLServerMenuItem_Click(object sender, EventArgs e)
		{
			// Connect to MS SQL Server
			
			// show the connection form
			using (MSSQLConnectionForm f = new MSSQLConnectionForm())
			{
				if (f.ShowDialog() == DialogResult.OK)
				{
					// create new SqlConnection object using the connections string from the connection form
					mssqlMetadataProvider1.Connection = new SqlConnection(f.ConnectionString);

					// setup the query builder with metadata and syntax providers
					queryBuilder1.MetadataProvider = mssqlMetadataProvider1;
					queryBuilder1.SyntaxProvider = universalSyntaxProvider1;

					// kick the query builder to retrieve the metadata from new connection
					queryBuilder1.RefreshMetadata();
				}
			}
		}

		private void connectToOracleServerMenuItem_Click(object sender, EventArgs e)
		{
			// Connect to Oracle Server

			// Connect using a metadata provider based on Microsoft .NET Framework Data Provider for Oracle.
			// {{

			// show the connection form
			using (OracleConnectionForm f = new OracleConnectionForm())
			{
				if (f.ShowDialog() == DialogResult.OK)
				{
					// create new OracleConnection object using the connections string from the connection form
					oracleMetadataProvider1.Connection = new OracleConnection(f.ConnectionString);

					// setup the query builder with metadata and syntax providers
					queryBuilder1.MetadataProvider = oracleMetadataProvider1;
					queryBuilder1.SyntaxProvider = universalSyntaxProvider1;

					// kick the query builder to retrieve the metadata from new connection
					queryBuilder1.RefreshMetadata();
				}
			}

			// }}

			// You also can use a metadata provider based on the native Oracle Data Provider for .NET (Oracle.DataAccess.Client).
			// Add references to Oracle.DataAccess.Client and ActiveDatabaseSoftware.OracleNativeMetadataProvider, 
			// and uncomment the following code:
			// {{

// 			OracleNativeMetadataProvider oracleNativeMetadataProvider = new OracleNativeMetadataProvider();
// 
// 			// create new OracleConnection object using the connections string from the connection form
// 			oracleNativeMetadataProvider.Connection = new Oracle.DataAccess.Client.OracleConnection();
// 			
// 			// don't forget to edit the connection string
// 			oracleNativeMetadataProvider.Connection.ConnectionString = "Data Source=****;User Id=****;Password=****";
// 
// 			// setup the query builder with metadata and syntax providers
// 			queryBuilder1.MetadataProvider = oracleNativeMetadataProvider;
// 			queryBuilder1.SyntaxProvider = universalSyntaxProvider1;
// 
// 			// kick the query builder to retrieve the metadata from new connection
// 			queryBuilder1.RefreshMetadata();

			// }}
		}

		private void connectToAccessDatabaseMenuItem_Click(object sender, EventArgs e)
		{
			// Connect to MS Access database using OLE DB provider

			// show the connection form
			using (AccessConnectionForm f = new AccessConnectionForm())
			{
				if (f.ShowDialog() == DialogResult.OK)
				{
					// create new OleDbConnection object using the connections string from the connection form
					oledbMetadataProvider1.Connection = new OleDbConnection(f.ConnectionString);

					// setup the query builder with metadata and syntax providers
					queryBuilder1.MetadataProvider = oledbMetadataProvider1;
					queryBuilder1.SyntaxProvider = universalSyntaxProvider1;

					// kick the query builder to retrieve metadata from new connection
					queryBuilder1.RefreshMetadata();
				}
			}
		}

		private void connectOleDbMenuItem_Click(object sender, EventArgs e)
		{
			// Connect to a database through the OLE DB provider

			// show the connection form
			using (OLEDBConnectionForm f = new OLEDBConnectionForm())
			{
				if (f.ShowDialog() == DialogResult.OK)
				{
					// create new OleDbConnection object using the connections string from the connection form
					oledbMetadataProvider1.Connection = new OleDbConnection(f.ConnectionString);

					// setup the query builder with metadata and syntax providers
					queryBuilder1.MetadataProvider = oledbMetadataProvider1;
					queryBuilder1.SyntaxProvider = universalSyntaxProvider1;

					// kick the query builder to retrieve the metadata from new connection
					queryBuilder1.RefreshMetadata();
				}
			}
		}

		private void connectODBCMenuItem_Click(object sender, EventArgs e)
		{
			// Connect to a database through the ODBC provider

			// show the connection form
			using (ODBCConnectionForm f = new ODBCConnectionForm())
			{
				if (f.ShowDialog() == DialogResult.OK)
				{
					// create new OdbcConnection object using the connections string from the connection form
					odbcMetadataProvider1.Connection = new OdbcConnection(f.ConnectionString);

					// setup the query builder with metadata and syntax providers
					queryBuilder1.MetadataProvider = odbcMetadataProvider1;
					queryBuilder1.SyntaxProvider = universalSyntaxProvider1;

					// kick the query builder to retrieve the metadata from new connection
					queryBuilder1.RefreshMetadata();
				}
			}
		}

		private void fillProgrammaticallyMenuItem_Click(object sender, EventArgs e)
		{
			// Fill the query builder metadata programmatically using the EventMetadataProvider
			// The query builder will send you events to retrieve database objects, their fields and relations.

			// setup the query builder with metadata and syntax providers
			queryBuilder1.MetadataProvider = eventMetadataProvider1;
			queryBuilder1.SyntaxProvider = universalSyntaxProvider1;

			// kick the query builder to retrieve the metadata
			queryBuilder1.RefreshMetadata();
		}

		private void eventMetadataProvider1_GetTables(BaseMetadataProvider sender, SQLQualifiedNameList databaseObjects)
		{
			databaseObjects.Add("my_database.my_schema.Customers");
			databaseObjects.Add("my_database.my_schema.Locations");
			databaseObjects.Add("my_database.my_schema.Orders");
		}

		private void eventMetadataProvider1_GetViews(BaseMetadataProvider sender, SQLQualifiedNameList databaseObjects)
		{
			databaseObjects.Add("my_database.my_schema.MyCustomers");
		}

		private void eventMetadataProvider1_GetFields(BaseMetadataProvider sender, MetadataObject obj)
		{
			if (obj.FullNameStr == "my_database.my_schema.Customers")
			{
				obj.Fields.AddField("ID");
				obj.Fields.AddField("Name");
				obj.Fields.AddField("Location");
			}
			else if (obj.FullNameStr == "my_database.my_schema.Locations")
			{
				obj.Fields.AddField("ID");
				obj.Fields.AddField("Name");
			}
			else if (obj.FullNameStr == "my_database.my_schema.Orders")
			{
				obj.Fields.AddField("ID");
				obj.Fields.AddField("CustomerRef");
				obj.Fields.AddField("Sum");
			}
			else if (obj.FullNameStr == "my_database.my_schema.MyCustomers")
			{
				obj.Fields.AddField("ID");
				obj.Fields.AddField("Name");
			}
		}

		private void eventMetadataProvider1_GetRelations(BaseMetadataProvider sender, MetadataObject obj)
		{
			if (obj.FullNameStr == "my_database.my_schema.Customers")
			{
				MetadataRelation r = obj.Relations.Add();

				r.KeyFields.AddField("ID");
				r.ChildTable.Parse("my_database.my_schema.Orders");
				r.ChildFields.AddField("CustomerRef");
			}
			else if (obj.FullNameStr == "my_database.my_schema.Locations")
			{
				MetadataRelation r = obj.Relations.Add();

				r.KeyFields.AddField("ID");
				r.ChildTable.Parse("my_database.my_schema.Customers");
				r.ChildFields.AddField("Location");
			}
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			// Update the query builder with new manually edited SQL query text

			if (textBox1.Modified)
			{
				try
				{
					queryBuilder1.SQL = textBox1.Text;
					
					// !!!
					// QueryBuilder.SQL property is asynchronous.
					// If you need to wait until the QueryBuilder is updated, use QueryBuilder.SyncSQL property instead.
					// !!!
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Parsing error");
				}

				textBox1.Modified = false;
			}
		}

		private void tabControl1_Selected(object sender, TabControlEventArgs e)
		{
			// Try to execute the SQL query using current database connection

			if (e.TabPage == tabPageData)
			{
				dataGridView1.DataSource = null;

				if (queryBuilder1.MetadataProvider != null && queryBuilder1.MetadataProvider.Connected)
				{
					if (queryBuilder1.MetadataProvider is MSSQLMetadataProvider)
					{
						SqlCommand cmd = ((MSSQLMetadataProvider) queryBuilder1.MetadataProvider).Connection.CreateCommand();
						
						cmd.CommandTimeout = 30;
						cmd.CommandText = queryBuilder1.SQL;

						SqlDataAdapter adapter = new SqlDataAdapter(cmd);
						DataSet dataset = new DataSet();

						try
						{
							adapter.Fill(dataset, "QueryResult");
							dataGridView1.DataSource = dataset.Tables["QueryResult"];
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "SQL query error");
						}
					}
					else if (queryBuilder1.MetadataProvider is OracleMetadataProvider)
					{
						OracleCommand cmd = ((OracleMetadataProvider) queryBuilder1.MetadataProvider).Connection.CreateCommand();

						cmd.CommandTimeout = 30;
						cmd.CommandText = queryBuilder1.SQL;

						OracleDataAdapter adapter = new OracleDataAdapter(cmd);
						DataSet dataset = new DataSet();

						try
						{
							adapter.Fill(dataset, "QueryResult");
							dataGridView1.DataSource = dataset.Tables["QueryResult"];
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "SQL query error");
						}
					}
					else if (queryBuilder1.MetadataProvider is OLEDBMetadataProvider)
					{
						OleDbCommand cmd = ((OLEDBMetadataProvider) queryBuilder1.MetadataProvider).Connection.CreateCommand();

						cmd.CommandTimeout = 30;
						cmd.CommandText = queryBuilder1.SQL;

						OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
						DataSet dataset = new DataSet();

						try
						{
							adapter.Fill(dataset, "QueryResult");
							dataGridView1.DataSource = dataset.Tables["QueryResult"];
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "SQL query error");
						}
					}
					else if (queryBuilder1.MetadataProvider is ODBCMetadataProvider)
					{
						OdbcCommand cmd = ((ODBCMetadataProvider) queryBuilder1.MetadataProvider).Connection.CreateCommand();

						cmd.CommandTimeout = 30;
						cmd.CommandText = queryBuilder1.SQL;

						OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
						DataSet dataset = new DataSet();

						try
						{
							adapter.Fill(dataset, "QueryResult");
							dataGridView1.DataSource = dataset.Tables["QueryResult"];
						}
						catch (Exception ex)
						{
							MessageBox.Show(ex.Message, "SQL query error");
						}
					}
				}
			}
		}

		private void propertiesMenuItem_Click(object sender, EventArgs e)
		{
			// Here you can show internal properties form of the Active Query Builder...	

// 			queryBuilder1.ShowQueryBuilderPropertiesForm("Active Query Builder Properties",
// 				QueryBuilderProperties.NonVisual | QueryBuilderProperties.Visual | QueryBuilderProperties.SqlBuilder,
// 				plainTextSQLBuilder1);

			// ... or use own customized properties form:

			ShowCustomProperties("Query Builder Properties",
				QueryBuilderProperties.NonVisual | QueryBuilderProperties.Visual | QueryBuilderProperties.SqlBuilder,
				plainTextSQLBuilder1);
		}

		private void ShowCustomProperties(string title, QueryBuilderProperties flags, BaseSQLBuilder builder)
		{
			using (SimpleDemo.QueryBuilderPropertiesForm f = new SimpleDemo.QueryBuilderPropertiesForm(queryBuilder1, title, flags, builder))
			{
				f.ShowDialog();
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.activequerybuilder.com/trequest.html");
		}
	}
}