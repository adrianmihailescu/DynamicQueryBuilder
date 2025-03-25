namespace SimpleDemo
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageSQL = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.queryBuilder1 = new ActiveDatabaseSoftware.ActiveQueryBuilder.QueryBuilder();
			this.imageList16 = new System.Windows.Forms.ImageList(this.components);
			this.universalSyntaxProvider1 = new ActiveDatabaseSoftware.ActiveQueryBuilder.UniversalSyntaxProvider();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabPageData = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.openMetadataFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveMetadataFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.plainTextSQLBuilder1 = new ActiveDatabaseSoftware.ActiveQueryBuilder.PlainTextSQLBuilder();
			this.mssqlMetadataProvider1 = new ActiveDatabaseSoftware.ActiveQueryBuilder.MSSQLMetadataProvider();
			this.oledbMetadataProvider1 = new ActiveDatabaseSoftware.ActiveQueryBuilder.OLEDBMetadataProvider();
			this.odbcMetadataProvider1 = new ActiveDatabaseSoftware.ActiveQueryBuilder.ODBCMetadataProvider();
			this.oracleMetadataProvider1 = new ActiveDatabaseSoftware.ActiveQueryBuilder.OracleMetadataProvider();
			this.eventMetadataProvider1 = new ActiveDatabaseSoftware.ActiveQueryBuilder.EventMetadataProvider();
			this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.connectToMSSQLServerMenuItem = new System.Windows.Forms.MenuItem();
			this.connectToOracleServerMenuItem = new System.Windows.Forms.MenuItem();
			this.connectToAccessDatabaseMenuItem = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.connectOleDbMenuItem = new System.Windows.Forms.MenuItem();
			this.connectODBCMenuItem = new System.Windows.Forms.MenuItem();
			this.fillProgrammaticallyMenuItem = new System.Windows.Forms.MenuItem();
			this.propertiesMenuItem = new System.Windows.Forms.MenuItem();
			this.aboutMenuItem = new System.Windows.Forms.MenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.tabControl1.SuspendLayout();
			this.tabPageSQL.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabPageData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageSQL);
			this.tabControl1.Controls.Add(this.tabPageData);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 49);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(726, 481);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
			// 
			// tabPageSQL
			// 
			this.tabPageSQL.Controls.Add(this.splitContainer1);
			this.tabPageSQL.Location = new System.Drawing.Point(4, 22);
			this.tabPageSQL.Name = "tabPageSQL";
			this.tabPageSQL.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSQL.Size = new System.Drawing.Size(718, 455);
			this.tabPageSQL.TabIndex = 0;
			this.tabPageSQL.Text = "SQL";
			this.tabPageSQL.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.queryBuilder1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.textBox1);
			this.splitContainer1.Size = new System.Drawing.Size(712, 449);
			this.splitContainer1.SplitterDistance = 342;
			this.splitContainer1.TabIndex = 0;
			// 
			// queryBuilder1
			// 
			this.queryBuilder1.AddObjectFormOptions.Height = 342;
			this.queryBuilder1.AddObjectFormOptions.MinimumSize = new System.Drawing.Size(430, 430);
			this.queryBuilder1.AddObjectFormOptions.Width = 294;
			this.queryBuilder1.DiagramObjectColor = System.Drawing.SystemColors.Window;
			this.queryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.queryBuilder1.Location = new System.Drawing.Point(0, 0);
			this.queryBuilder1.MetadataProvider = null;
			this.queryBuilder1.MetadataTreeOptions.DatabaseImageIndex = 6;
			this.queryBuilder1.MetadataTreeOptions.ImageList = this.imageList16;
			this.queryBuilder1.MetadataTreeOptions.ProceduresNodeImageIndex = 4;
			this.queryBuilder1.MetadataTreeOptions.ProceduresNodeText = null;
			this.queryBuilder1.MetadataTreeOptions.SchemaImageIndex = 5;
			this.queryBuilder1.MetadataTreeOptions.SynonymsNodeText = null;
			this.queryBuilder1.MetadataTreeOptions.SystemProceduresImageIndex = 2;
			this.queryBuilder1.MetadataTreeOptions.SystemTablesImageIndex = 0;
			this.queryBuilder1.MetadataTreeOptions.SystemViewsImageIndex = 1;
			this.queryBuilder1.MetadataTreeOptions.TablesNodeImageIndex = 4;
			this.queryBuilder1.MetadataTreeOptions.TablesNodeText = null;
			this.queryBuilder1.MetadataTreeOptions.TreeWidth = 200;
			this.queryBuilder1.MetadataTreeOptions.UserProceduresImageIndex = 2;
			this.queryBuilder1.MetadataTreeOptions.UserTablesImageIndex = 0;
			this.queryBuilder1.MetadataTreeOptions.UserViewsImageIndex = 1;
			this.queryBuilder1.MetadataTreeOptions.ViewsNodeImageIndex = 4;
			this.queryBuilder1.MetadataTreeOptions.ViewsNodeText = null;
			this.queryBuilder1.Name = "queryBuilder1";
			this.queryBuilder1.QueryStructureTreeOptions.FieldImageIndex = 8;
			this.queryBuilder1.QueryStructureTreeOptions.FieldsImageIndex = 7;
			this.queryBuilder1.QueryStructureTreeOptions.FieldsNodeText = "Expressions";
			this.queryBuilder1.QueryStructureTreeOptions.FromImageIndex = 4;
			this.queryBuilder1.QueryStructureTreeOptions.FromNodeText = "Objects";
			this.queryBuilder1.QueryStructureTreeOptions.FromObjImageIndex = 0;
			this.queryBuilder1.QueryStructureTreeOptions.ImageList = this.imageList16;
			this.queryBuilder1.QueryStructureTreeOptions.QueriesImageIndex = 3;
			this.queryBuilder1.QueryStructureTreeOptions.UnionsNodeText = "Unions";
			this.queryBuilder1.Size = new System.Drawing.Size(712, 342);
			this.queryBuilder1.SyntaxProvider = this.universalSyntaxProvider1;
			this.queryBuilder1.TabIndex = 0;
			// 
			// imageList16
			// 
			this.imageList16.ImageStream = ((System.Windows.Forms.ImageListStreamer) (resources.GetObject("imageList16.ImageStream")));
			this.imageList16.TransparentColor = System.Drawing.Color.Magenta;
			this.imageList16.Images.SetKeyName(0, "0.bmp");
			this.imageList16.Images.SetKeyName(1, "1.bmp");
			this.imageList16.Images.SetKeyName(2, "2.bmp");
			this.imageList16.Images.SetKeyName(3, "3.bmp");
			this.imageList16.Images.SetKeyName(4, "4.bmp");
			this.imageList16.Images.SetKeyName(5, "5.bmp");
			this.imageList16.Images.SetKeyName(6, "6.bmp");
			this.imageList16.Images.SetKeyName(7, "7.bmp");
			this.imageList16.Images.SetKeyName(8, "8.bmp");
			// 
			// universalSyntaxProvider1
			// 
			this.universalSyntaxProvider1.BuiltinFunctionNames = ((System.Collections.Generic.List<string>) (resources.GetObject("universalSyntaxProvider1.BuiltinFunctionNames")));
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.HideSelection = false;
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(712, 103);
			this.textBox1.TabIndex = 0;
			this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
			// 
			// tabPageData
			// 
			this.tabPageData.Controls.Add(this.dataGridView1);
			this.tabPageData.Location = new System.Drawing.Point(4, 22);
			this.tabPageData.Name = "tabPageData";
			this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageData.Size = new System.Drawing.Size(718, 455);
			this.tabPageData.TabIndex = 1;
			this.tabPageData.Text = "Data";
			this.tabPageData.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(712, 449);
			this.dataGridView1.TabIndex = 0;
			// 
			// openMetadataFileDialog
			// 
			this.openMetadataFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
			// 
			// saveMetadataFileDialog
			// 
			this.saveMetadataFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
			// 
			// plainTextSQLBuilder1
			// 
			this.plainTextSQLBuilder1.KeywordFormat = ActiveDatabaseSoftware.ActiveQueryBuilder.KeywordFormat.UpperCase;
			this.plainTextSQLBuilder1.QueryBuilder = this.queryBuilder1;
			this.plainTextSQLBuilder1.SQLUpdated += new System.EventHandler(this.plainTextSQLBuilder1_SQLUpdated);
			// 
			// mssqlMetadataProvider1
			// 
			this.mssqlMetadataProvider1.Connection = null;
			// 
			// oledbMetadataProvider1
			// 
			this.oledbMetadataProvider1.Connection = null;
			// 
			// odbcMetadataProvider1
			// 
			this.odbcMetadataProvider1.Connection = null;
			// 
			// oracleMetadataProvider1
			// 
			this.oracleMetadataProvider1.Connection = null;
			// 
			// eventMetadataProvider1
			// 
			this.eventMetadataProvider1.GetViews += new ActiveDatabaseSoftware.ActiveQueryBuilder.GetObjectNamesEventHandler(this.eventMetadataProvider1_GetViews);
			this.eventMetadataProvider1.GetFields += new ActiveDatabaseSoftware.ActiveQueryBuilder.GetFieldNamesEventHandler(this.eventMetadataProvider1_GetFields);
			this.eventMetadataProvider1.GetTables += new ActiveDatabaseSoftware.ActiveQueryBuilder.GetObjectNamesEventHandler(this.eventMetadataProvider1_GetTables);
			this.eventMetadataProvider1.GetRelations += new ActiveDatabaseSoftware.ActiveQueryBuilder.GetTableRelationsEventHandler(this.eventMetadataProvider1_GetRelations);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.propertiesMenuItem,
            this.aboutMenuItem});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.connectToMSSQLServerMenuItem,
            this.connectToOracleServerMenuItem,
            this.connectToAccessDatabaseMenuItem,
            this.menuItem2,
            this.connectOleDbMenuItem,
            this.connectODBCMenuItem,
            this.fillProgrammaticallyMenuItem});
			this.menuItem1.Text = "Connect";
			// 
			// connectToMSSQLServerMenuItem
			// 
			this.connectToMSSQLServerMenuItem.Index = 0;
			this.connectToMSSQLServerMenuItem.Text = "Connect to Microsoft SQL Server";
			this.connectToMSSQLServerMenuItem.Click += new System.EventHandler(this.connectToMSSQLServerMenuItem_Click);
			// 
			// connectToOracleServerMenuItem
			// 
			this.connectToOracleServerMenuItem.Index = 1;
			this.connectToOracleServerMenuItem.Text = "Connect to Oracle Server";
			this.connectToOracleServerMenuItem.Click += new System.EventHandler(this.connectToOracleServerMenuItem_Click);
			// 
			// connectToAccessDatabaseMenuItem
			// 
			this.connectToAccessDatabaseMenuItem.Index = 2;
			this.connectToAccessDatabaseMenuItem.Text = "Connect to Microsoft Access database";
			this.connectToAccessDatabaseMenuItem.Click += new System.EventHandler(this.connectToAccessDatabaseMenuItem_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 3;
			this.menuItem2.Text = "-";
			// 
			// connectOleDbMenuItem
			// 
			this.connectOleDbMenuItem.Index = 4;
			this.connectOleDbMenuItem.Text = "Connect to database through OLE DB";
			this.connectOleDbMenuItem.Click += new System.EventHandler(this.connectOleDbMenuItem_Click);
			// 
			// connectODBCMenuItem
			// 
			this.connectODBCMenuItem.Index = 5;
			this.connectODBCMenuItem.Text = "Connect to database through ODBC";
			this.connectODBCMenuItem.Click += new System.EventHandler(this.connectODBCMenuItem_Click);
			// 
			// fillProgrammaticallyMenuItem
			// 
			this.fillProgrammaticallyMenuItem.Index = 6;
			this.fillProgrammaticallyMenuItem.Text = "Fill the query builder programmatically";
			this.fillProgrammaticallyMenuItem.Click += new System.EventHandler(this.fillProgrammaticallyMenuItem_Click);
			// 
			// propertiesMenuItem
			// 
			this.propertiesMenuItem.Index = 1;
			this.propertiesMenuItem.Text = "Properties...";
			this.propertiesMenuItem.Click += new System.EventHandler(this.propertiesMenuItem_Click);
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Index = 2;
			this.aboutMenuItem.Text = "About...";
			this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.linkLabel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(726, 49);
			this.panel1.TabIndex = 1;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoEllipsis = true;
			this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(267, 47);
			this.linkLabel1.Location = new System.Drawing.Point(0, 0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Padding = new System.Windows.Forms.Padding(3);
			this.linkLabel1.Size = new System.Drawing.Size(724, 47);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = resources.GetString("linkLabel1.Text");
			this.linkLabel1.UseCompatibleTextRendering = true;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(726, 530);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPageSQL.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.tabPageData.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageSQL;
		private System.Windows.Forms.TabPage tabPageData;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private ActiveDatabaseSoftware.ActiveQueryBuilder.QueryBuilder queryBuilder1;
		private System.Windows.Forms.OpenFileDialog openMetadataFileDialog;
		private System.Windows.Forms.SaveFileDialog saveMetadataFileDialog;
		private System.Windows.Forms.ImageList imageList16;
		private ActiveDatabaseSoftware.ActiveQueryBuilder.PlainTextSQLBuilder plainTextSQLBuilder1;
		private ActiveDatabaseSoftware.ActiveQueryBuilder.UniversalSyntaxProvider universalSyntaxProvider1;
		private ActiveDatabaseSoftware.ActiveQueryBuilder.MSSQLMetadataProvider mssqlMetadataProvider1;
		private ActiveDatabaseSoftware.ActiveQueryBuilder.OLEDBMetadataProvider oledbMetadataProvider1;
		private ActiveDatabaseSoftware.ActiveQueryBuilder.ODBCMetadataProvider odbcMetadataProvider1;
		private ActiveDatabaseSoftware.ActiveQueryBuilder.OracleMetadataProvider oracleMetadataProvider1;
		private ActiveDatabaseSoftware.ActiveQueryBuilder.EventMetadataProvider eventMetadataProvider1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem connectToMSSQLServerMenuItem;
		private System.Windows.Forms.MenuItem connectToOracleServerMenuItem;
		private System.Windows.Forms.MenuItem connectToAccessDatabaseMenuItem;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem connectOleDbMenuItem;
		private System.Windows.Forms.MenuItem connectODBCMenuItem;
		private System.Windows.Forms.MenuItem fillProgrammaticallyMenuItem;
		private System.Windows.Forms.MenuItem propertiesMenuItem;
		private System.Windows.Forms.MenuItem aboutMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}

