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
using ProcessMemoryObserver.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessMemoryObserver.GUI.Forms
{
	public partial class AboutDialog : Form
	{
		public AboutDialog()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			IconPictureBox.Image = Resources.Icon.ToBitmap();
			VersionLabel.Text = string.Format("{0} {1}", Application.ProductName, Application.ProductVersion);
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			base.OnFormClosed(e);
			IconPictureBox.Image?.Dispose();
		}

		private void OpenNoticesButton_Click(object sender, EventArgs e)
		{
			string path = Environment.CurrentDirectory + "/Docs/notices.html";
			if (File.Exists(path))
			{
				Process.Start(path);
			}
			else
			{
				using (var centerAligner = new DialogCenterAligner(this))
				{
					MessageBox.Show(this, Resources.FailedOpenFile, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
