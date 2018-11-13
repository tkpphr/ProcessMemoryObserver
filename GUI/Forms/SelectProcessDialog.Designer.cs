namespace ProcessMemoryObserver.GUI.Forms
{
	partial class SelectProcessDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectProcessDialog));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ReloadButton = new System.Windows.Forms.Button();
			this.ProcessListLabel = new System.Windows.Forms.Label();
			this.ProcessListView = new ProcessMemoryObserver.GUI.CustomControls.SingleSelectListView();
			this.NameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PIDColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PathColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// columnHeader1
			// 
			resources.ApplyResources(this.columnHeader1, "columnHeader1");
			// 
			// columnHeader2
			// 
			resources.ApplyResources(this.columnHeader2, "columnHeader2");
			// 
			// columnHeader3
			// 
			resources.ApplyResources(this.columnHeader3, "columnHeader3");
			// 
			// ReloadButton
			// 
			resources.ApplyResources(this.ReloadButton, "ReloadButton");
			this.ReloadButton.Name = "ReloadButton";
			this.ReloadButton.UseVisualStyleBackColor = true;
			this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
			// 
			// ProcessListLabel
			// 
			resources.ApplyResources(this.ProcessListLabel, "ProcessListLabel");
			this.ProcessListLabel.Name = "ProcessListLabel";
			// 
			// ProcessListView
			// 
			resources.ApplyResources(this.ProcessListView, "ProcessListView");
			this.ProcessListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumnHeader,
            this.PIDColumnHeader,
            this.PathColumnHeader});
			this.ProcessListView.FullRowSelect = true;
			this.ProcessListView.GridLines = true;
			this.ProcessListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.ProcessListView.MultiSelect = false;
			this.ProcessListView.Name = "ProcessListView";
			this.ProcessListView.UseCompatibleStateImageBehavior = false;
			this.ProcessListView.View = System.Windows.Forms.View.Details;
			this.ProcessListView.DoubleClick += new System.EventHandler(this.ProcessListView_DoubleClick);
			// 
			// NameColumnHeader
			// 
			resources.ApplyResources(this.NameColumnHeader, "NameColumnHeader");
			// 
			// PIDColumnHeader
			// 
			resources.ApplyResources(this.PIDColumnHeader, "PIDColumnHeader");
			// 
			// PathColumnHeader
			// 
			resources.ApplyResources(this.PathColumnHeader, "PathColumnHeader");
			// 
			// SelectProcessDialog
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ProcessListView);
			this.Controls.Add(this.ReloadButton);
			this.Controls.Add(this.ProcessListLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "SelectProcessDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button ReloadButton;
		private System.Windows.Forms.Label ProcessListLabel;
		private ProcessMemoryObserver.GUI.CustomControls.SingleSelectListView ProcessListView;
		private System.Windows.Forms.ColumnHeader NameColumnHeader;
		private System.Windows.Forms.ColumnHeader PIDColumnHeader;
		private System.Windows.Forms.ColumnHeader PathColumnHeader;
	}
}