namespace SimpleDemo
{
	partial class SqlSyntaxPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlSyntaxPage));
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label29 = new System.Windows.Forms.Label();
			this.pictureInformation = new System.Windows.Forms.PictureBox();
			this.panelFree = new System.Windows.Forms.Panel();
			this.checkQuoteAllIdentifiers = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textEndQuotationSymbol = new System.Windows.Forms.TextBox();
			this.comboSqlDialect = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboIdentCaseSens = new System.Windows.Forms.ComboBox();
			this.textBeginQuotationSymbol = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) (this.pictureInformation)).BeginInit();
			this.panelFree.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(51, 88);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(246, 17);
			this.linkLabel1.TabIndex = 2;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "http://www.activequerybuilder.com/trequest.html";
			this.linkLabel1.UseCompatibleTextRendering = true;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// label29
			// 
			this.label29.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label29.Location = new System.Drawing.Point(51, 3);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(335, 85);
			this.label29.TabIndex = 1;
			this.label29.Text = resources.GetString("label29.Text");
			this.label29.UseCompatibleTextRendering = true;
			// 
			// pictureInformation
			// 
			this.pictureInformation.Location = new System.Drawing.Point(3, 3);
			this.pictureInformation.Name = "pictureInformation";
			this.pictureInformation.Size = new System.Drawing.Size(42, 37);
			this.pictureInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureInformation.TabIndex = 0;
			this.pictureInformation.TabStop = false;
			// 
			// panelFree
			// 
			this.panelFree.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.panelFree.BackColor = System.Drawing.SystemColors.Info;
			this.panelFree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelFree.Controls.Add(this.linkLabel1);
			this.panelFree.Controls.Add(this.label29);
			this.panelFree.Controls.Add(this.pictureInformation);
			this.panelFree.Location = new System.Drawing.Point(3, 166);
			this.panelFree.Name = "panelFree";
			this.panelFree.Size = new System.Drawing.Size(391, 113);
			this.panelFree.TabIndex = 19;
			// 
			// checkQuoteAllIdentifiers
			// 
			this.checkQuoteAllIdentifiers.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkQuoteAllIdentifiers.Location = new System.Drawing.Point(3, 114);
			this.checkQuoteAllIdentifiers.Name = "checkQuoteAllIdentifiers";
			this.checkQuoteAllIdentifiers.Size = new System.Drawing.Size(176, 21);
			this.checkQuoteAllIdentifiers.TabIndex = 14;
			this.checkQuoteAllIdentifiers.Text = "Quote All Identifiers";
			this.checkQuoteAllIdentifiers.UseCompatibleTextRendering = true;
			this.checkQuoteAllIdentifiers.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(162, 86);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 17);
			this.label5.TabIndex = 13;
			this.label5.Text = "End:";
			this.label5.UseCompatibleTextRendering = true;
			// 
			// textEndQuotationSymbol
			// 
			this.textEndQuotationSymbol.Location = new System.Drawing.Point(199, 83);
			this.textEndQuotationSymbol.Name = "textEndQuotationSymbol";
			this.textEndQuotationSymbol.ReadOnly = true;
			this.textEndQuotationSymbol.Size = new System.Drawing.Size(70, 20);
			this.textEndQuotationSymbol.TabIndex = 18;
			// 
			// comboSqlDialect
			// 
			this.comboSqlDialect.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.comboSqlDialect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSqlDialect.Enabled = false;
			this.comboSqlDialect.FormattingEnabled = true;
			this.comboSqlDialect.Items.AddRange(new object[] {
            "Universal"});
			this.comboSqlDialect.Location = new System.Drawing.Point(162, 3);
			this.comboSqlDialect.Name = "comboSqlDialect";
			this.comboSqlDialect.Size = new System.Drawing.Size(235, 21);
			this.comboSqlDialect.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(162, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "Start:";
			this.label4.UseCompatibleTextRendering = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 17);
			this.label1.TabIndex = 10;
			this.label1.Text = "SQL Dialect:";
			this.label1.UseCompatibleTextRendering = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 17);
			this.label3.TabIndex = 11;
			this.label3.Text = "Identifier Quotation Symbols:";
			this.label3.UseCompatibleTextRendering = true;
			// 
			// comboIdentCaseSens
			// 
			this.comboIdentCaseSens.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.comboIdentCaseSens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboIdentCaseSens.DropDownWidth = 300;
			this.comboIdentCaseSens.FormattingEnabled = true;
			this.comboIdentCaseSens.Items.AddRange(new object[] {
            "All identifiers are case insensitive",
            "Quoted are sensitive, Unquoted are converted to uppercase",
            "Quoted are sensitive, Unquoted are converted to lowercase"});
			this.comboIdentCaseSens.Location = new System.Drawing.Point(162, 30);
			this.comboIdentCaseSens.Name = "comboIdentCaseSens";
			this.comboIdentCaseSens.Size = new System.Drawing.Size(235, 21);
			this.comboIdentCaseSens.TabIndex = 16;
			// 
			// textBeginQuotationSymbol
			// 
			this.textBeginQuotationSymbol.Location = new System.Drawing.Point(199, 57);
			this.textBeginQuotationSymbol.Name = "textBeginQuotationSymbol";
			this.textBeginQuotationSymbol.ReadOnly = true;
			this.textBeginQuotationSymbol.Size = new System.Drawing.Size(70, 20);
			this.textBeginQuotationSymbol.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 17);
			this.label2.TabIndex = 17;
			this.label2.Text = "Identifiers Case Sensitivity:";
			this.label2.UseCompatibleTextRendering = true;
			// 
			// SqlSyntaxPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelFree);
			this.Controls.Add(this.checkQuoteAllIdentifiers);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textEndQuotationSymbol);
			this.Controls.Add(this.comboSqlDialect);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboIdentCaseSens);
			this.Controls.Add(this.textBeginQuotationSymbol);
			this.Controls.Add(this.label2);
			this.Name = "SqlSyntaxPage";
			this.Size = new System.Drawing.Size(400, 282);
			((System.ComponentModel.ISupportInitialize) (this.pictureInformation)).EndInit();
			this.panelFree.ResumeLayout(false);
			this.panelFree.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.PictureBox pictureInformation;
		private System.Windows.Forms.Panel panelFree;
		private System.Windows.Forms.CheckBox checkQuoteAllIdentifiers;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textEndQuotationSymbol;
		private System.Windows.Forms.ComboBox comboSqlDialect;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboIdentCaseSens;
		private System.Windows.Forms.TextBox textBeginQuotationSymbol;
		private System.Windows.Forms.Label label2;
	}
}
