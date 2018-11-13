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
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProcessMemoryObserver.GUI.CustomControls
{
    public class SingleSelectListView : ListView
    {
        public SingleSelectListView():base()
        {
            MultiSelect = false;
        }

        public bool IsSelected
        {
            get
            {
                if (SelectedItems.Count > 0 && SelectedIndices.Count > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public ListViewItem SelectedItem
        {
            get
            {
                return SelectedItems[0];
            }
        }

        public int SelectedIndex
        {
            get
            {
                return SelectedIndices[0];
            }
        }

		public void SelectItem(int index)
		{
			Items[index].Selected = true;
			Select();
			FocusedItem = Items[index];
			EnsureVisible(index);
		}
    }
}
