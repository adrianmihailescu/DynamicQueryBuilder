namespace SimpleDemo
{
	partial class GeneralPage
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
			this.label12 = new System.Windows.Forms.Label();
			this.updownRightMargin = new System.Windows.Forms.NumericUpDown();
			this.checkWordWrap = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize) (this.updownRightMargin)).BeginInit();
			this.SuspendLayout();
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 35);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(142, 17);
			this.label12.TabIndex = 5;
			this.label12.Text = "Maximum characters in line";
			this.label12.UseCompatibleTextRendering = true;
			// 
			// updownRightMargin
			// 
			this.updownRightMargin.Location = new System.Drawing.Point(151, 33);
			this.updownRightMargin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.updownRightMargin.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.updownRightMargin.Name = "updownRightMargin";
			this.updownRightMargin.Size = new System.Drawing.Size(45, 20);
			this.updownRightMargin.TabIndex = 4;
			this.updownRightMargin.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// checkWordWrap
			// 
			this.checkWordWrap.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkWordWrap.Location = new System.Drawing.Point(3, 3);
			this.checkWordWrap.Name = "checkWordWrap";
			this.checkWordWrap.Size = new System.Drawing.Size(162, 26);
			this.checkWordWrap.TabIndex = 3;
			this.checkWordWrap.Text = "Enable word wrap";
			this.checkWordWrap.UseCompatibleTextRendering = true;
			this.checkWordWrap.UseVisualStyleBackColor = true;
			// 
			// GeneralPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label12);
			this.Controls.Add(this.updownRightMargin);
			this.Controls.Add(this.checkWordWrap);
			this.Name = "GeneralPage";
			this.Size = new System.Drawing.Size(221, 93);
			((System.ComponentModel.ISupportInitialize) (this.updownRightMargin)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown updownRightMargin;
		private System.Windows.Forms.CheckBox checkWordWrap;
	}
}
