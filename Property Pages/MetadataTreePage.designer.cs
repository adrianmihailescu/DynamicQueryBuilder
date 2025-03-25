namespace SimpleDemo
{
	partial class MetadataTreePage
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label11 = new System.Windows.Forms.Label();
			this.comboGroupObjectBy = new System.Windows.Forms.ComboBox();
			this.checkShowSystemProcs = new System.Windows.Forms.CheckBox();
			this.checkShowSystemViews = new System.Windows.Forms.CheckBox();
			this.checkShowSystemTables = new System.Windows.Forms.CheckBox();
			this.checkShowUserProcs = new System.Windows.Forms.CheckBox();
			this.checkShowUserViews = new System.Windows.Forms.CheckBox();
			this.checkShowUserTables = new System.Windows.Forms.CheckBox();
			this.groupLabel3 = new SimpleDemo.GroupLabel();
			this.groupLabel2 = new SimpleDemo.GroupLabel();
			this.groupLabel1 = new SimpleDemo.GroupLabel();
			this.SuspendLayout();
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 231);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(90, 17);
			this.label11.TabIndex = 13;
			this.label11.Text = "Group objects by";
			this.label11.UseCompatibleTextRendering = true;
			// 
			// comboGroupObjectBy
			// 
			this.comboGroupObjectBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboGroupObjectBy.FormattingEnabled = true;
			this.comboGroupObjectBy.Items.AddRange(new object[] {
            "No grouping",
            "Group by Database",
            "Group by Object Type",
            "Group by Database, Schema",
            "Group by Database, Object Type",
            "Group by Object Type, Database",
            "Group by Database, Schema, Object Type",
            "Group by Database, Object Type, Schema",
            "Group by Object Type, Database, Schema"});
			this.comboGroupObjectBy.Location = new System.Drawing.Point(99, 228);
			this.comboGroupObjectBy.Name = "comboGroupObjectBy";
			this.comboGroupObjectBy.Size = new System.Drawing.Size(254, 21);
			this.comboGroupObjectBy.TabIndex = 6;
			// 
			// checkShowSystemProcs
			// 
			this.checkShowSystemProcs.AutoSize = true;
			this.checkShowSystemProcs.Location = new System.Drawing.Point(3, 177);
			this.checkShowSystemProcs.Name = "checkShowSystemProcs";
			this.checkShowSystemProcs.Size = new System.Drawing.Size(150, 18);
			this.checkShowSystemProcs.TabIndex = 5;
			this.checkShowSystemProcs.Text = "Show system procedures";
			this.checkShowSystemProcs.UseCompatibleTextRendering = true;
			this.checkShowSystemProcs.UseVisualStyleBackColor = true;
			// 
			// checkShowSystemViews
			// 
			this.checkShowSystemViews.AutoSize = true;
			this.checkShowSystemViews.Location = new System.Drawing.Point(3, 153);
			this.checkShowSystemViews.Name = "checkShowSystemViews";
			this.checkShowSystemViews.Size = new System.Drawing.Size(122, 18);
			this.checkShowSystemViews.TabIndex = 4;
			this.checkShowSystemViews.Text = "Show system views";
			this.checkShowSystemViews.UseCompatibleTextRendering = true;
			this.checkShowSystemViews.UseVisualStyleBackColor = true;
			// 
			// checkShowSystemTables
			// 
			this.checkShowSystemTables.AutoSize = true;
			this.checkShowSystemTables.Location = new System.Drawing.Point(3, 129);
			this.checkShowSystemTables.Name = "checkShowSystemTables";
			this.checkShowSystemTables.Size = new System.Drawing.Size(124, 18);
			this.checkShowSystemTables.TabIndex = 3;
			this.checkShowSystemTables.Text = "Show system tables";
			this.checkShowSystemTables.UseCompatibleTextRendering = true;
			this.checkShowSystemTables.UseVisualStyleBackColor = true;
			// 
			// checkShowUserProcs
			// 
			this.checkShowUserProcs.AutoSize = true;
			this.checkShowUserProcs.Location = new System.Drawing.Point(3, 78);
			this.checkShowUserProcs.Name = "checkShowUserProcs";
			this.checkShowUserProcs.Size = new System.Drawing.Size(136, 18);
			this.checkShowUserProcs.TabIndex = 2;
			this.checkShowUserProcs.Text = "Show user procedures";
			this.checkShowUserProcs.UseCompatibleTextRendering = true;
			this.checkShowUserProcs.UseVisualStyleBackColor = true;
			// 
			// checkShowUserViews
			// 
			this.checkShowUserViews.AutoSize = true;
			this.checkShowUserViews.Location = new System.Drawing.Point(3, 54);
			this.checkShowUserViews.Name = "checkShowUserViews";
			this.checkShowUserViews.Size = new System.Drawing.Size(108, 18);
			this.checkShowUserViews.TabIndex = 1;
			this.checkShowUserViews.Text = "Show user views";
			this.checkShowUserViews.UseCompatibleTextRendering = true;
			this.checkShowUserViews.UseVisualStyleBackColor = true;
			// 
			// checkShowUserTables
			// 
			this.checkShowUserTables.AutoSize = true;
			this.checkShowUserTables.Location = new System.Drawing.Point(3, 30);
			this.checkShowUserTables.Name = "checkShowUserTables";
			this.checkShowUserTables.Size = new System.Drawing.Size(110, 18);
			this.checkShowUserTables.TabIndex = 0;
			this.checkShowUserTables.Text = "Show user tables";
			this.checkShowUserTables.UseCompatibleTextRendering = true;
			this.checkShowUserTables.UseVisualStyleBackColor = true;
			// 
			// groupLabel3
			// 
			this.groupLabel3.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupLabel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.groupLabel3.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.groupLabel3.Location = new System.Drawing.Point(3, 202);
			this.groupLabel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.groupLabel3.Name = "groupLabel3";
			this.groupLabel3.Size = new System.Drawing.Size(394, 23);
			this.groupLabel3.TabIndex = 16;
			this.groupLabel3.Text = "Grouping";
			this.groupLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupLabel2
			// 
			this.groupLabel2.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.groupLabel2.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.groupLabel2.Location = new System.Drawing.Point(3, 103);
			this.groupLabel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.groupLabel2.Name = "groupLabel2";
			this.groupLabel2.Size = new System.Drawing.Size(394, 23);
			this.groupLabel2.TabIndex = 15;
			this.groupLabel2.Text = "System Objects";
			this.groupLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupLabel1
			// 
			this.groupLabel1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
			this.groupLabel1.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.groupLabel1.Location = new System.Drawing.Point(3, 4);
			this.groupLabel1.Name = "groupLabel1";
			this.groupLabel1.Size = new System.Drawing.Size(394, 23);
			this.groupLabel1.TabIndex = 14;
			this.groupLabel1.Text = "User Objects";
			this.groupLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MetadataTreePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupLabel3);
			this.Controls.Add(this.groupLabel2);
			this.Controls.Add(this.groupLabel1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.comboGroupObjectBy);
			this.Controls.Add(this.checkShowUserTables);
			this.Controls.Add(this.checkShowSystemProcs);
			this.Controls.Add(this.checkShowUserViews);
			this.Controls.Add(this.checkShowSystemViews);
			this.Controls.Add(this.checkShowUserProcs);
			this.Controls.Add(this.checkShowSystemTables);
			this.Name = "MetadataTreePage";
			this.Size = new System.Drawing.Size(400, 261);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox comboGroupObjectBy;
		private System.Windows.Forms.CheckBox checkShowSystemProcs;
		private System.Windows.Forms.CheckBox checkShowSystemViews;
		private System.Windows.Forms.CheckBox checkShowSystemTables;
		private System.Windows.Forms.CheckBox checkShowUserProcs;
		private System.Windows.Forms.CheckBox checkShowUserViews;
		private System.Windows.Forms.CheckBox checkShowUserTables;
		private GroupLabel groupLabel1;
		private GroupLabel groupLabel2;
		private GroupLabel groupLabel3;
	}
}
