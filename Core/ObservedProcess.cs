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
using ProcessMemoryObserver.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessMemoryObserver.Core
{
	public class ObservedProcess : IDisposable
	{
		public Process Process { get; private set; }
		public IntPtr ProcessHandle { get; private set; }
		public bool IsOpened => Process != null && ProcessHandle != IntPtr.Zero;
		public bool Is64BitProcess { get; private set; }
		public string ProcessInfo
		{
			get
			{
				if(IsOpened)
				{
					return string.Format("{0} : {1}\n{2} : {3}\nPID : {4}\n{5} : {6}\n{7} : {8}",
													Resources.ModuleName,
													Process.ProcessName,
													Resources.StartDate,
													Process.StartTime.ToString(),
													Process.Id.ToString("X8"),
													Resources.BaseAddress,
													Is64BitProcess ? Process.MainModule.BaseAddress.ToString("X16") : Process.MainModule.BaseAddress.ToString("X8"),
													Resources.EntryPointAddress,
													Is64BitProcess ? Process.MainModule.EntryPointAddress.ToString("X16") : Process.MainModule.EntryPointAddress.ToString("X8"));
				}
				else
				{
					return Resources.ProcessNotSelected;
				}
			}
		}
		public event Action<Process,IntPtr> ProcessOpened;
		public event Action ProcessExited;
		private Timer Timer { get; set; }

		public ObservedProcess()
		{
			Timer = new Timer() { Interval=1 };
			Timer.Tick += Timer_Tick;
			Process = null;
			ProcessHandle = IntPtr.Zero;
		}

		public void Dispose()
		{
			Close();
			Timer.Dispose();
		}

		public bool Open(int processId)
		{
			try
			{
				Process = Process.GetProcessById(processId);
				ProcessHandle = OpenProcess(ProcessAccessFlags.PROCESS_VM_READ, false, Process.Id);
				bool isWow64;
				if(ProcessUtils.IsWow64Process(Process.Handle,out isWow64))
				{
					Is64BitProcess = !isWow64;
				}
				else
				{
					throw new InvalidOperationException("Can't get process is 32bit/64bit.");
				}
			}
			catch (Exception e) when (e is ArgumentException || e is InvalidOperationException)
			{
				Console.WriteLine(e);
				return false;
			}
			Timer.Start();
			ProcessOpened?.Invoke(Process,ProcessHandle);
			return true;
		}

		public void Close()
		{
			Timer.Stop();
			if (ProcessHandle != IntPtr.Zero)
			{
				CloseHandle(ProcessHandle);
			}
			Process = null;
			ProcessHandle = IntPtr.Zero;
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			if(Process.HasExited)
			{
				Close();
				ProcessExited?.Invoke();
			}
		}

		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CloseHandle(IntPtr hObject);
		
		public enum ProcessAccessFlags : uint
		{
			All = 0x001F0FFF,
			Terminate = 0x00000001,
			CreateThread = 0x00000002,
			VMOperation = 0x00000008,
			PROCESS_VM_READ = 0x10,
			VMWrite = 0x00000020,
			DupHandle = 0x00000040,
			SetInformation = 0x00000200,
			QueryInformation = 0x00000400,
			Synchronize = 0x00100000
		}
	}
}
