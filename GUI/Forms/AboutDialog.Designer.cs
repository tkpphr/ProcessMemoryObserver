namespace ProcessMemoryObserver.GUI.Forms
{
	partial class AboutDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
			this.CloseButton = new System.Windows.Forms.Button();
			this.ThirdPartyGroupBox = new System.Windows.Forms.GroupBox();
			this.OpenNoticesButton = new System.Windows.Forms.Button();
			this.ThirdPartyDescLabel = new System.Windows.Forms.Label();
			this.CopyRightLabel = new System.Windows.Forms.Label();
			this.VersionLabel = new System.Windows.Forms.Label();
			this.IconPictureBox = new System.Windows.Forms.PictureBox();
			this.ThirdPartyGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// CloseButton
			// 
			resources.ApplyResources(this.CloseButton, "CloseButton");
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// ThirdPartyGroupBox
			// 
			resources.ApplyResources(this.ThirdPartyGroupBox, "ThirdPartyGroupBox");
			this.ThirdPartyGroupBox.Controls.Add(this.OpenNoticesButton);
			this.ThirdPartyGroupBox.Controls.Add(this.ThirdPartyDescLabel);
			this.ThirdPartyGroupBox.Name = "ThirdPartyGroupBox";
			this.ThirdPartyGroupBox.TabStop = false;
			// 
			// OpenNoticesButton
			// 
			resources.ApplyResources(this.OpenNoticesButton, "OpenNoticesButton");
			this.OpenNoticesButton.Name = "OpenNoticesButton";
			this.OpenNoticesButton.UseVisualStyleBackColor = true;
			this.OpenNoticesButton.Click += new System.EventHandler(this.OpenNoticesButton_Click);
			// 
			// ThirdPartyDescLabel
			// 
			resources.ApplyResources(this.ThirdPartyDescLabel, "ThirdPartyDescLabel");
			this.ThirdPartyDescLabel.Name = "ThirdPartyDescLabel";
			// 
			// CopyRightLabel
			// 
			resources.ApplyResources(this.CopyRightLabel, "CopyRightLabel");
			this.CopyRightLabel.Name = "CopyRightLabel";
			// 
			// VersionLabel
			// 
			resources.ApplyResources(this.VersionLabel, "VersionLabel");
			this.VersionLabel.Name = "VersionLabel";
			// 
			// IconPictureBox
			// 
			resources.ApplyResources(this.IconPictureBox, "IconPictureBox");
			this.IconPictureBox.Name = "IconPictureBox";
			this.IconPictureBox.TabStop = false;
			// 
			// AboutDialog
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ControlBox = false;
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.ThirdPartyGroupBox);
			this.Controls.Add(this.CopyRightLabel);
			this.Controls.Add(this.VersionLabel);
			this.Controls.Add(this.IconPictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AboutDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.ThirdPartyGroupBox.ResumeLayout(false);
			this.ThirdPartyGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.GroupBox ThirdPartyGroupBox;
		private System.Windows.Forms.Button OpenNoticesButton;
		private System.Windows.Forms.Label ThirdPartyDescLabel;
		private System.Windows.Forms.Label CopyRightLabel;
		private System.Windows.Forms.Label VersionLabel;
		private System.Windows.Forms.PictureBox IconPictureBox;
	}
}