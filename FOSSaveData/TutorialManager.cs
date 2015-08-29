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

namespace FOSSaveData
{
	/// <summary>
	/// Description of TutorialManager.
	/// </summary>
	public class TutorialManager
	{
		public string phase { get; set; }
		public int taskNumber { get; set; }
		public bool objectivesTutorialMessage { get; set; }
		public bool lunchboxTutorialMessage { get; set; }
		public bool showingObjectiveTutorialMessage { get; set; }
		public bool showingLunchboxTutorialMessage { get; set; }
		public double showWastelandMessageTime { get; set; }
		public double showExploreWastelandMessageTime { get; set; }
		public bool exploreWastelandMessageShown { get; set; }
		public List<Object> intialTimerTasks { get; set; }
		public bool ContextualVaultTecObjectives { get; set; }
		public bool ContextualAddFriends { get; set; }
		public bool ContextualWasteland { get; set; }
		public bool ContextualRadioRoom { get; set; }
		public bool ContextualWeaponsAndOutfits { get; set; }
		public bool ContextualTrainDweller { get; set; }
		public bool ContextualBabies { get; set; }
		public bool ContextualDestroyRocks { get; set; }
		public bool ContextualStorage { get; set; }
		public bool ContextualNoRoomForDwellers { get; set; }
		public bool ContextualUnequipedDweller { get; set; }
		public bool ContextualBuildAnElevator { get; set; }
		public bool ContextualDestroyRockToBuild { get; set; }
		public bool ContextualNoBuildZonesAvailableByRock { get; set; }
		public bool ContextualDestroyRockToAccessNextFloor { get; set; }
		public bool ContextualResourcesAlert { get; set; }
		public bool ContextualIncidentOcurs { get; set; }
		public bool ContextualLowPowerAlert { get; set; }
		public bool ContextualStorageFull { get; set; }
		public bool ContextualMergeOrUpgradeRoom { get; set; }
		public bool ContextualWastelandMessage { get; set; }
		public bool ContextualObjectivesCompleted { get; set; }
		public bool ContextualBabiesTutorial { get; set; }
		public bool ContextualStimpackMessage { get; set; }
		public bool ContextualLunchboxTutorial { get; set; }
		public bool ContextualRadwayMessage { get; set; }
		public bool ContextualRoomMerge2 { get; set; }
		public bool ContextualRoomMerge3 { get; set; }
		public bool ContextualStorage2 { get; set; }
		public bool ContextualEquippingItemsWeapon { get; set; }
		public bool ContextualLuck { get; set; }
		public int MaleTasksQuant { get; set; }
		public int FemaleTasksQuant { get; set; }
		
		public TutorialManager()
		{
		}
	}
}
