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
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMemoryObserver.Core
{
	public enum ReadValueType
	{
		Byte,
		Word,
		DWord,
		QWord,
		SignedByte,
		SignedWord,
		SignedDWord,
		SignedQWord,
		Float,
		Double,
		ASCII,
		UnicodeLE,
		UnicodeBE,
		UTF8
	}

	public static class ReadValueTypeUtils
	{
		public static readonly string[] ValueTypeNames = new string[]
		{
			"Byte",
			"Word",
			"DWord",
			"QWord",
			"Byte("+Resources.Signed+")",
			"Word(" +Resources.Signed+")",
			"DWord(" +Resources.Signed+")",
			"QWord(" +Resources.Signed+")",
			"Float",
			"Double",
			Resources.Text+"(ASCII)",
			Resources.Text+"(Unicode LE)",
			Resources.Text+"(Unicode BE)",
			Resources.Text+"(UTF8)"
		};

		public static object ToValue(this ReadValueType valueType,byte[] data)
		{
			switch (valueType)
			{
				case ReadValueType.Word:
					return BitConverter.ToUInt16(data, 0);
				case ReadValueType.DWord:
					return BitConverter.ToUInt32(data, 0);
				case ReadValueType.QWord:
					return BitConverter.ToUInt64(data, 0);
				case ReadValueType.SignedByte:
					return (data[0] & 0x7f) - (data[0] & 0x80);
				case ReadValueType.SignedWord:
					return BitConverter.ToInt16(data, 0);
				case ReadValueType.SignedDWord:
					return BitConverter.ToInt32(data, 0);
				case ReadValueType.SignedQWord:
					return BitConverter.ToInt64(data, 0);
				case ReadValueType.Float:
					return BitConverter.ToSingle(data, 0);
				case ReadValueType.Double:
					return BitConverter.ToDouble(data, 0);
				case ReadValueType.ASCII:
					return Encoding.ASCII.GetString(data).Replace("\0", ".");
				case ReadValueType.UnicodeLE:
					return Encoding.Unicode.GetString(data).Replace("\0", "."); ;
				case ReadValueType.UnicodeBE:
					return Encoding.BigEndianUnicode.GetString(data).Replace("\0",".");
				case ReadValueType.UTF8:
					return Encoding.UTF8.GetString(data).Replace("\0",".");
				default:
					return data[0];
			}
		}

		public static bool IsVariableSize(this ReadValueType valueType)
		{
			return valueType > ReadValueType.Double;
		}

		public static string GetReadValueTypeName(this ReadValueType valueType)
		{
			return ValueTypeNames[(int)valueType];
		}

		public static string[] GetReadValueTypeNames()
		{
			return ValueTypeNames;
		}
	}

}
