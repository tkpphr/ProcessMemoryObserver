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
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProcessMemoryObserver.GUI.CustomControls
{
	public class HexTextBox : TextBox
	{
		private string OldText { get; set; }
		private static readonly string ValidCharacters="0123456789ABCDEFabcdef";

        public HexTextBox():base()
        {
            MaxLength = 16;
			OldText = "";
        }


		protected override void OnTextChanged(EventArgs e)
		{

			long result;
			if (string.IsNullOrEmpty(Text) || long.TryParse(Text, NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, out result))
			{
				base.OnTextChanged(e);
				OldText = Text;
			}
			else
			{
				Text = OldText;
			}
		}

		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			base.OnKeyPress(e);
			if (ValidCharacters.Contains(e.KeyChar) || char.IsControl(e.KeyChar))
			{
				e.Handled = false;
				return;
			}
			e.Handled = true;
		}
    }
}
