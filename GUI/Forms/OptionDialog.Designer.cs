namespace ProcessMemoryObserver.GUI.Forms
{
	partial class OptionDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionDialog));
			this.CloseButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.VolumeValueLabel = new System.Windows.Forms.Label();
			this.RateValueLabel = new System.Windows.Forms.Label();
			this.VolumelLabel = new System.Windows.Forms.Label();
			this.RateLabel = new System.Windows.Forms.Label();
			this.RateTrackBar = new System.Windows.Forms.TrackBar();
			this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
			this.VoiceLabel = new System.Windows.Forms.Label();
			this.VoiceComboBox = new System.Windows.Forms.ComboBox();
			this.LanguageLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RateTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// CloseButton
			// 
			resources.ApplyResources(this.CloseButton, "CloseButton");
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			resources.ApplyResources(this.groupBox1, "groupBox1");
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.VolumeValueLabel, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.RateValueLabel, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.VolumelLabel, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.RateLabel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.RateTrackBar, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.VolumeTrackBar, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.VoiceLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.VoiceComboBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.LanguageLabel, 2, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// VolumeValueLabel
			// 
			resources.ApplyResources(this.VolumeValueLabel, "VolumeValueLabel");
			this.VolumeValueLabel.Name = "VolumeValueLabel";
			// 
			// RateValueLabel
			// 
			resources.ApplyResources(this.RateValueLabel, "RateValueLabel");
			this.RateValueLabel.Name = "RateValueLabel";
			// 
			// VolumelLabel
			// 
			resources.ApplyResources(this.VolumelLabel, "VolumelLabel");
			this.VolumelLabel.Name = "VolumelLabel";
			// 
			// RateLabel
			// 
			resources.ApplyResources(this.RateLabel, "RateLabel");
			this.RateLabel.Name = "RateLabel";
			// 
			// RateTrackBar
			// 
			resources.ApplyResources(this.RateTrackBar, "RateTrackBar");
			this.RateTrackBar.LargeChange = 1;
			this.RateTrackBar.Minimum = -10;
			this.RateTrackBar.Name = "RateTrackBar";
			this.RateTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
			this.RateTrackBar.Scroll += new System.EventHandler(this.RateTrackBar_Scroll);
			// 
			// VolumeTrackBar
			// 
			resources.ApplyResources(this.VolumeTrackBar, "VolumeTrackBar");
			this.VolumeTrackBar.Maximum = 100;
			this.VolumeTrackBar.Name = "VolumeTrackBar";
			this.VolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
			this.VolumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
			// 
			// VoiceLabel
			// 
			resources.ApplyResources(this.VoiceLabel, "VoiceLabel");
			this.VoiceLabel.Name = "VoiceLabel";
			// 
			// VoiceComboBox
			// 
			resources.ApplyResources(this.VoiceComboBox, "VoiceComboBox");
			this.VoiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.VoiceComboBox.FormattingEnabled = true;
			this.VoiceComboBox.Name = "VoiceComboBox";
			this.VoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.VoiceComboBox_SelectedIndexChanged);
			// 
			// LanguageLabel
			// 
			resources.ApplyResources(this.LanguageLabel, "LanguageLabel");
			this.LanguageLabel.Name = "LanguageLabel";
			// 
			// OptionDialog
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ControlBox = false;
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OptionDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RateTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label VolumeValueLabel;
		private System.Windows.Forms.Label RateValueLabel;
		private System.Windows.Forms.Label VolumelLabel;
		private System.Windows.Forms.Label RateLabel;
		private System.Windows.Forms.TrackBar RateTrackBar;
		private System.Windows.Forms.TrackBar VolumeTrackBar;
		private System.Windows.Forms.Label VoiceLabel;
		private System.Windows.Forms.ComboBox VoiceComboBox;
		private System.Windows.Forms.Label LanguageLabel;
	}
}