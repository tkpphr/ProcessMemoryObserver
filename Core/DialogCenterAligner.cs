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
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ProcessMemoryObserver.Core
{
	public class DialogCenterAligner : IDisposable
	{
		private int Tries { get; set; }
		private Form Owner { get; set; }

		public DialogCenterAligner(Form owner)
		{
			Owner = owner;
			if(Owner.WindowState==FormWindowState.Minimized)
			{
				Owner.Show();
			}
			Owner.BeginInvoke(new MethodInvoker(FindDialog));
		}

		public void Dispose()
		{
			Tries = -1;
		}

		private void FindDialog()
		{
			if (Tries < 0)
			{
				return;
			}
			EnumThreadWndProc callback = new EnumThreadWndProc(CheckWindow);
			if (EnumThreadWindows(GetCurrentThreadId(), callback, IntPtr.Zero))
			{
				if (++Tries < 10)
				{
					Owner.BeginInvoke(new MethodInvoker(FindDialog));
				}
			}
		}

		private bool CheckWindow(IntPtr hWnd, IntPtr lp)
		{
			StringBuilder stringBuilder = new StringBuilder(260);
			GetClassName(hWnd, stringBuilder, stringBuilder.Capacity);
			if (stringBuilder.ToString() != "#32770")
			{
				return true;
			}
			
			Rectangle ownerRect = new Rectangle(Owner.Location, Owner.Size);
			RECT dialogRect;
			GetWindowRect(hWnd, out dialogRect);
			MoveWindow(hWnd,
				ownerRect.Left + (ownerRect.Width - dialogRect.Right + dialogRect.Left) / 2,
				ownerRect.Top + (ownerRect.Height - dialogRect.Bottom + dialogRect.Top) / 2,
				dialogRect.Right - dialogRect.Left,
				dialogRect.Bottom - dialogRect.Top, true);
			return false;
		}

		private delegate bool EnumThreadWndProc(IntPtr hWnd, IntPtr lp);
		[DllImport("user32.dll")]
		private static extern bool EnumThreadWindows(int tid, EnumThreadWndProc callback, IntPtr lp);
		[DllImport("kernel32.dll")]
		private static extern int GetCurrentThreadId();
		[DllImport("user32.dll")]
		private static extern int GetClassName(IntPtr hWnd, StringBuilder buffer, int buflen);
		[DllImport("user32.dll")]
		private static extern bool GetWindowRect(IntPtr hWnd, out RECT rc);
		[DllImport("user32.dll")]
		private static extern bool MoveWindow(IntPtr hWnd, int x, int y, int w, int h, bool repaint);
		private struct RECT { public int Left; public int Top; public int Right; public int Bottom; }
	}
}
