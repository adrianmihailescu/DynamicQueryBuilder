namespace SimpleDemo
{
	partial class PanesVisibilityPage
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
			this.checkShowCriteriaPane = new System.Windows.Forms.CheckBox();
			this.checkShowMetadataPane = new System.Windows.Forms.CheckBox();
			this.checkShowStructurePane = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// checkShowCriteriaPane
			// 
			this.checkShowCriteriaPane.AutoSize = true;
			this.checkShowCriteriaPane.Location = new System.Drawing.Point(3, 49);
			this.checkShowCriteriaPane.Name = "checkShowCriteriaPane";
			this.checkShowCriteriaPane.Size = new System.Drawing.Size(116, 17);
			this.checkShowCriteriaPane.TabIndex = 6;
			this.checkShowCriteriaPane.Text = "Show Criteria Pane";
			this.checkShowCriteriaPane.UseVisualStyleBackColor = true;			
			// 
			// checkShowMetadataPane
			// 
			this.checkShowMetadataPane.AutoSize = true;
			this.checkShowMetadataPane.Location = new System.Drawing.Point(3, 26);
			this.checkShowMetadataPane.Name = "checkShowMetadataPane";
			this.checkShowMetadataPane.Size = new System.Drawing.Size(129, 17);
			this.checkShowMetadataPane.TabIndex = 5;
			this.checkShowMetadataPane.Text = "Show Metadata Pane";
			this.checkShowMetadataPane.UseVisualStyleBackColor = true;			
			// 
			// checkShowStructurePane
			// 
			this.checkShowStructurePane.AutoSize = true;
			this.checkShowStructurePane.Location = new System.Drawing.Point(3, 3);
			this.checkShowStructurePane.Name = "checkShowStructurePane";
			this.checkShowStructurePane.Size = new System.Drawing.Size(158, 17);
			this.checkShowStructurePane.TabIndex = 4;
			this.checkShowStructurePane.Text = "Show Query Structure Pane";
			this.checkShowStructurePane.UseVisualStyleBackColor = true;			
			// 
			// PanesVisibilityPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.checkShowCriteriaPane);
			this.Controls.Add(this.checkShowMetadataPane);
			this.Controls.Add(this.checkShowStructurePane);
			this.Name = "PanesVisibilityPage";
			this.Size = new System.Drawing.Size(176, 91);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkShowCriteriaPane;
		private System.Windows.Forms.CheckBox checkShowMetadataPane;
		private System.Windows.Forms.CheckBox checkShowStructurePane;
	}
}
