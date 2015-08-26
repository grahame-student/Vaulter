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

namespace Valuter
{
	/// <summary>
	/// Description of EventsManager.
	/// </summary>
	public class EventsManager
	{
		public int currentIncidentTypeInt { get; set; }
		public int currentIncidentModeInt { get; set; }
		public int initialDwellerCount { get; set; }
		public int initialFoodAmount { get; set; }
		public int initialPowerAmount { get; set; }
		public int initialWaterAmount { get; set; }
		public int vaultLastSentMsgHour { get; set; }
		public List<string> alreadyBoughtRooms { get; set; }
		public List<string> alreadyUpgradedRoomsLvl2 { get; set; }
		public List<string> alreadyUpgradedRoomsLvl3 { get; set; }
		public int hasSentFTBuyAnyRoom { get; set; }
		public int hasSentFTUpgradeLvl2AnyRoom { get; set; }
		public int hasSentFTUpgradeLvl3AnyRoom { get; set; }
		public int hasSentFTMerge2AnyRoom { get; set; }
		public int hasSentFTMerge3AnyRoom { get; set; }
		public int hasSentFTBabyFlirt { get; set; }
		public int hasSentFTBabyMakeBaby { get; set; }
		public int hasSentFTBabyBorn { get; set; }
		public int hasSentWastelandFTStartExplore { get; set; }
		public int hasSentWastelandFTDeadDweller { get; set; }
		public int hasSentWastelandFTReviveDweller { get; set; }
		public int hasSentWastelandFTRecall { get; set; }
		public int hasSentDwellerCount50 { get; set; }
		public int hasSentDwellerCount100 { get; set; }
		public int hasSentDwellerCount150 { get; set; }
		public int hasSentDwellerCount200 { get; set; }
		public List<string> m_alreadyMergedRoomsLvl2 { get; set; }
		public List<string> m_alreadyMergedRoomsLvl3 { get; set; }
		
		public EventsManager()
		{
		}
	}
}
