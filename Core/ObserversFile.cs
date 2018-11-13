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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMemoryObserver.Core
{
	public static class ObserversFile
	{
		public static List<ObserverSettings> Load(string path)
		{
			try
			{
				string json = File.ReadAllText(path);
				var observerSettings = JsonConvert.DeserializeObject<List<ObserverSettings>>(json);
				return observerSettings;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return new List<ObserverSettings>();
			}
		}

		public static bool Save(List<Observer> observers, string path)
		{
			try
			{
				var observerSettingsList = observers.Select(observer =>
					new ObserverSettings()
					{
						Title=observer.Title,
						TargetAddress=observer.TargetAddress,
						ValueType=observer.ValueType,
						CustomReadSize=observer.CustomReadSize,
						UpdateInterval=observer.UpdateInterval,
					}
				)
				.ToList();
				string json = JsonConvert.SerializeObject(observerSettingsList);
				File.WriteAllText(path, json);
				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return false;
			}
		}

	}
}
