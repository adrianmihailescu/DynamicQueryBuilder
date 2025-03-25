namespace SimpleDemo
{
	partial class OfflineModePage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfflineModePage));
			this.buttonEditMetadata = new System.Windows.Forms.Button();
			this.buttonSaveToXML = new System.Windows.Forms.Button();
			this.buttonLoadFromXML = new System.Windows.Forms.Button();
			this.labelMetadataObjectCount = new System.Windows.Forms.Label();
			this.buttonLoadMetadata = new System.Windows.Forms.Button();
			this.checkOfflineMode = new System.Windows.Forms.CheckBox();
			this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
			this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
			this.panelFree = new System.Windows.Forms.Panel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label29 = new System.Windows.Forms.Label();
			this.pictureInformation = new System.Windows.Forms.PictureBox();
			this.panelFree.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.pictureInformation)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonEditMetadata
			// 
			this.buttonEditMetadata.Enabled = false;
			this.buttonEditMetadata.Location = new System.Drawing.Point(3, 112);
			this.buttonEditMetadata.Name = "buttonEditMetadata";
			this.buttonEditMetadata.Size = new System.Drawing.Size(240, 23);
			this.buttonEditMetadata.TabIndex = 12;
			this.buttonEditMetadata.Text = "Edit Metadata Container...";
			this.buttonEditMetadata.UseVisualStyleBackColor = true;
			// 
			// buttonSaveToXML
			// 
			this.buttonSaveToXML.Enabled = false;
			this.buttonSaveToXML.Location = new System.Drawing.Point(126, 83);
			this.buttonSaveToXML.Name = "buttonSaveToXML";
			this.buttonSaveToXML.Size = new System.Drawing.Size(117, 23);
			this.buttonSaveToXML.TabIndex = 13;
			this.buttonSaveToXML.Text = "Save to XML...";
			this.buttonSaveToXML.UseVisualStyleBackColor = true;
			// 
			// buttonLoadFromXML
			// 
			this.buttonLoadFromXML.Enabled = false;
			this.buttonLoadFromXML.Location = new System.Drawing.Point(3, 83);
			this.buttonLoadFromXML.Name = "buttonLoadFromXML";
			this.buttonLoadFromXML.Size = new System.Drawing.Size(117, 23);
			this.buttonLoadFromXML.TabIndex = 14;
			this.buttonLoadFromXML.Text = "Load from XML...";
			this.buttonLoadFromXML.UseVisualStyleBackColor = true;
			// 
			// labelMetadataObjectCount
			// 
			this.labelMetadataObjectCount.AutoSize = true;
			this.labelMetadataObjectCount.Enabled = false;
			this.labelMetadataObjectCount.Location = new System.Drawing.Point(3, 56);
			this.labelMetadataObjectCount.Name = "labelMetadataObjectCount";
			this.labelMetadataObjectCount.Size = new System.Drawing.Size(247, 13);
			this.labelMetadataObjectCount.TabIndex = 11;
			this.labelMetadataObjectCount.Text = "Loaded Metadata: 0 tables, 0 views, 0 procedures.";
			// 
			// buttonLoadMetadata
			// 
			this.buttonLoadMetadata.Enabled = false;
			this.buttonLoadMetadata.Location = new System.Drawing.Point(3, 26);
			this.buttonLoadMetadata.Name = "buttonLoadMetadata";
			this.buttonLoadMetadata.Size = new System.Drawing.Size(240, 23);
			this.buttonLoadMetadata.TabIndex = 10;
			this.buttonLoadMetadata.Text = "Load metadata to work in Offline mode...";
			this.buttonLoadMetadata.UseVisualStyleBackColor = true;
			this.buttonLoadMetadata.Click += new System.EventHandler(this.buttonLoadMetadata_Click);
			// 
			// checkOfflineMode
			// 
			this.checkOfflineMode.AutoSize = true;
			this.checkOfflineMode.Enabled = false;
			this.checkOfflineMode.Location = new System.Drawing.Point(3, 3);
			this.checkOfflineMode.Name = "checkOfflineMode";
			this.checkOfflineMode.Size = new System.Drawing.Size(122, 17);
			this.checkOfflineMode.TabIndex = 9;
			this.checkOfflineMode.Text = "Enable Offline Mode";
			this.checkOfflineMode.UseVisualStyleBackColor = true;
			// 
			// OpenDialog
			// 
			this.OpenDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
			// 
			// SaveDialog
			// 
			this.SaveDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
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
			this.panelFree.TabIndex = 20;
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
			// OfflineModePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelFree);
			this.Controls.Add(this.buttonEditMetadata);
			this.Controls.Add(this.buttonSaveToXML);
			this.Controls.Add(this.buttonLoadFromXML);
			this.Controls.Add(this.labelMetadataObjectCount);
			this.Controls.Add(this.buttonLoadMetadata);
			this.Controls.Add(this.checkOfflineMode);
			this.Name = "OfflineModePage";
			this.Size = new System.Drawing.Size(400, 282);
			this.panelFree.ResumeLayout(false);
			this.panelFree.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.pictureInformation)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonEditMetadata;
		private System.Windows.Forms.Button buttonSaveToXML;
		private System.Windows.Forms.Button buttonLoadFromXML;
		private System.Windows.Forms.Label labelMetadataObjectCount;
		private System.Windows.Forms.Button buttonLoadMetadata;
		private System.Windows.Forms.CheckBox checkOfflineMode;
		private System.Windows.Forms.OpenFileDialog OpenDialog;
		private System.Windows.Forms.SaveFileDialog SaveDialog;
		private System.Windows.Forms.Panel panelFree;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.PictureBox pictureInformation;
	}
}
