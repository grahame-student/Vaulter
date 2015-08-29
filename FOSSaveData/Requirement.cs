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

namespace FOSSaveData
{
	/// <summary>
	/// Description of Requirement.
	/// </summary>
	public class Requirement
	{
		public string requirementID { get; set; }
		public bool satisfied { get; set; }
		public bool isAchievement { get; set; }
		
		// only one of these used at a time, depends on requirement ID
		public int rushCount { get; set; }
		public int higherMergeLevelFound { get; set; }
		public int currentBabies { get; set; }
		public int acceptedRoom { get; set; }
		public int dweller { get; set; }
		public int currentInvasions { get; set; }
		public int numberOfObjectivesCompleted { get; set; }
		public int currentLegendaryDwellers { get; set; }
		public int currentLegendaryOutfits { get; set; }
		public int currentLegendaryWeapons { get; set; }
		public double nukaCount { get; set; }
		public Resources gainedRes { get; set; }
		
		
		public Requirement()
		{
		}
	}
}
