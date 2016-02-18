﻿namespace RFIDSystemTest
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pMenu = new System.Windows.Forms.Panel();
            this.bSettings = new System.Windows.Forms.Button();
            this.bKits = new System.Windows.Forms.Button();
            this.bCategories = new System.Windows.Forms.Button();
            this.bCompetitors = new System.Windows.Forms.Button();
            this.bEvents = new System.Windows.Forms.Button();
            this.bProfile = new System.Windows.Forms.Button();
            this.pContent = new System.Windows.Forms.Panel();
            this.pTitle = new System.Windows.Forms.Panel();
            this.lTitle = new System.Windows.Forms.Label();
            this.pInfo = new System.Windows.Forms.Panel();
            this.lCredits = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lSubtitle = new System.Windows.Forms.Label();
            this.pMenu.SuspendLayout();
            this.pTitle.SuspendLayout();
            this.pInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.bSettings);
            this.pMenu.Controls.Add(this.bKits);
            this.pMenu.Controls.Add(this.bCategories);
            this.pMenu.Controls.Add(this.bCompetitors);
            this.pMenu.Controls.Add(this.bEvents);
            this.pMenu.Controls.Add(this.bProfile);
            this.pMenu.Location = new System.Drawing.Point(0, 41);
            this.pMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(573, 1232);
            this.pMenu.TabIndex = 0;
            // 
            // bSettings
            // 
            this.bSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSettings.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bSettings.Location = new System.Drawing.Point(26, 609);
            this.bSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(525, 78);
            this.bSettings.TabIndex = 5;
            this.bSettings.Text = "Settings";
            this.bSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSettings.UseVisualStyleBackColor = true;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // bKits
            // 
            this.bKits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bKits.Location = new System.Drawing.Point(26, 494);
            this.bKits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bKits.Name = "bKits";
            this.bKits.Size = new System.Drawing.Size(525, 78);
            this.bKits.TabIndex = 4;
            this.bKits.Text = "Kits";
            this.bKits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bKits.UseVisualStyleBackColor = true;
            this.bKits.Click += new System.EventHandler(this.bKits_Click);
            // 
            // bCategories
            // 
            this.bCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCategories.Location = new System.Drawing.Point(26, 378);
            this.bCategories.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCategories.Name = "bCategories";
            this.bCategories.Size = new System.Drawing.Size(525, 78);
            this.bCategories.TabIndex = 3;
            this.bCategories.Text = "Categories";
            this.bCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCategories.UseVisualStyleBackColor = true;
            this.bCategories.Click += new System.EventHandler(this.bCategories_Click);
            // 
            // bCompetitors
            // 
            this.bCompetitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCompetitors.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bCompetitors.Location = new System.Drawing.Point(26, 259);
            this.bCompetitors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bCompetitors.Name = "bCompetitors";
            this.bCompetitors.Size = new System.Drawing.Size(525, 78);
            this.bCompetitors.TabIndex = 2;
            this.bCompetitors.Text = "Competitors";
            this.bCompetitors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bCompetitors.UseVisualStyleBackColor = true;
            this.bCompetitors.Click += new System.EventHandler(this.bCompetitors_Click);
            // 
            // bEvents
            // 
            this.bEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEvents.Location = new System.Drawing.Point(26, 142);
            this.bEvents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bEvents.Name = "bEvents";
            this.bEvents.Size = new System.Drawing.Size(525, 78);
            this.bEvents.TabIndex = 1;
            this.bEvents.Text = "Events";
            this.bEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEvents.UseVisualStyleBackColor = true;
            this.bEvents.Click += new System.EventHandler(this.bEvents_Click);
            // 
            // bProfile
            // 
            this.bProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProfile.Location = new System.Drawing.Point(26, 34);
            this.bProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bProfile.Name = "bProfile";
            this.bProfile.Size = new System.Drawing.Size(525, 78);
            this.bProfile.TabIndex = 0;
            this.bProfile.Text = "adfadsfads";
            this.bProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bProfile.UseVisualStyleBackColor = true;
            this.bProfile.Click += new System.EventHandler(this.bProfile_Click);
            // 
            // pContent
            // 
            this.pContent.AutoScroll = true;
            this.pContent.AutoSize = true;
            this.pContent.Location = new System.Drawing.Point(645, 278);
            this.pContent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(1963, 1042);
            this.pContent.TabIndex = 1;
            // 
            // pTitle
            // 
            this.pTitle.Controls.Add(this.lSubtitle);
            this.pTitle.Controls.Add(this.lTitle);
            this.pTitle.Location = new System.Drawing.Point(645, 89);
            this.pTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(1851, 151);
            this.pTitle.TabIndex = 2;
            this.pTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pTitle_Paint);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(30, 20);
            this.lTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(221, 73);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Profile";
            this.lTitle.Click += new System.EventHandler(this.lTitle_Click);
            // 
            // pInfo
            // 
            this.pInfo.Controls.Add(this.lCredits);
            this.pInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pInfo.Location = new System.Drawing.Point(0, 1139);
            this.pInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(2552, 134);
            this.pInfo.TabIndex = 1;
            this.pInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pInfo_Paint);
            // 
            // lCredits
            // 
            this.lCredits.AutoSize = true;
            this.lCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCredits.Location = new System.Drawing.Point(123, 195);
            this.lCredits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCredits.Name = "lCredits";
            this.lCredits.Size = new System.Drawing.Size(319, 37);
            this.lCredits.TabIndex = 2;
            this.lCredits.Text = "A RestCont Creation.";
            this.lCredits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(113)))), ((int)(((byte)(139)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(2552, 42);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // lSubtitle
            // 
            this.lSubtitle.AutoSize = true;
            this.lSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSubtitle.Location = new System.Drawing.Point(36, 93);
            this.lSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSubtitle.Name = "lSubtitle";
            this.lSubtitle.Size = new System.Drawing.Size(114, 37);
            this.lSubtitle.TabIndex = 1;
            this.lSubtitle.Text = "Profile";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2552, 1273);
            this.Controls.Add(this.pInfo);
            this.Controls.Add(this.pTitle);
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Resize += new System.EventHandler(this.Dashboard_Resize_End);
            this.pMenu.ResumeLayout(false);
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.pInfo.ResumeLayout(false);
            this.pInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pContent;
        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lCredits;
        private System.Windows.Forms.Button bSettings;
        private System.Windows.Forms.Button bKits;
        private System.Windows.Forms.Button bCategories;
        private System.Windows.Forms.Button bCompetitors;
        private System.Windows.Forms.Button bEvents;
        private System.Windows.Forms.Button bProfile;
        private System.Windows.Forms.Label lSubtitle;
    }
}