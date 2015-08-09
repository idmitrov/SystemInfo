namespace SystemInfo
{
    partial class SysInfoForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysInfoForm));
            this.sysInfoListView = new System.Windows.Forms.ListView();
            this.listItemsContexMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getInfoButton = new System.Windows.Forms.Button();
            this.saveInfoButton = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishUnitedStatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulgarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetInfoButton = new System.Windows.Forms.Button();
            this.startupSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startUpSoundOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startUpSoundOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listItemsContexMenu.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // sysInfoListView
            // 
            this.sysInfoListView.ContextMenuStrip = this.listItemsContexMenu;
            this.sysInfoListView.Location = new System.Drawing.Point(12, 43);
            this.sysInfoListView.MultiSelect = false;
            this.sysInfoListView.Name = "sysInfoListView";
            this.sysInfoListView.Size = new System.Drawing.Size(328, 167);
            this.sysInfoListView.TabIndex = 0;
            this.sysInfoListView.TileSize = new System.Drawing.Size(320, 20);
            this.sysInfoListView.UseCompatibleStateImageBehavior = false;
            this.sysInfoListView.View = System.Windows.Forms.View.Tile;
            this.sysInfoListView.SelectedIndexChanged += new System.EventHandler(this.sysInfoListView_SelectedIndexChanged);
            // 
            // listItemsContexMenu
            // 
            this.listItemsContexMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewOnlineToolStripMenuItem});
            this.listItemsContexMenu.Name = "listItemsContexMenu";
            this.listItemsContexMenu.Size = new System.Drawing.Size(136, 26);
            this.listItemsContexMenu.Opening += new System.ComponentModel.CancelEventHandler(this.listItemsContexMenu_Opening);
            // 
            // viewOnlineToolStripMenuItem
            // 
            this.viewOnlineToolStripMenuItem.Name = "viewOnlineToolStripMenuItem";
            this.viewOnlineToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.viewOnlineToolStripMenuItem.Text = "View online";
            this.viewOnlineToolStripMenuItem.Click += new System.EventHandler(this.vewOnlineToolStripMenuItem_Click);
            // 
            // getInfoButton
            // 
            this.getInfoButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.getInfoButton.ForeColor = System.Drawing.Color.Black;
            this.getInfoButton.Location = new System.Drawing.Point(349, 43);
            this.getInfoButton.Name = "getInfoButton";
            this.getInfoButton.Size = new System.Drawing.Size(119, 52);
            this.getInfoButton.TabIndex = 1;
            this.getInfoButton.Text = "Get info";
            this.getInfoButton.UseVisualStyleBackColor = false;
            this.getInfoButton.Click += new System.EventHandler(this.getInfoButton_Click);
            // 
            // saveInfoButton
            // 
            this.saveInfoButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.saveInfoButton.ForeColor = System.Drawing.Color.Black;
            this.saveInfoButton.Location = new System.Drawing.Point(349, 158);
            this.saveInfoButton.Name = "saveInfoButton";
            this.saveInfoButton.Size = new System.Drawing.Size(120, 52);
            this.saveInfoButton.TabIndex = 2;
            this.saveInfoButton.Text = "Save";
            this.saveInfoButton.UseVisualStyleBackColor = false;
            this.saveInfoButton.Click += new System.EventHandler(this.saveInfoButton_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(479, 24);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "menuStrip1";
            this.mainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainMenu_ItemClicked);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languagesToolStripMenuItem,
            this.startupSoundToolStripMenuItem});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // languagesToolStripMenuItem
            // 
            this.languagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishUnitedStatesToolStripMenuItem,
            this.bulgarianToolStripMenuItem});
            this.languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
            this.languagesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.languagesToolStripMenuItem.Text = "Languages";
            // 
            // englishUnitedStatesToolStripMenuItem
            // 
            this.englishUnitedStatesToolStripMenuItem.Name = "englishUnitedStatesToolStripMenuItem";
            this.englishUnitedStatesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.englishUnitedStatesToolStripMenuItem.Text = "English United States";
            this.englishUnitedStatesToolStripMenuItem.Click += new System.EventHandler(this.englishUnitedStatesToolStripMenuItem_Click);
            // 
            // bulgarianToolStripMenuItem
            // 
            this.bulgarianToolStripMenuItem.Name = "bulgarianToolStripMenuItem";
            this.bulgarianToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.bulgarianToolStripMenuItem.Text = "Bulgarian";
            this.bulgarianToolStripMenuItem.Click += new System.EventHandler(this.bulgarianToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // resetInfoButton
            // 
            this.resetInfoButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.resetInfoButton.ForeColor = System.Drawing.Color.Black;
            this.resetInfoButton.Location = new System.Drawing.Point(349, 100);
            this.resetInfoButton.Name = "resetInfoButton";
            this.resetInfoButton.Size = new System.Drawing.Size(120, 52);
            this.resetInfoButton.TabIndex = 4;
            this.resetInfoButton.Text = "Reset";
            this.resetInfoButton.UseVisualStyleBackColor = false;
            this.resetInfoButton.Click += new System.EventHandler(this.resetInfoButton_Click);
            // 
            // startupSoundToolStripMenuItem
            // 
            this.startupSoundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startUpSoundOnToolStripMenuItem,
            this.startUpSoundOffToolStripMenuItem});
            this.startupSoundToolStripMenuItem.Name = "startupSoundToolStripMenuItem";
            this.startupSoundToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startupSoundToolStripMenuItem.Text = "Startup Sound";
            // 
            // startUpSoundOnToolStripMenuItem
            // 
            this.startUpSoundOnToolStripMenuItem.Name = "startUpSoundOnToolStripMenuItem";
            this.startUpSoundOnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startUpSoundOnToolStripMenuItem.Text = "On";
            this.startUpSoundOnToolStripMenuItem.Click += new System.EventHandler(this.startUpSoundOnToolStripMenuItem_Click);
            // 
            // startUpSoundOffToolStripMenuItem
            // 
            this.startUpSoundOffToolStripMenuItem.Name = "startUpSoundOffToolStripMenuItem";
            this.startUpSoundOffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startUpSoundOffToolStripMenuItem.Text = "Off";
            this.startUpSoundOffToolStripMenuItem.Click += new System.EventHandler(this.startUpSoundOffToolStripMenuItem_Click);
            // 
            // SysInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(479, 222);
            this.Controls.Add(this.resetInfoButton);
            this.Controls.Add(this.saveInfoButton);
            this.Controls.Add(this.getInfoButton);
            this.Controls.Add(this.sysInfoListView);
            this.Controls.Add(this.mainMenu);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "SysInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Info BETA";
            this.Load += new System.EventHandler(this.SysInfoForm_Load);
            this.listItemsContexMenu.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView sysInfoListView;
        private System.Windows.Forms.Button getInfoButton;
        private System.Windows.Forms.Button saveInfoButton;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.Button resetInfoButton;
        private System.Windows.Forms.ContextMenuStrip listItemsContexMenu;
        private System.Windows.Forms.ToolStripMenuItem viewOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishUnitedStatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulgarianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startupSoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startUpSoundOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startUpSoundOffToolStripMenuItem;
    }
}

