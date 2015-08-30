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
using System.IO;

namespace Vaulter
{
	/// <summary>
	/// Description of AppLog.
	/// </summary>
	public static class AppLog
	{
		private const string EVENT_FILE = "Event.log";
		private const string ERROR_FILE = "Error.log";
		
		private static string logEventPath = null;
		private static string logErrorPath = null;
		
		static AppLog()
		{
			string basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			string timeStamp = DateTime.Now.ToString("yyyyMMdd-HHmmss");
			
			logEventPath = Path.Combine(basePath, timeStamp, EVENT_FILE);
			logErrorPath = Path.Combine(basePath, timeStamp, ERROR_FILE);
		}
		
		public static void LogEvent(string logText)
		{
			AppendLog(logEventPath, logText);
		}
		
		public static void LogError(string logText)
		{
			AppendLog(logErrorPath, logText);
		}
		
		private static void AppendLog(string logFile, string logEntry)
		{
			using (StreamWriter writer = File.AppendText(logFile))
			{
				writer.WriteLine("{0} - {1}", TimeStamp(), logEntry);
			}
		}
		
		private static string TimeStamp()
		{
			return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffffff");
		}
	}
}
