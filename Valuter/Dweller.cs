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

namespace Valuter
{
	/// <summary>
	/// Description of Dweller.
	/// </summary>
	public class Dweller
	{
		public UInt64 serializeId { get; set; }
		public string name { get; set; }
		public string lastName { get; set; }
		public Happiness happiness { get; set; }
		public Health health { get; set; }
		public Experience experience { get; set; }
		public Relations relations { get; set; }
		public Equipment equipment { get; set; }
		public int gender { get; set; }
		public Statistics stats { get; set; }
		public bool pregnant { get; set; }
		public bool babyReady { get; set; }
		public bool assigned { get; set; }
		public bool sawIncident { get; set; }
		public bool WillGoToWasteland { get; set; }
		public UInt64 skinColor { get; set; }
		public UInt64 hairColor { get; set; }
		public UInt64 outfitColor { get; set; }
		public int pendingExperienceReward { get; set; }
		public string hair { get; set; }
		public FOSItem equipedOutfit { get; set; }
		public FOSItem equipedWeapon { get; set; }
		public int savedRoom { get; set; }
		public int lastChildBorn { get; set; }
		public string rarity { get; set; }
		public int deathTime { get; set; }
		
		public Dweller()
		{
		}
	}
}
