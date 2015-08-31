/* 
 * Vaulter - Save Editor for the unpacked Fallout Shelter save files
 *
 * Copyright (C) 2015 Grahame White
 *
* This program is free software; you can redistribute it and/or
* modify it under the terms of the GNU General Public License
* as published by the Free Software Foundation; either version 2
* of the License, or (at your option) any later version.
*
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU General Public License for more details.
*
* You should have received a copy of the GNU General Public License
* along with this program; if not, write to the Free Software
* Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
*
* The full text of the license can be viewed at:
* http://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html
*
* Or in the LICENSE file
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using FOSSaveData;

namespace Vaulter.Dashboard
{
	/// <summary>
	/// Description of DwellerList.
	/// </summary>
	public partial class DwellerList : UserControl
	{
		private BindingSource dwellers = new BindingSource();
//		private BindingList<Dweller> dwellers;
		
		public delegate void PropertyChangedHandler();
		
		[Category("Action")]
        [Description("Fires when text field changes.")]
		public event PropertyChangedHandler PropertyChanged;
		
		public DwellerList()
		{
			InitializeComponent();
		}
		
		// TODO: Plan is to allow basic editing in the gridview
		//       And more detailed editing using a different dashboard control
		
		public void BindProperties(Inhabitants inhabitants)
		{
			dwellers.DataSource = inhabitants.dwellers;
			gridDwellers.AutoGenerateColumns = false;
			gridDwellers.DataSource = dwellers;
			
			FirstName.DataPropertyName = "name";
			LastName.DataPropertyName = "lastName";
			Gender.DataPropertyName = "gender";
			Level.DataPropertyName = "experience.currentLevel";
			Strength.DataPropertyName = "stats.stats[1].value";
			
			vscrRow.Maximum = gridDwellers.RowCount - gridDwellers.Rows.GetRowCount(DataGridViewElementStates.Displayed);
		}
		
        private void OnPropertyChanged(object sender, EventArgs e)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged();
			}
		}
        
		void GridDwellersColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			// TODO: Sort the data based on the column clicked.
		}
		
		void VscrRowScroll(object sender, ScrollEventArgs e)
		{
			gridDwellers.FirstDisplayedScrollingRowIndex = vscrRow.Value;
		}
	}
}
