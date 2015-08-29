/*
 * Created by SharpDevelop.
 * User: Grahame
 * Date: 23/08/2015
 * Time: 18:32
 */
namespace Valuter
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabTopLevelGroup;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.TabControl tabVault;
		private System.Windows.Forms.TabPage tabVaultResources;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.Label lblCaps;
		private System.Windows.Forms.Label lblWater;
		private System.Windows.Forms.Label lblEnergy;
		private System.Windows.Forms.Label lblFood;
		private System.Windows.Forms.Label lblRadAway;
		private System.Windows.Forms.Label lblStimPack;
		private System.Windows.Forms.TextBox txtEnergy;
		private System.Windows.Forms.TextBox txtRadAway;
		private System.Windows.Forms.TextBox txtStimPack;
		private System.Windows.Forms.TextBox txtWater;
		private System.Windows.Forms.TextBox txtFood;
		private System.Windows.Forms.TextBox txtCaps;
		
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
			this.tabTopLevelGroup = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabVault = new System.Windows.Forms.TabControl();
			this.tabVaultResources = new System.Windows.Forms.TabPage();
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabTopLevelGroup.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabVault.SuspendLayout();
			this.tabVaultResources.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabTopLevelGroup
			// 
			this.tabTopLevelGroup.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.tabTopLevelGroup.Controls.Add(this.tabPage1);
			this.tabTopLevelGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabTopLevelGroup.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabTopLevelGroup.ItemSize = new System.Drawing.Size(25, 100);
			this.tabTopLevelGroup.Location = new System.Drawing.Point(0, 24);
			this.tabTopLevelGroup.Margin = new System.Windows.Forms.Padding(1);
			this.tabTopLevelGroup.Multiline = true;
			this.tabTopLevelGroup.Name = "tabTopLevelGroup";
			this.tabTopLevelGroup.Padding = new System.Drawing.Point(1, 1);
			this.tabTopLevelGroup.SelectedIndex = 0;
			this.tabTopLevelGroup.Size = new System.Drawing.Size(1157, 532);
			this.tabTopLevelGroup.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabTopLevelGroup.TabIndex = 1;
			this.tabTopLevelGroup.Visible = false;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tabVault);
			this.tabPage1.Location = new System.Drawing.Point(104, 4);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(1049, 524);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Vault";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabVault
			// 
			this.tabVault.Controls.Add(this.tabVaultResources);
			this.tabVault.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabVault.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabVault.ItemSize = new System.Drawing.Size(100, 20);
			this.tabVault.Location = new System.Drawing.Point(0, 0);
			this.tabVault.Margin = new System.Windows.Forms.Padding(1);
			this.tabVault.Name = "tabVault";
			this.tabVault.Padding = new System.Drawing.Point(1, 1);
			this.tabVault.SelectedIndex = 0;
			this.tabVault.Size = new System.Drawing.Size(1049, 524);
			this.tabVault.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabVault.TabIndex = 0;
			// 
			// tabVaultResources
			// 
			this.tabVaultResources.Controls.Add(this.txtRadAway);
			this.tabVaultResources.Controls.Add(this.txtStimPack);
			this.tabVaultResources.Controls.Add(this.txtWater);
			this.tabVaultResources.Controls.Add(this.txtFood);
			this.tabVaultResources.Controls.Add(this.txtCaps);
			this.tabVaultResources.Controls.Add(this.txtEnergy);
			this.tabVaultResources.Controls.Add(this.lblRadAway);
			this.tabVaultResources.Controls.Add(this.lblStimPack);
			this.tabVaultResources.Controls.Add(this.lblWater);
			this.tabVaultResources.Controls.Add(this.lblEnergy);
			this.tabVaultResources.Controls.Add(this.lblFood);
			this.tabVaultResources.Controls.Add(this.lblCaps);
			this.tabVaultResources.Location = new System.Drawing.Point(4, 24);
			this.tabVaultResources.Margin = new System.Windows.Forms.Padding(0);
			this.tabVaultResources.Name = "tabVaultResources";
			this.tabVaultResources.Size = new System.Drawing.Size(1041, 496);
			this.tabVaultResources.TabIndex = 0;
			this.tabVaultResources.Text = "Resources";
			this.tabVaultResources.UseVisualStyleBackColor = true;
			// 
			// txtRadAway
			// 
			this.txtRadAway.Location = new System.Drawing.Point(95, 172);
			this.txtRadAway.Name = "txtRadAway";
			this.txtRadAway.Size = new System.Drawing.Size(98, 20);
			this.txtRadAway.TabIndex = 15;
			this.txtRadAway.Text = "0";
			this.txtRadAway.TextChanged += new System.EventHandler(this.EnableSaving);
			// 
			// txtStimPack
			// 
			this.txtStimPack.Location = new System.Drawing.Point(95, 146);
			this.txtStimPack.Name = "txtStimPack";
			this.txtStimPack.Size = new System.Drawing.Size(98, 20);
			this.txtStimPack.TabIndex = 14;
			this.txtStimPack.Text = "0";
			this.txtStimPack.TextChanged += new System.EventHandler(this.EnableSaving);
			// 
			// txtWater
			// 
			this.txtWater.Location = new System.Drawing.Point(95, 120);
			this.txtWater.Name = "txtWater";
			this.txtWater.Size = new System.Drawing.Size(98, 20);
			this.txtWater.TabIndex = 13;
			this.txtWater.Text = "0";
			this.txtWater.TextChanged += new System.EventHandler(this.EnableSaving);
			// 
			// txtFood
			// 
			this.txtFood.Location = new System.Drawing.Point(95, 94);
			this.txtFood.Name = "txtFood";
			this.txtFood.Size = new System.Drawing.Size(98, 20);
			this.txtFood.TabIndex = 12;
			this.txtFood.Text = "0";
			this.txtFood.TextChanged += new System.EventHandler(this.EnableSaving);
			// 
			// txtCaps
			// 
			this.txtCaps.Location = new System.Drawing.Point(95, 42);
			this.txtCaps.Name = "txtCaps";
			this.txtCaps.Size = new System.Drawing.Size(98, 20);
			this.txtCaps.TabIndex = 11;
			this.txtCaps.Text = "0";
			this.txtCaps.TextChanged += new System.EventHandler(this.EnableSaving);
			// 
			// txtEnergy
			// 
			this.txtEnergy.Location = new System.Drawing.Point(95, 68);
			this.txtEnergy.Name = "txtEnergy";
			this.txtEnergy.Size = new System.Drawing.Size(98, 20);
			this.txtEnergy.TabIndex = 3;
			this.txtEnergy.Text = "0";
			this.txtEnergy.TextChanged += new System.EventHandler(this.EnableSaving);
			// 
			// lblRadAway
			// 
			this.lblRadAway.AutoSize = true;
			this.lblRadAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRadAway.Location = new System.Drawing.Point(15, 173);
			this.lblRadAway.Name = "lblRadAway";
			this.lblRadAway.Size = new System.Drawing.Size(74, 16);
			this.lblRadAway.TabIndex = 10;
			this.lblRadAway.Text = "Rad-Away:";
			// 
			// lblStimPack
			// 
			this.lblStimPack.AutoSize = true;
			this.lblStimPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStimPack.Location = new System.Drawing.Point(21, 147);
			this.lblStimPack.Name = "lblStimPack";
			this.lblStimPack.Size = new System.Drawing.Size(68, 16);
			this.lblStimPack.TabIndex = 8;
			this.lblStimPack.Text = "StimPack:";
			// 
			// lblWater
			// 
			this.lblWater.AutoSize = true;
			this.lblWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWater.Location = new System.Drawing.Point(42, 121);
			this.lblWater.Name = "lblWater";
			this.lblWater.Size = new System.Drawing.Size(47, 16);
			this.lblWater.TabIndex = 7;
			this.lblWater.Text = "Water:";
			// 
			// lblEnergy
			// 
			this.lblEnergy.AutoSize = true;
			this.lblEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnergy.Location = new System.Drawing.Point(35, 69);
			this.lblEnergy.Name = "lblEnergy";
			this.lblEnergy.Size = new System.Drawing.Size(54, 16);
			this.lblEnergy.TabIndex = 2;
			this.lblEnergy.Text = "Energy:";
			// 
			// lblFood
			// 
			this.lblFood.AutoSize = true;
			this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFood.Location = new System.Drawing.Point(46, 95);
			this.lblFood.Name = "lblFood";
			this.lblFood.Size = new System.Drawing.Size(43, 16);
			this.lblFood.TabIndex = 4;
			this.lblFood.Text = "Food:";
			// 
			// lblCaps
			// 
			this.lblCaps.AutoSize = true;
			this.lblCaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCaps.Location = new System.Drawing.Point(46, 43);
			this.lblCaps.Name = "lblCaps";
			this.lblCaps.Size = new System.Drawing.Size(43, 16);
			this.lblCaps.TabIndex = 0;
			this.lblCaps.Text = "Caps:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1157, 24);
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
			this.ClientSize = new System.Drawing.Size(1157, 556);
			this.Controls.Add(this.tabTopLevelGroup);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Valuter";
			this.tabTopLevelGroup.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabVault.ResumeLayout(false);
			this.tabVaultResources.ResumeLayout(false);
			this.tabVaultResources.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
