namespace SimpleDemo
{
	partial class MiscellaneousPage
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
			this.label7 = new System.Windows.Forms.Label();
			this.comboLinksStyle = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.comboAddObjectViewStyle = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 33);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(105, 17);
			this.label7.TabIndex = 8;
			this.label7.Text = "Diagram Links Style";
			this.label7.UseCompatibleTextRendering = true;
			// 
			// comboLinksStyle
			// 
			this.comboLinksStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboLinksStyle.FormattingEnabled = true;
			this.comboLinksStyle.Items.AddRange(new object[] {
            "Simple style",
            "MS Access style",
            "SQL Server Enterpise Manager style"});
			this.comboLinksStyle.Location = new System.Drawing.Point(142, 30);
			this.comboLinksStyle.Name = "comboLinksStyle";
			this.comboLinksStyle.Size = new System.Drawing.Size(159, 21);
			this.comboLinksStyle.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 6);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(133, 17);
			this.label6.TabIndex = 6;
			this.label6.Text = "Add Object Form list style";
			this.label6.UseCompatibleTextRendering = true;
			// 
			// comboAddObjectViewStyle
			// 
			this.comboAddObjectViewStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboAddObjectViewStyle.FormattingEnabled = true;
			this.comboAddObjectViewStyle.Items.AddRange(new object[] {
            "Large Icons",
            "Details",
            "Small Icons",
            "List",
            "Tiles"});
			this.comboAddObjectViewStyle.Location = new System.Drawing.Point(142, 3);
			this.comboAddObjectViewStyle.Name = "comboAddObjectViewStyle";
			this.comboAddObjectViewStyle.Size = new System.Drawing.Size(159, 21);
			this.comboAddObjectViewStyle.TabIndex = 5;
			// 
			// MiscellaneousPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboLinksStyle);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.comboAddObjectViewStyle);
			this.Name = "MiscellaneousPage";
			this.Size = new System.Drawing.Size(308, 58);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboLinksStyle;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboAddObjectViewStyle;
	}
}
