namespace ProcessMemoryObserver.GUI.UserControls
{
	partial class ObserverView
	{
		/// <summary> 
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region コンポーネント デザイナーで生成されたコード

		/// <summary> 
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObserverView));
			this.NotifyCheckBox = new System.Windows.Forms.CheckBox();
			this.StopButton = new System.Windows.Forms.Button();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.StartButton = new System.Windows.Forms.Button();
			this.TitleTextBox = new System.Windows.Forms.TextBox();
			this.LogGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.LogTextBox = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.WordWrapCheckBox = new System.Windows.Forms.CheckBox();
			this.ClearLogButton = new System.Windows.Forms.Button();
			this.SaveLogButton = new System.Windows.Forms.Button();
			this.AddressLabel = new System.Windows.Forms.Label();
			this.UpdateIntervalLabel = new System.Windows.Forms.Label();
			this.UpdateIntervalUpDown = new System.Windows.Forms.NumericUpDown();
			this.ReadValueTypeLabel = new System.Windows.Forms.Label();
			this.ReadValueTypeComboBox = new System.Windows.Forms.ComboBox();
			this.ObsrverGroupBox = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.ReadSizeUpDown = new System.Windows.Forms.NumericUpDown();
			this.AddressTextBox = new ProcessMemoryObserver.GUI.CustomControls.HexTextBox();
			this.ReadSizeLabel = new System.Windows.Forms.Label();
			this.LogGroupBox.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UpdateIntervalUpDown)).BeginInit();
			this.ObsrverGroupBox.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ReadSizeUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// NotifyCheckBox
			// 
			resources.ApplyResources(this.NotifyCheckBox, "NotifyCheckBox");
			this.NotifyCheckBox.Name = "NotifyCheckBox";
			this.NotifyCheckBox.UseVisualStyleBackColor = true;
			this.NotifyCheckBox.CheckedChanged += new System.EventHandler(this.NotifyCheckBox_CheckedChanged);
			// 
			// StopButton
			// 
			resources.ApplyResources(this.StopButton, "StopButton");
			this.StopButton.Name = "StopButton";
			this.StopButton.UseVisualStyleBackColor = true;
			this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
			// 
			// TitleLabel
			// 
			resources.ApplyResources(this.TitleLabel, "TitleLabel");
			this.TitleLabel.Name = "TitleLabel";
			// 
			// StartButton
			// 
			resources.ApplyResources(this.StartButton, "StartButton");
			this.StartButton.Name = "StartButton";
			this.StartButton.UseVisualStyleBackColor = true;
			this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
			// 
			// TitleTextBox
			// 
			resources.ApplyResources(this.TitleTextBox, "TitleTextBox");
			this.TitleTextBox.Name = "TitleTextBox";
			this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
			// 
			// LogGroupBox
			// 
			resources.ApplyResources(this.LogGroupBox, "LogGroupBox");
			this.LogGroupBox.Controls.Add(this.tableLayoutPanel3);
			this.LogGroupBox.Name = "LogGroupBox";
			this.LogGroupBox.TabStop = false;
			// 
			// tableLayoutPanel3
			// 
			resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
			this.tableLayoutPanel3.Controls.Add(this.LogTextBox, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			// 
			// LogTextBox
			// 
			resources.ApplyResources(this.LogTextBox, "LogTextBox");
			this.LogTextBox.Name = "LogTextBox";
			// 
			// tableLayoutPanel2
			// 
			resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
			this.tableLayoutPanel2.Controls.Add(this.WordWrapCheckBox, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.ClearLogButton, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.SaveLogButton, 1, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			// 
			// WordWrapCheckBox
			// 
			resources.ApplyResources(this.WordWrapCheckBox, "WordWrapCheckBox");
			this.WordWrapCheckBox.Name = "WordWrapCheckBox";
			this.WordWrapCheckBox.UseVisualStyleBackColor = true;
			this.WordWrapCheckBox.CheckedChanged += new System.EventHandler(this.WordWrapCheckBox_CheckedChanged);
			// 
			// ClearLogButton
			// 
			resources.ApplyResources(this.ClearLogButton, "ClearLogButton");
			this.ClearLogButton.Name = "ClearLogButton";
			this.ClearLogButton.UseVisualStyleBackColor = true;
			this.ClearLogButton.Click += new System.EventHandler(this.ClearLogButton_Click);
			// 
			// SaveLogButton
			// 
			resources.ApplyResources(this.SaveLogButton, "SaveLogButton");
			this.SaveLogButton.Name = "SaveLogButton";
			this.SaveLogButton.UseVisualStyleBackColor = true;
			this.SaveLogButton.Click += new System.EventHandler(this.SaveLogButton_Click);
			// 
			// AddressLabel
			// 
			resources.ApplyResources(this.AddressLabel, "AddressLabel");
			this.AddressLabel.Name = "AddressLabel";
			// 
			// UpdateIntervalLabel
			// 
			resources.ApplyResources(this.UpdateIntervalLabel, "UpdateIntervalLabel");
			this.UpdateIntervalLabel.Name = "UpdateIntervalLabel";
			// 
			// UpdateIntervalUpDown
			// 
			resources.ApplyResources(this.UpdateIntervalUpDown, "UpdateIntervalUpDown");
			this.UpdateIntervalUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.UpdateIntervalUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.UpdateIntervalUpDown.Name = "UpdateIntervalUpDown";
			this.UpdateIntervalUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.UpdateIntervalUpDown.ValueChanged += new System.EventHandler(this.UpdateIntervalUpDown_ValueChanged);
			// 
			// ReadValueTypeLabel
			// 
			resources.ApplyResources(this.ReadValueTypeLabel, "ReadValueTypeLabel");
			this.ReadValueTypeLabel.Name = "ReadValueTypeLabel";
			// 
			// ReadValueTypeComboBox
			// 
			resources.ApplyResources(this.ReadValueTypeComboBox, "ReadValueTypeComboBox");
			this.ReadValueTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ReadValueTypeComboBox.FormattingEnabled = true;
			this.ReadValueTypeComboBox.Name = "ReadValueTypeComboBox";
			this.ReadValueTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ReadTypeComboBox_SelectedIndexChanged);
			// 
			// ObsrverGroupBox
			// 
			resources.ApplyResources(this.ObsrverGroupBox, "ObsrverGroupBox");
			this.ObsrverGroupBox.Controls.Add(this.tableLayoutPanel4);
			this.ObsrverGroupBox.Name = "ObsrverGroupBox";
			this.ObsrverGroupBox.TabStop = false;
			// 
			// tableLayoutPanel4
			// 
			resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
			this.tableLayoutPanel4.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.LogGroupBox, 1, 0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			// 
			// panel1
			// 
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Controls.Add(this.StartButton);
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Controls.Add(this.NotifyCheckBox);
			this.panel1.Controls.Add(this.StopButton);
			this.panel1.Name = "panel1";
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.TitleLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.TitleTextBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.ReadSizeUpDown, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.AddressTextBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.UpdateIntervalLabel, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.UpdateIntervalUpDown, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.ReadSizeLabel, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.AddressLabel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.ReadValueTypeLabel, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.ReadValueTypeComboBox, 1, 2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// ReadSizeUpDown
			// 
			resources.ApplyResources(this.ReadSizeUpDown, "ReadSizeUpDown");
			this.ReadSizeUpDown.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
			this.ReadSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.ReadSizeUpDown.Name = "ReadSizeUpDown";
			this.ReadSizeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.ReadSizeUpDown.ValueChanged += new System.EventHandler(this.ReadSizeUpDown_ValueChanged);
			// 
			// AddressTextBox
			// 
			resources.ApplyResources(this.AddressTextBox, "AddressTextBox");
			this.AddressTextBox.Name = "AddressTextBox";
			this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
			// 
			// ReadSizeLabel
			// 
			resources.ApplyResources(this.ReadSizeLabel, "ReadSizeLabel");
			this.ReadSizeLabel.Name = "ReadSizeLabel";
			// 
			// ObserverView
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ObsrverGroupBox);
			this.Name = "ObserverView";
			this.LogGroupBox.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.UpdateIntervalUpDown)).EndInit();
			this.ObsrverGroupBox.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ReadSizeUpDown)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckBox NotifyCheckBox;
		private System.Windows.Forms.Button StopButton;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.TextBox TitleTextBox;
		private System.Windows.Forms.GroupBox LogGroupBox;
		private System.Windows.Forms.TextBox LogTextBox;
		
		private System.Windows.Forms.Label AddressLabel;
		private System.Windows.Forms.Label UpdateIntervalLabel;
		private System.Windows.Forms.NumericUpDown UpdateIntervalUpDown;
		private System.Windows.Forms.Label ReadValueTypeLabel;
		private System.Windows.Forms.ComboBox ReadValueTypeComboBox;
		private CustomControls.HexTextBox AddressTextBox;
		private System.Windows.Forms.Button ClearLogButton;
		private System.Windows.Forms.GroupBox ObsrverGroupBox;
		private System.Windows.Forms.Button SaveLogButton;
		private System.Windows.Forms.NumericUpDown ReadSizeUpDown;
		private System.Windows.Forms.Label ReadSizeLabel;
		private System.Windows.Forms.CheckBox WordWrapCheckBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Panel panel1;
	}
}
