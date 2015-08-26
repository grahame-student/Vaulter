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
using Newtonsoft.Json;

namespace Valuter
{
	/// <summary>
	/// Description of SaveFile.
	/// </summary>
	public class SaveFile
	{
		public TimeManager timeMgr { get; set; }
		public NotificationManager localNotificationManager { get; set; }
		public TaskManager taskMgr { get; set; }
		public RatingManager ratingMgr { get; set; }
		public Inhabitants dwellers { get; set; }
		public ConstructManager constructMgr { get; set; }
		public Vault vault { get; set; }
		public DwellerSpawner dwellerSpawner { get; set; }
		public string deviceName { get; set; }
		public TutorialManager tutorialManager { get; set; }
		public ObjectiveManager objectiveMgr { get; set; }
		public UnlockableManager unlockableMgr { get; set; }
		public SurvivalGuide survivalW { get; set; }
		public Object happpinessManager { get; set; }
		public RefugeeSpawner refugeeSpawner { get; set; }
		public Object LunchBoxCollectWindow { get; set; }
		public FSODeathclawManager DeathclawManager { get; set; }
		public Object PromoCodesWindow { get; set; }
		public EventsManager swrveEventsManager { get; set; }
		
		public event EventHandler<FileOpenedArgs> FileOpened = delegate {};
		
		public SaveFile()
		{
		}
		
		public void Read(string EncryptedSaveFile)
		{
			var UnencryptedSaveFile = Cypher.Decrypt(EncryptedSaveFile);
			
			if (UnencryptedSaveFile != null)
			{
				var args = new FileOpenedArgs();
				args.saveFile = JsonConvert.DeserializeObject<SaveFile>(UnencryptedSaveFile);
				
				FileOpened(this, args);
			}
		}
	}
}
