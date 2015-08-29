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
using System.ComponentModel;
using System.Windows.Forms;

namespace VaultBasics
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class VaultBasics : UserControl
	{
		public delegate void PropertyChangedHandler();
		
		[Category("Action")]
        [Description("Fires when any text field changes.")]
		public event PropertyChangedHandler PropertyChanged;
		
		public VaultBasics()
		{
			InitializeComponent();
		}
		
		public void Bind()
		{
			// TODO: Asssumes too much about the savefile format, need to abstract the assumption away
			//       Binding does make updating values much simpler so try not to lose that benefit
			Bind(txtCaps, ".vault.storage.resources.Nuka");
			Bind(txtEnergy, ".vault.storage.resources.Energy");
			Bind(txtFood, ".vault.storage.resources.Food");
			Bind(txtWater, ".vault.storage.resources.Water");
			Bind(txtStimPack, ".vault.storage.resources.StimPack");
			Bind(txtRadAway, ".vault.storage.resources.RadAway");
		}
		
        private void OnPropertyChanged(object sender, EventArgs e)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged();
			}
		}
	}
}