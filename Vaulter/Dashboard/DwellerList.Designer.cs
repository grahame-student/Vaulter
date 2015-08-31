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

namespace Vaulter.Dashboard
{
	/// <summary>
	/// Description of DwellerList.
	/// </summary>
	public partial class DwellerList
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView gridDwellers;
		private System.Windows.Forms.Panel pnlDwellerList;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
		private System.Windows.Forms.DataGridViewTextBoxColumn Level;
		private System.Windows.Forms.DataGridViewTextBoxColumn Strength;
		private System.Windows.Forms.DataGridViewTextBoxColumn Perception;
		private System.Windows.Forms.DataGridViewTextBoxColumn Endurance;
		private System.Windows.Forms.DataGridViewTextBoxColumn Charisma;
		private System.Windows.Forms.DataGridViewTextBoxColumn Intelligence;
		private System.Windows.Forms.DataGridViewTextBoxColumn Agility;
		private System.Windows.Forms.DataGridViewTextBoxColumn Luck;
		private System.Windows.Forms.DataGridViewTextBoxColumn Weapon;
		private System.Windows.Forms.DataGridViewTextBoxColumn Outfit;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.VScrollBar vscrRow;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pnlDwellerList = new System.Windows.Forms.Panel();
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.gridDwellers = new System.Windows.Forms.DataGridView();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Strength = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Perception = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Endurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Charisma = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Intelligence = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Agility = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Luck = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Weapon = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Outfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.vscrRow = new System.Windows.Forms.VScrollBar();
			this.pnlDwellerList.SuspendLayout();
			this.tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDwellers)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlDwellerList
			// 
			this.pnlDwellerList.AutoSize = true;
			this.pnlDwellerList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnlDwellerList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlDwellerList.Controls.Add(this.tableLayoutPanel);
			this.pnlDwellerList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlDwellerList.Location = new System.Drawing.Point(0, 0);
			this.pnlDwellerList.Name = "pnlDwellerList";
			this.pnlDwellerList.Size = new System.Drawing.Size(727, 567);
			this.pnlDwellerList.TabIndex = 30;
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.AutoSize = true;
			this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel.ColumnCount = 2;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel.Controls.Add(this.gridDwellers, 0, 0);
			this.tableLayoutPanel.Controls.Add(this.vscrRow, 1, 0);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 1;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(725, 565);
			this.tableLayoutPanel.TabIndex = 2;
			// 
			// gridDwellers
			// 
			this.gridDwellers.AllowUserToAddRows = false;
			this.gridDwellers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridDwellers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.gridDwellers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDwellers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.FirstName,
			this.LastName,
			this.Gender,
			this.Level,
			this.Strength,
			this.Perception,
			this.Endurance,
			this.Charisma,
			this.Intelligence,
			this.Agility,
			this.Luck,
			this.Weapon,
			this.Outfit});
			this.gridDwellers.Location = new System.Drawing.Point(3, 3);
			this.gridDwellers.Name = "gridDwellers";
			this.gridDwellers.RowHeadersVisible = false;
			this.gridDwellers.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.gridDwellers.Size = new System.Drawing.Size(680, 558);
			this.gridDwellers.TabIndex = 2;
			// 
			// FirstName
			// 
			this.FirstName.HeaderText = "Name";
			this.FirstName.Name = "FirstName";
			// 
			// LastName
			// 
			this.LastName.HeaderText = "Last Name";
			this.LastName.Name = "LastName";
			// 
			// Gender
			// 
			this.Gender.HeaderText = "Gender";
			this.Gender.Name = "Gender";
			// 
			// Level
			// 
			this.Level.HeaderText = "Level";
			this.Level.Name = "Level";
			// 
			// Strength
			// 
			this.Strength.HeaderText = "S";
			this.Strength.Name = "Strength";
			// 
			// Perception
			// 
			this.Perception.HeaderText = "P";
			this.Perception.Name = "Perception";
			// 
			// Endurance
			// 
			this.Endurance.HeaderText = "E";
			this.Endurance.Name = "Endurance";
			// 
			// Charisma
			// 
			this.Charisma.HeaderText = "C";
			this.Charisma.Name = "Charisma";
			// 
			// Intelligence
			// 
			this.Intelligence.HeaderText = "I";
			this.Intelligence.Name = "Intelligence";
			// 
			// Agility
			// 
			this.Agility.HeaderText = "A";
			this.Agility.Name = "Agility";
			// 
			// Luck
			// 
			this.Luck.HeaderText = "L";
			this.Luck.Name = "Luck";
			// 
			// Weapon
			// 
			this.Weapon.HeaderText = "Weapon";
			this.Weapon.Name = "Weapon";
			// 
			// Outfit
			// 
			this.Outfit.HeaderText = "Outfit";
			this.Outfit.Name = "Outfit";
			// 
			// vscrRow
			// 
			this.vscrRow.Dock = System.Windows.Forms.DockStyle.Left;
			this.vscrRow.Location = new System.Drawing.Point(686, 0);
			this.vscrRow.Name = "vscrRow";
			this.vscrRow.Size = new System.Drawing.Size(17, 565);
			this.vscrRow.TabIndex = 3;
			this.vscrRow.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VscrRowScroll);
			// 
			// DwellerList
			// 
			this.AutoSize = true;
			this.Controls.Add(this.pnlDwellerList);
			this.Name = "DwellerList";
			this.Size = new System.Drawing.Size(727, 567);
			this.pnlDwellerList.ResumeLayout(false);
			this.pnlDwellerList.PerformLayout();
			this.tableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDwellers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
