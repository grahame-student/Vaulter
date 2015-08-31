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
	partial class VaultName
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnlName;
		private System.Windows.Forms.MaskedTextBox txtName;
		private System.Windows.Forms.Label lblCaps;
		
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
			this.pnlName = new System.Windows.Forms.Panel();
			this.txtName = new System.Windows.Forms.MaskedTextBox();
			this.lblCaps = new System.Windows.Forms.Label();
			this.pnlName.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlName
			// 
			this.pnlName.AutoSize = true;
			this.pnlName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.pnlName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlName.Controls.Add(this.txtName);
			this.pnlName.Controls.Add(this.lblCaps);
			this.pnlName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlName.Location = new System.Drawing.Point(0, 0);
			this.pnlName.Name = "pnlName";
			this.pnlName.Size = new System.Drawing.Size(203, 28);
			this.pnlName.TabIndex = 29;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(100, 3);
			this.txtName.Mask = "000";
			this.txtName.Name = "txtName";
			this.txtName.PromptChar = '0';
			this.txtName.Size = new System.Drawing.Size(98, 20);
			this.txtName.TabIndex = 35;
			// 
			// lblCaps
			// 
			this.lblCaps.AutoSize = true;
			this.lblCaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCaps.Location = new System.Drawing.Point(13, 4);
			this.lblCaps.Name = "lblCaps";
			this.lblCaps.Size = new System.Drawing.Size(81, 16);
			this.lblCaps.TabIndex = 28;
			this.lblCaps.Text = "Vault Name:";
			// 
			// VaultName
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.pnlName);
			this.Name = "VaultName";
			this.Size = new System.Drawing.Size(203, 28);
			this.pnlName.ResumeLayout(false);
			this.pnlName.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
