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
		private System.Windows.Forms.Panel pnlResources;
		
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
			this.pnlResources = new System.Windows.Forms.Panel();
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
			this.pnlResources.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlResources
			// 
			this.pnlResources.AutoSize = true;
			this.pnlResources.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnlResources.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlResources.Controls.Add(this.txtRadAway);
			this.pnlResources.Controls.Add(this.txtStimPack);
			this.pnlResources.Controls.Add(this.txtWater);
			this.pnlResources.Controls.Add(this.txtFood);
			this.pnlResources.Controls.Add(this.txtCaps);
			this.pnlResources.Controls.Add(this.txtEnergy);
			this.pnlResources.Controls.Add(this.lblRadAway);
			this.pnlResources.Controls.Add(this.lblStimPack);
			this.pnlResources.Controls.Add(this.lblWater);
			this.pnlResources.Controls.Add(this.lblEnergy);
			this.pnlResources.Controls.Add(this.lblFood);
			this.pnlResources.Controls.Add(this.lblCaps);
			this.pnlResources.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlResources.Location = new System.Drawing.Point(0, 0);
			this.pnlResources.Name = "pnlResources";
			this.pnlResources.Size = new System.Drawing.Size(203, 158);
			this.pnlResources.TabIndex = 28;
			// 
			// txtRadAway
			// 
			this.txtRadAway.Location = new System.Drawing.Point(100, 133);
			this.txtRadAway.MaxLength = 9;
			this.txtRadAway.Name = "txtRadAway";
			this.txtRadAway.Size = new System.Drawing.Size(98, 20);
			this.txtRadAway.TabIndex = 39;
			this.txtRadAway.Text = "0";
			// 
			// txtStimPack
			// 
			this.txtStimPack.Location = new System.Drawing.Point(100, 108);
			this.txtStimPack.MaxLength = 9;
			this.txtStimPack.Name = "txtStimPack";
			this.txtStimPack.Size = new System.Drawing.Size(98, 20);
			this.txtStimPack.TabIndex = 38;
			this.txtStimPack.Text = "0";
			// 
			// txtWater
			// 
			this.txtWater.Location = new System.Drawing.Point(100, 81);
			this.txtWater.MaxLength = 9;
			this.txtWater.Name = "txtWater";
			this.txtWater.Size = new System.Drawing.Size(98, 20);
			this.txtWater.TabIndex = 37;
			this.txtWater.Text = "0";
			// 
			// txtFood
			// 
			this.txtFood.Location = new System.Drawing.Point(100, 56);
			this.txtFood.MaxLength = 9;
			this.txtFood.Name = "txtFood";
			this.txtFood.Size = new System.Drawing.Size(98, 20);
			this.txtFood.TabIndex = 36;
			this.txtFood.Text = "0";
			// 
			// txtCaps
			// 
			this.txtCaps.Location = new System.Drawing.Point(100, 3);
			this.txtCaps.MaxLength = 9;
			this.txtCaps.Name = "txtCaps";
			this.txtCaps.Size = new System.Drawing.Size(98, 20);
			this.txtCaps.TabIndex = 35;
			this.txtCaps.Text = "0";
			// 
			// txtEnergy
			// 
			this.txtEnergy.Location = new System.Drawing.Point(100, 29);
			this.txtEnergy.MaxLength = 9;
			this.txtEnergy.Name = "txtEnergy";
			this.txtEnergy.Size = new System.Drawing.Size(98, 20);
			this.txtEnergy.TabIndex = 30;
			this.txtEnergy.Text = "0";
			// 
			// lblRadAway
			// 
			this.lblRadAway.AutoSize = true;
			this.lblRadAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRadAway.Location = new System.Drawing.Point(13, 134);
			this.lblRadAway.Name = "lblRadAway";
			this.lblRadAway.Size = new System.Drawing.Size(74, 16);
			this.lblRadAway.TabIndex = 34;
			this.lblRadAway.Text = "Rad-Away:";
			// 
			// lblStimPack
			// 
			this.lblStimPack.AutoSize = true;
			this.lblStimPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStimPack.Location = new System.Drawing.Point(26, 109);
			this.lblStimPack.Name = "lblStimPack";
			this.lblStimPack.Size = new System.Drawing.Size(68, 16);
			this.lblStimPack.TabIndex = 33;
			this.lblStimPack.Text = "StimPack:";
			// 
			// lblWater
			// 
			this.lblWater.AutoSize = true;
			this.lblWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWater.Location = new System.Drawing.Point(40, 82);
			this.lblWater.Name = "lblWater";
			this.lblWater.Size = new System.Drawing.Size(47, 16);
			this.lblWater.TabIndex = 32;
			this.lblWater.Text = "Water:";
			// 
			// lblEnergy
			// 
			this.lblEnergy.AutoSize = true;
			this.lblEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnergy.Location = new System.Drawing.Point(40, 30);
			this.lblEnergy.Name = "lblEnergy";
			this.lblEnergy.Size = new System.Drawing.Size(54, 16);
			this.lblEnergy.TabIndex = 29;
			this.lblEnergy.Text = "Energy:";
			// 
			// lblFood
			// 
			this.lblFood.AutoSize = true;
			this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFood.Location = new System.Drawing.Point(51, 57);
			this.lblFood.Name = "lblFood";
			this.lblFood.Size = new System.Drawing.Size(43, 16);
			this.lblFood.TabIndex = 31;
			this.lblFood.Text = "Food:";
			// 
			// lblCaps
			// 
			this.lblCaps.AutoSize = true;
			this.lblCaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCaps.Location = new System.Drawing.Point(51, 4);
			this.lblCaps.Name = "lblCaps";
			this.lblCaps.Size = new System.Drawing.Size(43, 16);
			this.lblCaps.TabIndex = 28;
			this.lblCaps.Text = "Caps:";
			// 
			// VaultResources
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.pnlResources);
			this.DoubleBuffered = true;
			this.Name = "VaultResources";
			this.Size = new System.Drawing.Size(203, 158);
			this.pnlResources.ResumeLayout(false);
			this.pnlResources.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
