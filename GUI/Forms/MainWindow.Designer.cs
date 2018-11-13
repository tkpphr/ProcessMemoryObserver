namespace ProcessMemoryObserver.GUI.Forms
{
	partial class MainWindow
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

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AddObserversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveObserversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.RecentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.EmptyMessageLabel = new System.Windows.Forms.Label();
			this.ObserverTabControl = new System.Windows.Forms.TabControl();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.AddButton = new System.Windows.Forms.Button();
			this.RemoveButton = new System.Windows.Forms.Button();
			this.StartAllButton = new System.Windows.Forms.Button();
			this.StopAllButton = new System.Windows.Forms.Button();
			this.StopSpeechButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.ProcessLabel = new System.Windows.Forms.Label();
			this.SelectProcessButton = new System.Windows.Forms.Button();
			this.WrapperPanel = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.WrapperPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.toolTToolStripMenuItem,
            this.helpHToolStripMenuItem});
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.Name = "menuStrip1";
			// 
			// FileToolStripMenuItem
			// 
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddObserversToolStripMenuItem,
            this.SaveObserversToolStripMenuItem,
            this.toolStripMenuItem1,
            this.RecentFilesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.ExitToolStripMenuItem});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			resources.ApplyResources(this.FileToolStripMenuItem, "FileToolStripMenuItem");
			// 
			// AddObserversToolStripMenuItem
			// 
			this.AddObserversToolStripMenuItem.Name = "AddObserversToolStripMenuItem";
			resources.ApplyResources(this.AddObserversToolStripMenuItem, "AddObserversToolStripMenuItem");
			this.AddObserversToolStripMenuItem.Click += new System.EventHandler(this.AddObserversToolStripMenuItem_Click);
			// 
			// SaveObserversToolStripMenuItem
			// 
			resources.ApplyResources(this.SaveObserversToolStripMenuItem, "SaveObserversToolStripMenuItem");
			this.SaveObserversToolStripMenuItem.Name = "SaveObserversToolStripMenuItem";
			this.SaveObserversToolStripMenuItem.Click += new System.EventHandler(this.SaveObserversToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
			// 
			// RecentFilesToolStripMenuItem
			// 
			this.RecentFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem});
			this.RecentFilesToolStripMenuItem.Name = "RecentFilesToolStripMenuItem";
			resources.ApplyResources(this.RecentFilesToolStripMenuItem, "RecentFilesToolStripMenuItem");
			this.RecentFilesToolStripMenuItem.DropDownOpening += new System.EventHandler(this.RecentFilesToolStripMenuItem_DropDownOpening);
			// 
			// noneToolStripMenuItem
			// 
			resources.ApplyResources(this.noneToolStripMenuItem, "noneToolStripMenuItem");
			this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
			// 
			// ExitToolStripMenuItem
			// 
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			resources.ApplyResources(this.ExitToolStripMenuItem, "ExitToolStripMenuItem");
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// toolTToolStripMenuItem
			// 
			this.toolTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionToolStripMenuItem});
			this.toolTToolStripMenuItem.Name = "toolTToolStripMenuItem";
			resources.ApplyResources(this.toolTToolStripMenuItem, "toolTToolStripMenuItem");
			// 
			// OptionToolStripMenuItem
			// 
			this.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem";
			resources.ApplyResources(this.OptionToolStripMenuItem, "OptionToolStripMenuItem");
			this.OptionToolStripMenuItem.Click += new System.EventHandler(this.OptionToolStripMenuItem_Click);
			// 
			// helpHToolStripMenuItem
			// 
			this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManualToolStripMenuItem,
            this.toolStripMenuItem3,
            this.AboutToolStripMenuItem});
			this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
			resources.ApplyResources(this.helpHToolStripMenuItem, "helpHToolStripMenuItem");
			// 
			// ManualToolStripMenuItem
			// 
			this.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem";
			resources.ApplyResources(this.ManualToolStripMenuItem, "ManualToolStripMenuItem");
			this.ManualToolStripMenuItem.Click += new System.EventHandler(this.ManualToolStripMenuItem_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
			// 
			// AboutToolStripMenuItem
			// 
			this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
			resources.ApplyResources(this.AboutToolStripMenuItem, "AboutToolStripMenuItem");
			this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.EmptyMessageLabel);
			this.panel1.Controls.Add(this.ObserverTabControl);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// EmptyMessageLabel
			// 
			resources.ApplyResources(this.EmptyMessageLabel, "EmptyMessageLabel");
			this.EmptyMessageLabel.Name = "EmptyMessageLabel";
			// 
			// ObserverTabControl
			// 
			resources.ApplyResources(this.ObserverTabControl, "ObserverTabControl");
			this.ObserverTabControl.Name = "ObserverTabControl";
			this.ObserverTabControl.SelectedIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
			this.tableLayoutPanel2.Controls.Add(this.AddButton, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.RemoveButton, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.StartAllButton, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.StopAllButton, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.StopSpeechButton, 4, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			// 
			// AddButton
			// 
			resources.ApplyResources(this.AddButton, "AddButton");
			this.AddButton.Name = "AddButton";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// RemoveButton
			// 
			resources.ApplyResources(this.RemoveButton, "RemoveButton");
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.UseVisualStyleBackColor = true;
			this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
			// 
			// StartAllButton
			// 
			resources.ApplyResources(this.StartAllButton, "StartAllButton");
			this.StartAllButton.Name = "StartAllButton";
			this.StartAllButton.UseVisualStyleBackColor = true;
			this.StartAllButton.Click += new System.EventHandler(this.StartAllButton_Click);
			// 
			// StopAllButton
			// 
			resources.ApplyResources(this.StopAllButton, "StopAllButton");
			this.StopAllButton.Name = "StopAllButton";
			this.StopAllButton.UseVisualStyleBackColor = true;
			this.StopAllButton.Click += new System.EventHandler(this.StopAllButton_Click);
			// 
			// StopSpeechButton
			// 
			resources.ApplyResources(this.StopSpeechButton, "StopSpeechButton");
			this.StopSpeechButton.Name = "StopSpeechButton";
			this.StopSpeechButton.UseVisualStyleBackColor = true;
			this.StopSpeechButton.Click += new System.EventHandler(this.StopSpeechButton_Click);
			// 
			// tableLayoutPanel3
			// 
			resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
			this.tableLayoutPanel3.Controls.Add(this.ProcessLabel, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.SelectProcessButton, 1, 0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			// 
			// ProcessLabel
			// 
			resources.ApplyResources(this.ProcessLabel, "ProcessLabel");
			this.ProcessLabel.Name = "ProcessLabel";
			// 
			// SelectProcessButton
			// 
			resources.ApplyResources(this.SelectProcessButton, "SelectProcessButton");
			this.SelectProcessButton.Name = "SelectProcessButton";
			this.SelectProcessButton.UseVisualStyleBackColor = true;
			this.SelectProcessButton.Click += new System.EventHandler(this.SelectProcessButton_Click);
			// 
			// WrapperPanel
			// 
			resources.ApplyResources(this.WrapperPanel, "WrapperPanel");
			this.WrapperPanel.Controls.Add(this.tableLayoutPanel1);
			this.WrapperPanel.Name = "WrapperPanel";
			this.WrapperPanel.SizeChanged += new System.EventHandler(this.WrapperPanel_SizeChanged);
			// 
			// MainWindow
			// 
			this.AllowDrop = true;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.WrapperPanel);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainWindow";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.WrapperPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AddObserversToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem SaveObserversToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolTToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OptionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TabControl ObserverTabControl;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button RemoveButton;
		private System.Windows.Forms.Button StartAllButton;
		private System.Windows.Forms.Button StopAllButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label ProcessLabel;
		private System.Windows.Forms.Button SelectProcessButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label EmptyMessageLabel;
		private System.Windows.Forms.Button StopSpeechButton;
		private System.Windows.Forms.ToolStripMenuItem RecentFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem ManualToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.Panel WrapperPanel;
	}
}

