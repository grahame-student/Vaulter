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

namespace Vaulter
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabstripTopLevelGroup;
		private System.Windows.Forms.TabPage tabVault;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.TabControl tabstripVault;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.TabPage tabVaultBasics;
		private Dashboard.VaultResources vaultResources;
		private Vaulter.Dashboard.VaultName vaultName;
		private System.Windows.Forms.TableLayoutPanel tableVaultLayout;
		private System.Windows.Forms.TabControl tabstripInhabitants;
		private System.Windows.Forms.TabPage tabDwellerList;
		private Vaulter.Dashboard.DwellerList dwellerList;
		private System.Windows.Forms.TabPage tabInhabitants;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabstripTopLevelGroup = new System.Windows.Forms.TabControl();
			this.tabVault = new System.Windows.Forms.TabPage();
			this.tabstripVault = new System.Windows.Forms.TabControl();
			this.tabVaultBasics = new System.Windows.Forms.TabPage();
			this.tableVaultLayout = new System.Windows.Forms.TableLayoutPanel();
			this.vaultResources = new Vaulter.Dashboard.VaultResources();
			this.vaultName = new Vaulter.Dashboard.VaultName();
			this.tabInhabitants = new System.Windows.Forms.TabPage();
			this.tabstripInhabitants = new System.Windows.Forms.TabControl();
			this.tabDwellerList = new System.Windows.Forms.TabPage();
			this.dwellerList = new Vaulter.Dashboard.DwellerList();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabstripTopLevelGroup.SuspendLayout();
			this.tabVault.SuspendLayout();
			this.tabstripVault.SuspendLayout();
			this.tabVaultBasics.SuspendLayout();
			this.tableVaultLayout.SuspendLayout();
			this.tabstripInhabitants.SuspendLayout();
			this.tabDwellerList.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabstripTopLevelGroup
			// 
			this.tabstripTopLevelGroup.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.tabstripTopLevelGroup.Controls.Add(this.tabVault);
			this.tabstripTopLevelGroup.Controls.Add(this.tabInhabitants);
			this.tabstripTopLevelGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabstripTopLevelGroup.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabstripTopLevelGroup.ItemSize = new System.Drawing.Size(25, 100);
			this.tabstripTopLevelGroup.Location = new System.Drawing.Point(0, 24);
			this.tabstripTopLevelGroup.Margin = new System.Windows.Forms.Padding(1);
			this.tabstripTopLevelGroup.Multiline = true;
			this.tabstripTopLevelGroup.Name = "tabstripTopLevelGroup";
			this.tabstripTopLevelGroup.Padding = new System.Drawing.Point(1, 1);
			this.tabstripTopLevelGroup.SelectedIndex = 0;
			this.tabstripTopLevelGroup.Size = new System.Drawing.Size(1098, 532);
			this.tabstripTopLevelGroup.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabstripTopLevelGroup.TabIndex = 1;
			this.tabstripTopLevelGroup.Visible = false;
			// 
			// tabVault
			// 
			this.tabVault.Controls.Add(this.tabstripVault);
			this.tabVault.Location = new System.Drawing.Point(104, 4);
			this.tabVault.Margin = new System.Windows.Forms.Padding(0);
			this.tabVault.Name = "tabVault";
			this.tabVault.Size = new System.Drawing.Size(990, 524);
			this.tabVault.TabIndex = 0;
			this.tabVault.Text = "Vault";
			this.tabVault.UseVisualStyleBackColor = true;
			// 
			// tabstripVault
			// 
			this.tabstripVault.Controls.Add(this.tabVaultBasics);
			this.tabstripVault.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabstripVault.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabstripVault.ItemSize = new System.Drawing.Size(100, 20);
			this.tabstripVault.Location = new System.Drawing.Point(0, 0);
			this.tabstripVault.Margin = new System.Windows.Forms.Padding(1);
			this.tabstripVault.Name = "tabstripVault";
			this.tabstripVault.Padding = new System.Drawing.Point(1, 1);
			this.tabstripVault.SelectedIndex = 0;
			this.tabstripVault.Size = new System.Drawing.Size(990, 524);
			this.tabstripVault.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabstripVault.TabIndex = 0;
			// 
			// tabVaultBasics
			// 
			this.tabVaultBasics.Controls.Add(this.tableVaultLayout);
			this.tabVaultBasics.Location = new System.Drawing.Point(4, 24);
			this.tabVaultBasics.Name = "tabVaultBasics";
			this.tabVaultBasics.Size = new System.Drawing.Size(982, 496);
			this.tabVaultBasics.TabIndex = 1;
			this.tabVaultBasics.Text = "Basic Information";
			this.tabVaultBasics.UseVisualStyleBackColor = true;
			// 
			// tableVaultLayout
			// 
			this.tableVaultLayout.ColumnCount = 2;
			this.tableVaultLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableVaultLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableVaultLayout.Controls.Add(this.vaultResources, 0, 1);
			this.tableVaultLayout.Controls.Add(this.vaultName, 0, 0);
			this.tableVaultLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableVaultLayout.Location = new System.Drawing.Point(0, 0);
			this.tableVaultLayout.Name = "tableVaultLayout";
			this.tableVaultLayout.RowCount = 3;
			this.tableVaultLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableVaultLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableVaultLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableVaultLayout.Size = new System.Drawing.Size(982, 496);
			this.tableVaultLayout.TabIndex = 2;
			// 
			// vaultResources
			// 
			this.vaultResources.AutoSize = true;
			this.vaultResources.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.vaultResources.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vaultResources.Location = new System.Drawing.Point(3, 37);
			this.vaultResources.Name = "vaultResources";
			this.vaultResources.Size = new System.Drawing.Size(203, 158);
			this.vaultResources.TabIndex = 3;
			// 
			// vaultName
			// 
			this.vaultName.AutoSize = true;
			this.vaultName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.vaultName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.vaultName.Location = new System.Drawing.Point(3, 3);
			this.vaultName.Name = "vaultName";
			this.vaultName.Size = new System.Drawing.Size(203, 28);
			this.vaultName.TabIndex = 2;
			// 
			// tabInhabitants
			// 
			this.tabInhabitants.Controls.Add(tabstripInhabitants);
			this.tabInhabitants.Location = new System.Drawing.Point(104, 4);
			this.tabInhabitants.Name = "tabInhabitants";
			this.tabInhabitants.Size = new System.Drawing.Size(990, 524);
			this.tabInhabitants.TabIndex = 1;
			this.tabInhabitants.Text = "Inhabitants";
			this.tabInhabitants.UseVisualStyleBackColor = true;
			// 
			// tabstripInhabitants
			// 
			this.tabstripInhabitants.Controls.Add(this.tabDwellerList);
			this.tabstripInhabitants.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabstripInhabitants.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabstripInhabitants.Location = new System.Drawing.Point(0, 0);
			this.tabstripInhabitants.Name = "tabstripInhabitants";
			this.tabstripInhabitants.SelectedIndex = 0;
			this.tabstripInhabitants.Size = new System.Drawing.Size(990, 524);
			this.tabstripInhabitants.TabIndex = 1;
			// 
			// tabDwellerList
			// 
			this.tabDwellerList.Controls.Add(this.dwellerList);
			this.tabDwellerList.Location = new System.Drawing.Point(4, 22);
			this.tabDwellerList.Name = "tabDwellerList";
			this.tabDwellerList.Padding = new System.Windows.Forms.Padding(3);
			this.tabDwellerList.Size = new System.Drawing.Size(982, 498);
			this.tabDwellerList.TabIndex = 0;
			this.tabDwellerList.Text = "Dwellers";
			this.tabDwellerList.UseVisualStyleBackColor = true;
			// 
			// dwellerList
			// 
			this.dwellerList.AutoSize = true;
			this.dwellerList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.dwellerList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dwellerList.Location = new System.Drawing.Point(3, 3);
			this.dwellerList.Name = "dwellerList";
			this.dwellerList.Size = new System.Drawing.Size(976, 492);
			this.dwellerList.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1098, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.openToolStripMenuItem,
			this.saveToolStripMenuItem,
			this.saveAsToolStripMenuItem,
			this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItemClick);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Enabled = false;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItemClick);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Enabled = false;
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.saveAsToolStripMenuItem.Text = "Save As...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItemClick);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1098, 556);
			this.Controls.Add(this.tabstripTopLevelGroup);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Valuter";
			this.tabstripTopLevelGroup.ResumeLayout(false);
			this.tabVault.ResumeLayout(false);
			this.tabstripVault.ResumeLayout(false);
			this.tabVaultBasics.ResumeLayout(false);
			this.tableVaultLayout.ResumeLayout(false);
			this.tableVaultLayout.PerformLayout();
			this.tabInhabitants.ResumeLayout(false);
			this.tabstripInhabitants.ResumeLayout(false);
			this.tabDwellerList.ResumeLayout(false);
			this.tabDwellerList.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
