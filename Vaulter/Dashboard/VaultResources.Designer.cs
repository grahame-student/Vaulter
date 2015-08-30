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

namespace Vaulter.Dashboard
{
	partial class VaultResources
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtRadAway;
		private System.Windows.Forms.TextBox txtStimPack;
		private System.Windows.Forms.TextBox txtWater;
		private System.Windows.Forms.TextBox txtFood;
		private System.Windows.Forms.TextBox txtCaps;
		private System.Windows.Forms.TextBox txtEnergy;
		private System.Windows.Forms.Label lblRadAway;
		private System.Windows.Forms.Label lblStimPack;
		private System.Windows.Forms.Label lblWater;
		private System.Windows.Forms.Label lblEnergy;
		private System.Windows.Forms.Label lblFood;
		private System.Windows.Forms.Label lblCaps;
		
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
			this.txtRadAway = new System.Windows.Forms.TextBox();
			this.txtStimPack = new System.Windows.Forms.TextBox();
			this.txtWater = new System.Windows.Forms.TextBox();
			this.txtFood = new System.Windows.Forms.TextBox();
			this.txtCaps = new System.Windows.Forms.TextBox();
			this.txtEnergy = new System.Windows.Forms.TextBox();
			this.lblRadAway = new System.Windows.Forms.Label();
			this.lblStimPack = new System.Windows.Forms.Label();
			this.lblWater = new System.Windows.Forms.Label();
			this.lblEnergy = new System.Windows.Forms.Label();
			this.lblFood = new System.Windows.Forms.Label();
			this.lblCaps = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtRadAway
			// 
			this.txtRadAway.Location = new System.Drawing.Point(94, 150);
			this.txtRadAway.Name = "txtRadAway";
			this.txtRadAway.Size = new System.Drawing.Size(98, 20);
			this.txtRadAway.TabIndex = 27;
			this.txtRadAway.Text = "0";
			this.txtRadAway.TextChanged += new System.EventHandler(this.OnPropertyChanged);
			// 
			// txtStimPack
			// 
			this.txtStimPack.Location = new System.Drawing.Point(94, 124);
			this.txtStimPack.Name = "txtStimPack";
			this.txtStimPack.Size = new System.Drawing.Size(98, 20);
			this.txtStimPack.TabIndex = 26;
			this.txtStimPack.Text = "0";
			this.txtStimPack.TextChanged += new System.EventHandler(this.OnPropertyChanged);
			// 
			// txtWater
			// 
			this.txtWater.Location = new System.Drawing.Point(94, 98);
			this.txtWater.Name = "txtWater";
			this.txtWater.Size = new System.Drawing.Size(98, 20);
			this.txtWater.TabIndex = 25;
			this.txtWater.Text = "0";
			this.txtWater.TextChanged += new System.EventHandler(this.OnPropertyChanged);
			// 
			// txtFood
			// 
			this.txtFood.Location = new System.Drawing.Point(94, 72);
			this.txtFood.Name = "txtFood";
			this.txtFood.Size = new System.Drawing.Size(98, 20);
			this.txtFood.TabIndex = 24;
			this.txtFood.Text = "0";
			this.txtFood.TextChanged += new System.EventHandler(this.OnPropertyChanged);
			// 
			// txtCaps
			// 
			this.txtCaps.Location = new System.Drawing.Point(94, 20);
			this.txtCaps.Name = "txtCaps";
			this.txtCaps.Size = new System.Drawing.Size(98, 20);
			this.txtCaps.TabIndex = 23;
			this.txtCaps.Text = "0";
			this.txtCaps.TextChanged += new System.EventHandler(this.OnPropertyChanged);
			// 
			// txtEnergy
			// 
			this.txtEnergy.Location = new System.Drawing.Point(94, 46);
			this.txtEnergy.Name = "txtEnergy";
			this.txtEnergy.Size = new System.Drawing.Size(98, 20);
			this.txtEnergy.TabIndex = 18;
			this.txtEnergy.Text = "0";
			this.txtEnergy.TextChanged += new System.EventHandler(this.OnPropertyChanged);
			// 
			// lblRadAway
			// 
			this.lblRadAway.AutoSize = true;
			this.lblRadAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRadAway.Location = new System.Drawing.Point(14, 151);
			this.lblRadAway.Name = "lblRadAway";
			this.lblRadAway.Size = new System.Drawing.Size(74, 16);
			this.lblRadAway.TabIndex = 22;
			this.lblRadAway.Text = "Rad-Away:";
			// 
			// lblStimPack
			// 
			this.lblStimPack.AutoSize = true;
			this.lblStimPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStimPack.Location = new System.Drawing.Point(20, 125);
			this.lblStimPack.Name = "lblStimPack";
			this.lblStimPack.Size = new System.Drawing.Size(68, 16);
			this.lblStimPack.TabIndex = 21;
			this.lblStimPack.Text = "StimPack:";
			// 
			// lblWater
			// 
			this.lblWater.AutoSize = true;
			this.lblWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWater.Location = new System.Drawing.Point(41, 99);
			this.lblWater.Name = "lblWater";
			this.lblWater.Size = new System.Drawing.Size(47, 16);
			this.lblWater.TabIndex = 20;
			this.lblWater.Text = "Water:";
			// 
			// lblEnergy
			// 
			this.lblEnergy.AutoSize = true;
			this.lblEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnergy.Location = new System.Drawing.Point(34, 47);
			this.lblEnergy.Name = "lblEnergy";
			this.lblEnergy.Size = new System.Drawing.Size(54, 16);
			this.lblEnergy.TabIndex = 17;
			this.lblEnergy.Text = "Energy:";
			// 
			// lblFood
			// 
			this.lblFood.AutoSize = true;
			this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFood.Location = new System.Drawing.Point(45, 73);
			this.lblFood.Name = "lblFood";
			this.lblFood.Size = new System.Drawing.Size(43, 16);
			this.lblFood.TabIndex = 19;
			this.lblFood.Text = "Food:";
			// 
			// lblCaps
			// 
			this.lblCaps.AutoSize = true;
			this.lblCaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCaps.Location = new System.Drawing.Point(45, 21);
			this.lblCaps.Name = "lblCaps";
			this.lblCaps.Size = new System.Drawing.Size(43, 16);
			this.lblCaps.TabIndex = 16;
			this.lblCaps.Text = "Caps:";
			// 
			// VaultBasics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.txtRadAway);
			this.Controls.Add(this.txtStimPack);
			this.Controls.Add(this.txtWater);
			this.Controls.Add(this.txtFood);
			this.Controls.Add(this.txtCaps);
			this.Controls.Add(this.txtEnergy);
			this.Controls.Add(this.lblRadAway);
			this.Controls.Add(this.lblStimPack);
			this.Controls.Add(this.lblWater);
			this.Controls.Add(this.lblEnergy);
			this.Controls.Add(this.lblFood);
			this.Controls.Add(this.lblCaps);
			this.DoubleBuffered = true;
			this.Name = "VaultBasics";
			this.Size = new System.Drawing.Size(218, 186);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
