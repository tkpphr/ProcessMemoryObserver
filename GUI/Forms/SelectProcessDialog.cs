/*
   Copyright 2018 tkpphr

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 */
using ProcessMemoryObserver.Core;
using ProcessMemoryObserver.GUI.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessMemoryObserver.GUI.Forms
{
	public partial class SelectProcessDialog : Form
	{
		public int ProcessId { get; private set; }
		private Icon DefaultIcon { get; set; }

		public SelectProcessDialog()
		{
			InitializeComponent();
			ProcessId = -1;
			DialogResult = DialogResult.Cancel;
			DefaultIcon = SystemIcons.Application.Clone() as Icon;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			ProcessListView.SmallImageList = new ImageList();
			ReloadButton.PerformClick();
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			foreach (Image image in ProcessListView.SmallImageList.Images)
			{
				image.Dispose();
			}
		}

		private void ReloadButton_Click(object sender, EventArgs e)
		{
			ProcessListView.Items.Clear();
			foreach (Image image in ProcessListView.SmallImageList.Images)
			{
				image.Dispose();
			}
			ProcessListView.SmallImageList.Images.Clear();

			
			foreach (var value in ProcessUtils.GetProcesses().Select(entry=>new { Id = entry.Key, Path = entry.Value}).OrderBy(a => Path.GetFileName(a.Path)))
			{
				if (File.Exists(value.Path))
				{
					ProcessListView.SmallImageList.Images.Add(Icon.ExtractAssociatedIcon(value.Path));
				}
				else
				{
					ProcessListView.SmallImageList.Images.Add(DefaultIcon);
				}
				var subItems = new string[]
				{
					Path.GetFileNameWithoutExtension(value.Path),
					int.Parse(value.Id).ToString("X8"),
					value.Path,
				};
				var listViewItem = new ListViewItem(subItems, ProcessListView.SmallImageList.Images.Count - 1);
				ProcessListView.Items.Add(listViewItem);
			}
		}

		private void ProcessListView_DoubleClick(object sender, EventArgs e)
		{
			var listView = (SingleSelectListView)sender;
			if (!listView.IsSelected)
			{
				return;
			}
			DialogResult = DialogResult.OK;
			ProcessId = Convert.ToInt32(listView.SelectedItem.SubItems[1].Text, 16);
			Close();
		}
	}
}
