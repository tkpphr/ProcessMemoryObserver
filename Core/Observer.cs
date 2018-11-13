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
using System.Speech.Synthesis;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessMemoryObserver.Core
{
	public class Observer : IDisposable
	{
		private Timer UpdateTimer { get; set; }
		private StringBuilder LogBuilder { get; set; }
		private SpeechSynthesizer SpeechSynthesizer { get; set; }
		private ObservedProcess ObservedProcess { get; set; }
		private byte[] ReadBuffer { get; set; }
		private Prompt SpeechMessage { get; set; }
		public string Title { get; set; }
		public string TargetAddress { get; set; }
		public int ValueType { get; set; }
		public int CustomReadSize { get; set; }
		public int UpdateInterval { get; set; }
		public bool NotifyEnabled { get; set; }
		public bool IsObserving { get; private set; }
		public object ReadValue { get; private set; }
		public string Log => LogBuilder.ToString();
		public bool IsObservable => IsValidTargetAddress && ObservedProcess.IsOpened;
		public bool IsValidTargetAddress
		{
			get
			{
				if(!ObservedProcess.IsOpened)
				{
					return false;
				}
				if(Regex.IsMatch(TargetAddress,"[a-fA-F0-9]+"))
				{
					if (ObservedProcess.Is64BitProcess)
					{
						return TargetAddress.Length <= 16;
					}
					else
					{
						return TargetAddress.Length <= 8;
					}
					
				}
				else
				{
					return false;
				}
			}
		}
		public event Action<Observer> Started;
		public event Action<Observer> Stopped;
		public event Action<Observer,object> ReadSucceed;
		public event Action<Observer> ReadFailed;
		public event Action<Observer,Process,IntPtr> ProcessOpened;
		public event Action<Observer> ProcessExited;
		
		public Observer(ObservedProcess observedProcess, SpeechSynthesizer speechSynthesizer)
			: this(observedProcess,speechSynthesizer,new ObserverSettings() { Title = "", TargetAddress = "", ValueType = (int)ReadValueType.Byte,CustomReadSize=1, UpdateInterval = 30000, NotifyEnabled = true })
		{
			
		}

		public Observer(ObservedProcess observedProcess,SpeechSynthesizer speechSynthesizer,ObserverSettings settings)
		{
			ObservedProcess = observedProcess;
			ObservedProcess.ProcessOpened += ObservedProcess_ProcessOpened;
			ObservedProcess.ProcessExited += ObservedProcess_ProcessExited;
			SpeechSynthesizer = speechSynthesizer;
			Title = settings.Title;
			TargetAddress = settings.TargetAddress;
			ValueType = settings.ValueType;
			CustomReadSize = settings.CustomReadSize;
			UpdateInterval = settings.UpdateInterval;
			NotifyEnabled = settings.NotifyEnabled;
			LogBuilder = new StringBuilder();
			UpdateTimer = new Timer();
			UpdateTimer.Tick += Timer_Tick;
		}

		public void Dispose()
		{
			Stop();
			ObservedProcess.ProcessOpened -= ObservedProcess_ProcessOpened;
			ObservedProcess.ProcessExited -= ObservedProcess_ProcessExited;
			UpdateTimer.Dispose();
		}

		public void Start()
		{
			if (IsObserving)
			{
				return;
			}
			ReadBuffer = ((ReadValueType)ValueType).IsVariableSize() ? new byte[CustomReadSize] : new byte[8];
			UpdateTimer.Interval = UpdateInterval;
			UpdateTimer.Start();
			LogBuilder.AppendLine(string.Format("[{0}] : {1}", DateTime.Now.ToString(), Resources.StartObserve));
			IsObserving = true;
			Started?.Invoke(this);
			Update();
		}

		public void Stop()
		{
			if (!IsObserving)
			{
				return;
			}
			UpdateTimer.Stop();
			LogBuilder.AppendLine(string.Format("[{0}] : {1}", DateTime.Now.ToString(), Resources.StopObserve));
			IsObserving = false;
			Stopped?.Invoke(this);
		}

		public void ClearLog()
		{
			LogBuilder.Clear();
		}

		private void ObservedProcess_ProcessOpened(Process process,IntPtr processHandle)
		{
			
			ProcessOpened?.Invoke(this, process, processHandle);
		}

		private void ObservedProcess_ProcessExited()
		{
			ProcessExited?.Invoke(this);
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			if (!ObservedProcess.Process.HasExited)
			{
				Update();
			}
		}

		private void Update()
		{
			byte[] result = TryReadProcessMemory(ObservedProcess.ProcessHandle, ObservedProcess.Process.MainModule.BaseAddress.ToInt64(), Convert.ToInt64(TargetAddress,16));
			if (result == null)
			{
				LogBuilder.AppendLine(string.Format("[{0}] : {1}", DateTime.Now.ToString(), Resources.ReadFailure));
				SpeechMessage = new Prompt(string.Format("{0}\n{1}", Title, Resources.ReadFailure));
				ReadFailed?.Invoke(this);
			}
			else
			{
				ReadValue = ((ReadValueType)ValueType).ToValue(result);
				LogBuilder.AppendLine(string.Format("[{0}] : {1}", DateTime.Now.ToString(), ReadValue));
				SpeechMessage = new Prompt(string.Format("{0}\n{1}", Title, ReadValue));
				ReadSucceed?.Invoke(this, ReadValue);
			}
			if (NotifyEnabled)
			{
				SpeechSynthesizer.SpeakAsync(SpeechMessage);
			}
		}

		private byte[] TryReadProcessMemory(IntPtr processHandle, long baseAddress, long targetAddress)
		{
			int outByteSize;

			if (Environment.Is64BitProcess)
			{
				var offset = baseAddress + (targetAddress - baseAddress);
				if (ReadProcessMemory(processHandle, offset, ReadBuffer, ReadBuffer.Length, out outByteSize))
				{
					return ReadBuffer;
				}
				else
				{
					return null;
				}
			}
			else
			{
				var offset = IntPtr.Add(new IntPtr(targetAddress - baseAddress), (int)baseAddress);
				if (ReadProcessMemory(processHandle, offset, ReadBuffer, ReadBuffer.Length, out outByteSize))
				{
					return ReadBuffer;
				}
				else
				{
					return null;
				}
			}
		}

		[DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

		[DllImport("kernel32.dll", SetLastError = true, PreserveSig = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool ReadProcessMemory(IntPtr hProcess, Int64 lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

	}
}
