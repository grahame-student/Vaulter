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
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

using FOSSaveData;

namespace Vaulter
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private SaveFile saveData = new SaveFile();
		private string savePath;
		private bool saveFileLoaded;
		
		public MainForm()
		{
			InitializeComponent();
			
			tabstripTopLevelGroup.DrawItem += tab_DrawItem;
			tabstripVault.DrawItem += tab_DrawItem;
			tabstripInhabitants.DrawItem += tab_DrawItem;
			saveData.FileOpened += SaveData_FileOpened;
		}
		
		#region Menubar handling
		private void OpenToolStripMenuItemClick(object sender, EventArgs e)
		{
			var dialog = new OpenFileDialog();
			DialogResult result = dialog.ShowDialog();
			
			if (result == DialogResult.OK)
			{
				savePath = dialog.FileName;
				OpenSaveFile(savePath);
			}
		}
		
		private void OpenSaveFile(string FilePath)
		{
			try
			{
				ReadSaveFile(new UTF8Encoding().GetString(File.ReadAllBytes(FilePath)));
			}
			catch (Exception ex)
			{
				// TODO: Improve error reporting to be more helpful than simply a stacktrace
				AppLog.LogError("Exception in OpenSaveFile:\n" +
				                ex.StackTrace);
			}
		}
		
		private void ReadSaveFile(string FileContents)
		{
			saveData.Read(FileContents);
		}
		
		private void SaveToolStripMenuItemClick(object sender, EventArgs e)
		{
			SaveDataToDisk(savePath);
		}
		
		private void SaveAsToolStripMenuItemClick(object sender, EventArgs e)
		{
			var dialog = new SaveFileDialog();
			DialogResult result = dialog.ShowDialog();
			
			if (result == DialogResult.OK)
			{
				savePath = dialog.FileName;
				SaveDataToDisk(savePath);
			}
		}
		
		private void SaveDataToDisk(string filePath)
		{
			try
			{
				File.WriteAllBytes(filePath, saveData.EncryptedData());
			}
			catch (Exception ex)
			{
				AppLog.LogError("Exception in SaveDataToDisk: \n" +
				                ex.StackTrace);
			}
		}
		
		private void QuitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		#endregion
		
		private void tab_DrawItem(object sender, DrawItemEventArgs e)
		{
			// TODO: Function too big, split up into manageable chunks
			
			var tabStrip = sender as TabControl;
			Graphics graphics = e.Graphics;
			Brush _textBrush;
			
			TabPage _tabPage = tabStrip.TabPages[e.Index];
			
			Rectangle _tabBounds = tabStrip.GetTabRect(e.Index);
			
			if (e.State == DrawItemState.Selected)
			{
				_textBrush = new SolidBrush(Color.Black);
				graphics.FillRectangle(Brushes.Transparent, e.Bounds);
			}
			else
			{
				_textBrush = new SolidBrush(e.ForeColor);
				graphics.FillRectangle(Brushes.Transparent, e.Bounds);
			}
			
			var _tabFont = e.Font;
			
			var _stringFlags = new StringFormat();
			_stringFlags.Alignment = StringAlignment.Center;
			_stringFlags.LineAlignment = StringAlignment.Center;
			graphics.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
		}
		
		private void SaveData_FileOpened(Object sender, FileOpenedArgs e)
		{
			saveData = e.saveFile;
			BindProperties();
			
			tabstripTopLevelGroup.Visible = (saveData != null);
			saveFileLoaded = true;
		}
		
		private void BindProperties()
		{
			BindVaultProperties(saveData.vault);
			BindDwellerProperties(saveData.dwellers);
		}
		
		private void BindVaultProperties(Vault vault)
		{
			vaultName.BindProperties(vault);
			vaultResources.BindProperties(vault.storage);
		}
		
		private void BindDwellerProperties(Inhabitants inhabitants)
		{
			dwellerList.BindProperties(inhabitants);
		}
		
		private void EnableSaving()
		{
			saveToolStripMenuItem.Enabled = saveFileLoaded;
			saveAsToolStripMenuItem.Enabled = saveFileLoaded;
		}
	}
}
