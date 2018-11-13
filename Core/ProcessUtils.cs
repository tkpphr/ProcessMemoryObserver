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
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessMemoryObserver.Core
{
	public static class ProcessUtils
	{
		public static Dictionary<string, string> GetProcesses()
		{
			var processes = new Dictionary<string, string>();

			using (var managementClass = new ManagementClass("Win32_Process"))
			{
				using (var managementObjectCollection = managementClass.GetInstances())
				{
					foreach (var managementObject in managementObjectCollection)
					{
						if (managementObject["ProcessId"] != null &&
							managementObject["ExecutablePath"] != null)
						{
							string processId = managementObject["ProcessId"].ToString();
							string path = managementObject["ExecutablePath"].ToString();
							if (!processes.ContainsKey(processId) && path != Application.ExecutablePath)
							{
								processes.Add(processId, path);
							}
						}
						managementObject.Dispose();
					}
				}
			}
			
			if (!Environment.Is64BitProcess)
			{
				Process.GetProcesses()
				.Where(process => processes.ContainsKey(process.Id.ToString()))
				.Where(process =>
				{
					/*
					if(process.MainWindowHandle == IntPtr.Zero)
					{
						return true;
					}
					*/
					bool isWow64;
					if(IsWow64Process(process.Handle,out isWow64))
					{
						return !isWow64;
					}
					else
					{
						return true;
					}
				})
				.ToList()
				.ForEach(process => processes.Remove(process.Id.ToString()));
			}
			return processes;
		}


		[DllImport("kernel32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsWow64Process([In] IntPtr hProcess, [Out] out bool lpSystemInfo);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true)]
		private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

	}
}
