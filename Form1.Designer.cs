namespace Astroidinator_SDE2025_Jkra
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrMain_TickJkra = new System.Windows.Forms.Timer(this.components);
            this.menuStripJkra = new System.Windows.Forms.MenuStrip();
            this.mspFindFileJkra = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripViewJkra = new System.Windows.Forms.ToolStripMenuItem();
            this.mspStarscreenViewJkra = new System.Windows.Forms.ToolStripMenuItem();
            this.mspSeriaclCommsJkra = new System.Windows.Forms.ToolStripMenuItem();
            this.mspGameViewJkra = new System.Windows.Forms.ToolStripMenuItem();
            this.mspGameSettingsViewJkra = new System.Windows.Forms.ToolStripMenuItem();
            this.mspArduinoConnectViewJkra = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripHelpJkra = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mspAboutGameJkra = new System.Windows.Forms.ToolStripMenuItem();
            this.mspAboutDesignJkra = new System.Windows.Forms.ToolStripMenuItem();
            this.mspGuideJkra = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StartscreenJkra = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gamePanelJkra = new Astroidinator_SDE2025_Jkra.GamePanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbBrotherhoodArchiveJkra = new System.Windows.Forms.RichTextBox();
            this.checkboxEnableMusicjkra = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkboxRoundTwoJkra = new System.Windows.Forms.CheckBox();
            this.pictureBox3Design = new System.Windows.Forms.PictureBox();
            this.pictureBox2Design = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGameDifficultyJkra = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LoggingGroupBoxJkra = new System.Windows.Forms.GroupBox();
            this.rtbLoggingArduConnectJkra = new System.Windows.Forms.RichTextBox();
            this.gbxArduinoConnectJkra = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1Design = new System.Windows.Forms.PictureBox();
            this.cbxArduPortJkra = new System.Windows.Forms.ComboBox();
            this.cbxArduinoBaudrateJkra = new System.Windows.Forms.ComboBox();
            this.btnAboutArduConnectJkra = new System.Windows.Forms.Button();
            this.checkboxCarriageReturnJkra = new System.Windows.Forms.CheckBox();
            this.btnOpenPortJkra = new System.Windows.Forms.Button();
            this.checkboxRemoveLastCharacterJkra = new System.Windows.Forms.CheckBox();
            this.btnCleanBufferJkra = new System.Windows.Forms.Button();
            this.checkboxNewLineJkra = new System.Windows.Forms.CheckBox();
            this.btnScanPortJkra = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtbSerialCommsJkra = new System.Windows.Forms.RichTextBox();
            this.checkboxLineNumberingSerialCommsJkra = new System.Windows.Forms.CheckBox();
            this.btnClearSerialCommsJkra = new System.Windows.Forms.Button();
            this.checkboxAutoScrollSerialCommsJkra = new System.Windows.Forms.CheckBox();
            this.arduSerialPortCheckJkra = new System.IO.Ports.SerialPort(this.components);
            this.menuStripJkra.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3Design)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Design)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.LoggingGroupBoxJkra.SuspendLayout();
            this.gbxArduinoConnectJkra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Design)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrMain_TickJkra
            // 
            this.tmrMain_TickJkra.Enabled = true;
            this.tmrMain_TickJkra.Interval = 16;
            this.tmrMain_TickJkra.Tick += new System.EventHandler(this.tmrMain_TickJkra_Tick);
            // 
            // menuStripJkra
            // 
            this.menuStripJkra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mspFindFileJkra,
            this.editToolStripMenuItem,
            this.viewToolStripViewJkra,
            this.helpToolStripHelpJkra,
            this.aboutToolStripMenuItem});
            this.menuStripJkra.Location = new System.Drawing.Point(0, 0);
            this.menuStripJkra.Name = "menuStripJkra";
            this.menuStripJkra.Size = new System.Drawing.Size(800, 24);
            this.menuStripJkra.TabIndex = 0;
            this.menuStripJkra.Text = "menuStrip1";
            // 
            // mspFindFileJkra
            // 
            this.mspFindFileJkra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locationToolStripMenuItem});
            this.mspFindFileJkra.Name = "mspFindFileJkra";
            this.mspFindFileJkra.Size = new System.Drawing.Size(35, 20);
            this.mspFindFileJkra.Text = "file";
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.locationToolStripMenuItem.Text = "location";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "edit";
            // 
            // viewToolStripViewJkra
            // 
            this.viewToolStripViewJkra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mspStarscreenViewJkra,
            this.mspSeriaclCommsJkra,
            this.mspGameViewJkra,
            this.mspGameSettingsViewJkra,
            this.mspArduinoConnectViewJkra});
            this.viewToolStripViewJkra.Name = "viewToolStripViewJkra";
            this.viewToolStripViewJkra.Size = new System.Drawing.Size(43, 20);
            this.viewToolStripViewJkra.Text = "view";
            // 
            // mspStarscreenViewJkra
            // 
            this.mspStarscreenViewJkra.Name = "mspStarscreenViewJkra";
            this.mspStarscreenViewJkra.Size = new System.Drawing.Size(189, 22);
            this.mspStarscreenViewJkra.Text = "Sartscreen";
            this.mspStarscreenViewJkra.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // mspSeriaclCommsJkra
            // 
            this.mspSeriaclCommsJkra.Name = "mspSeriaclCommsJkra";
            this.mspSeriaclCommsJkra.Size = new System.Drawing.Size(189, 22);
            this.mspSeriaclCommsJkra.Text = "serial communication";
            this.mspSeriaclCommsJkra.Click += new System.EventHandler(this.serialCommunicationToolStripMenuItem_Click);
            // 
            // mspGameViewJkra
            // 
            this.mspGameViewJkra.Name = "mspGameViewJkra";
            this.mspGameViewJkra.Size = new System.Drawing.Size(189, 22);
            this.mspGameViewJkra.Text = "game";
            this.mspGameViewJkra.Click += new System.EventHandler(this.gameToolStripMenuItem_Click);
            // 
            // mspGameSettingsViewJkra
            // 
            this.mspGameSettingsViewJkra.Name = "mspGameSettingsViewJkra";
            this.mspGameSettingsViewJkra.Size = new System.Drawing.Size(189, 22);
            this.mspGameSettingsViewJkra.Text = "game settings";
            this.mspGameSettingsViewJkra.Click += new System.EventHandler(this.gameSettingsToolStripMenuItem_Click);
            // 
            // mspArduinoConnectViewJkra
            // 
            this.mspArduinoConnectViewJkra.Name = "mspArduinoConnectViewJkra";
            this.mspArduinoConnectViewJkra.Size = new System.Drawing.Size(189, 22);
            this.mspArduinoConnectViewJkra.Text = "Arduino Connection";
            this.mspArduinoConnectViewJkra.Click += new System.EventHandler(this.arduinoConnectionToolStripMenuItem_Click);
            // 
            // helpToolStripHelpJkra
            // 
            this.helpToolStripHelpJkra.Name = "helpToolStripHelpJkra";
            this.helpToolStripHelpJkra.Size = new System.Drawing.Size(42, 20);
            this.helpToolStripHelpJkra.Text = "help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mspAboutGameJkra,
            this.mspAboutDesignJkra,
            this.mspGuideJkra});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.aboutToolStripMenuItem.Text = "about";
            // 
            // mspAboutGameJkra
            // 
            this.mspAboutGameJkra.Name = "mspAboutGameJkra";
            this.mspAboutGameJkra.Size = new System.Drawing.Size(143, 22);
            this.mspAboutGameJkra.Text = "about game";
            // 
            // mspAboutDesignJkra
            // 
            this.mspAboutDesignJkra.Name = "mspAboutDesignJkra";
            this.mspAboutDesignJkra.Size = new System.Drawing.Size(143, 22);
            this.mspAboutDesignJkra.Text = "about design";
            // 
            // mspGuideJkra
            // 
            this.mspGuideJkra.Name = "mspGuideJkra";
            this.mspGuideJkra.Size = new System.Drawing.Size(143, 22);
            this.mspGuideJkra.Text = "guide";
            this.mspGuideJkra.Click += new System.EventHandler(this.mspGuideJkra_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.StartscreenJkra);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 411);
            this.tabControl1.TabIndex = 3;
            // 
            // StartscreenJkra
            // 
            this.StartscreenJkra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartscreenJkra.BackgroundImage")));
            this.StartscreenJkra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartscreenJkra.Location = new System.Drawing.Point(4, 22);
            this.StartscreenJkra.Name = "StartscreenJkra";
            this.StartscreenJkra.Padding = new System.Windows.Forms.Padding(3);
            this.StartscreenJkra.Size = new System.Drawing.Size(768, 385);
            this.StartscreenJkra.TabIndex = 0;
            this.StartscreenJkra.Text = "Startscreen";
            this.StartscreenJkra.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.gamePanelJkra);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Game";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gamePanelJkra
            // 
            this.gamePanelJkra.Location = new System.Drawing.Point(3, 3);
            this.gamePanelJkra.Name = "gamePanelJkra";
            this.gamePanelJkra.Size = new System.Drawing.Size(759, 382);
            this.gamePanelJkra.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.rtbBrotherhoodArchiveJkra);
            this.tabPage1.Controls.Add(this.checkboxEnableMusicjkra);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.checkboxRoundTwoJkra);
            this.tabPage1.Controls.Add(this.pictureBox3Design);
            this.tabPage1.Controls.Add(this.pictureBox2Design);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbxGameDifficultyJkra);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 385);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Game Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(6, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Brotherhood Archive";
            // 
            // rtbBrotherhoodArchiveJkra
            // 
            this.rtbBrotherhoodArchiveJkra.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.rtbBrotherhoodArchiveJkra.Location = new System.Drawing.Point(6, 154);
            this.rtbBrotherhoodArchiveJkra.Name = "rtbBrotherhoodArchiveJkra";
            this.rtbBrotherhoodArchiveJkra.Size = new System.Drawing.Size(213, 225);
            this.rtbBrotherhoodArchiveJkra.TabIndex = 17;
            this.rtbBrotherhoodArchiveJkra.Text = "";
            // 
            // checkboxEnableMusicjkra
            // 
            this.checkboxEnableMusicjkra.AutoSize = true;
            this.checkboxEnableMusicjkra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxEnableMusicjkra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkboxEnableMusicjkra.Location = new System.Drawing.Point(117, 60);
            this.checkboxEnableMusicjkra.Name = "checkboxEnableMusicjkra";
            this.checkboxEnableMusicjkra.Size = new System.Drawing.Size(102, 17);
            this.checkboxEnableMusicjkra.TabIndex = 15;
            this.checkboxEnableMusicjkra.Text = "Enable Music";
            this.checkboxEnableMusicjkra.UseVisualStyleBackColor = true;
            this.checkboxEnableMusicjkra.CheckedChanged += new System.EventHandler(this.checkboxEnableMusicjkra_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(114, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "music";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Round 2";
            // 
            // checkboxRoundTwoJkra
            // 
            this.checkboxRoundTwoJkra.AutoSize = true;
            this.checkboxRoundTwoJkra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxRoundTwoJkra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkboxRoundTwoJkra.Location = new System.Drawing.Point(6, 60);
            this.checkboxRoundTwoJkra.Name = "checkboxRoundTwoJkra";
            this.checkboxRoundTwoJkra.Size = new System.Drawing.Size(111, 17);
            this.checkboxRoundTwoJkra.TabIndex = 4;
            this.checkboxRoundTwoJkra.Text = "round 2 enable";
            this.checkboxRoundTwoJkra.UseVisualStyleBackColor = true;
            // 
            // pictureBox3Design
            // 
            this.pictureBox3Design.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3Design.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3Design.Image")));
            this.pictureBox3Design.Location = new System.Drawing.Point(485, 179);
            this.pictureBox3Design.Name = "pictureBox3Design";
            this.pictureBox3Design.Size = new System.Drawing.Size(142, 206);
            this.pictureBox3Design.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3Design.TabIndex = 3;
            this.pictureBox3Design.TabStop = false;
            // 
            // pictureBox2Design
            // 
            this.pictureBox2Design.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2Design.BackgroundImage")));
            this.pictureBox2Design.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2Design.Location = new System.Drawing.Point(633, 179);
            this.pictureBox2Design.Name = "pictureBox2Design";
            this.pictureBox2Design.Size = new System.Drawing.Size(135, 206);
            this.pictureBox2Design.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2Design.TabIndex = 2;
            this.pictureBox2Design.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "difficulty setting / Data Base";
            // 
            // cbxGameDifficultyJkra
            // 
            this.cbxGameDifficultyJkra.FormattingEnabled = true;
            this.cbxGameDifficultyJkra.Items.AddRange(new object[] {
            "General Lee Oliver",
            "Colonel Cassandra Moore",
            "Decanus Aurelius of Pheonix",
            "Legate Malpais",
            "Caesar",
            "Robert Edwin House",
            "Civilian Aaron Kimball",
            "New Vegas",
            "Hoover Dam",
            "Helios One",
            "Legion",
            "NCR"});
            this.cbxGameDifficultyJkra.Location = new System.Drawing.Point(6, 20);
            this.cbxGameDifficultyJkra.Name = "cbxGameDifficultyJkra";
            this.cbxGameDifficultyJkra.Size = new System.Drawing.Size(121, 21);
            this.cbxGameDifficultyJkra.TabIndex = 19;
            this.cbxGameDifficultyJkra.SelectedIndexChanged += new System.EventHandler(this.cbxGameDifficultyJkra_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LoggingGroupBoxJkra);
            this.tabPage3.Controls.Add(this.gbxArduinoConnectJkra);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 385);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Arduino Connection";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LoggingGroupBoxJkra
            // 
            this.LoggingGroupBoxJkra.Controls.Add(this.rtbLoggingArduConnectJkra);
            this.LoggingGroupBoxJkra.Location = new System.Drawing.Point(213, 6);
            this.LoggingGroupBoxJkra.Name = "LoggingGroupBoxJkra";
            this.LoggingGroupBoxJkra.Size = new System.Drawing.Size(549, 373);
            this.LoggingGroupBoxJkra.TabIndex = 1;
            this.LoggingGroupBoxJkra.TabStop = false;
            this.LoggingGroupBoxJkra.Text = "Logging";
            // 
            // rtbLoggingArduConnectJkra
            // 
            this.rtbLoggingArduConnectJkra.Location = new System.Drawing.Point(6, 19);
            this.rtbLoggingArduConnectJkra.Name = "rtbLoggingArduConnectJkra";
            this.rtbLoggingArduConnectJkra.Size = new System.Drawing.Size(537, 354);
            this.rtbLoggingArduConnectJkra.TabIndex = 0;
            this.rtbLoggingArduConnectJkra.Text = "";
            // 
            // gbxArduinoConnectJkra
            // 
            this.gbxArduinoConnectJkra.Controls.Add(this.label4);
            this.gbxArduinoConnectJkra.Controls.Add(this.label3);
            this.gbxArduinoConnectJkra.Controls.Add(this.label2);
            this.gbxArduinoConnectJkra.Controls.Add(this.pictureBox1Design);
            this.gbxArduinoConnectJkra.Controls.Add(this.cbxArduPortJkra);
            this.gbxArduinoConnectJkra.Controls.Add(this.cbxArduinoBaudrateJkra);
            this.gbxArduinoConnectJkra.Controls.Add(this.btnAboutArduConnectJkra);
            this.gbxArduinoConnectJkra.Controls.Add(this.checkboxCarriageReturnJkra);
            this.gbxArduinoConnectJkra.Controls.Add(this.btnOpenPortJkra);
            this.gbxArduinoConnectJkra.Controls.Add(this.checkboxRemoveLastCharacterJkra);
            this.gbxArduinoConnectJkra.Controls.Add(this.btnCleanBufferJkra);
            this.gbxArduinoConnectJkra.Controls.Add(this.checkboxNewLineJkra);
            this.gbxArduinoConnectJkra.Controls.Add(this.btnScanPortJkra);
            this.gbxArduinoConnectJkra.Location = new System.Drawing.Point(3, 6);
            this.gbxArduinoConnectJkra.Name = "gbxArduinoConnectJkra";
            this.gbxArduinoConnectJkra.Size = new System.Drawing.Size(204, 373);
            this.gbxArduinoConnectJkra.TabIndex = 0;
            this.gbxArduinoConnectJkra.TabStop = false;
            this.gbxArduinoConnectJkra.Text = "Arduino Connection";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "line ending inTx data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Arduino Baudrate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "port";
            // 
            // pictureBox1Design
            // 
            this.pictureBox1Design.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1Design.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1Design.Image")));
            this.pictureBox1Design.Location = new System.Drawing.Point(80, 199);
            this.pictureBox1Design.Name = "pictureBox1Design";
            this.pictureBox1Design.Size = new System.Drawing.Size(119, 168);
            this.pictureBox1Design.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1Design.TabIndex = 9;
            this.pictureBox1Design.TabStop = false;
            // 
            // cbxArduPortJkra
            // 
            this.cbxArduPortJkra.FormattingEnabled = true;
            this.cbxArduPortJkra.Location = new System.Drawing.Point(80, 126);
            this.cbxArduPortJkra.Name = "cbxArduPortJkra";
            this.cbxArduPortJkra.Size = new System.Drawing.Size(121, 21);
            this.cbxArduPortJkra.TabIndex = 8;
            this.cbxArduPortJkra.SelectedIndexChanged += new System.EventHandler(this.cbxArduPortJkra_SelectedIndexChanged);
            // 
            // cbxArduinoBaudrateJkra
            // 
            this.cbxArduinoBaudrateJkra.FormattingEnabled = true;
            this.cbxArduinoBaudrateJkra.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cbxArduinoBaudrateJkra.Location = new System.Drawing.Point(80, 172);
            this.cbxArduinoBaudrateJkra.Name = "cbxArduinoBaudrateJkra";
            this.cbxArduinoBaudrateJkra.Size = new System.Drawing.Size(121, 21);
            this.cbxArduinoBaudrateJkra.TabIndex = 7;
            this.cbxArduinoBaudrateJkra.SelectedIndexChanged += new System.EventHandler(this.cbxArduinoBaudrateJkra_SelectedIndexChanged);
            // 
            // btnAboutArduConnectJkra
            // 
            this.btnAboutArduConnectJkra.Location = new System.Drawing.Point(3, 97);
            this.btnAboutArduConnectJkra.Name = "btnAboutArduConnectJkra";
            this.btnAboutArduConnectJkra.Size = new System.Drawing.Size(75, 23);
            this.btnAboutArduConnectJkra.TabIndex = 6;
            this.btnAboutArduConnectJkra.Text = "About";
            this.btnAboutArduConnectJkra.UseVisualStyleBackColor = true;
            this.btnAboutArduConnectJkra.Click += new System.EventHandler(this.btnAboutArduConnectJkra_Click);
            // 
            // checkboxCarriageReturnJkra
            // 
            this.checkboxCarriageReturnJkra.AutoSize = true;
            this.checkboxCarriageReturnJkra.Location = new System.Drawing.Point(93, 54);
            this.checkboxCarriageReturnJkra.Name = "checkboxCarriageReturnJkra";
            this.checkboxCarriageReturnJkra.Size = new System.Drawing.Size(105, 17);
            this.checkboxCarriageReturnJkra.TabIndex = 5;
            this.checkboxCarriageReturnJkra.Text = "carriage return \\r";
            this.checkboxCarriageReturnJkra.UseVisualStyleBackColor = true;
            this.checkboxCarriageReturnJkra.CheckedChanged += new System.EventHandler(this.checkboxCarriageReturnJkra_CheckedChanged);
            // 
            // btnOpenPortJkra
            // 
            this.btnOpenPortJkra.Location = new System.Drawing.Point(3, 68);
            this.btnOpenPortJkra.Name = "btnOpenPortJkra";
            this.btnOpenPortJkra.Size = new System.Drawing.Size(75, 23);
            this.btnOpenPortJkra.TabIndex = 4;
            this.btnOpenPortJkra.Text = "Open Port";
            this.btnOpenPortJkra.UseVisualStyleBackColor = true;
            this.btnOpenPortJkra.Click += new System.EventHandler(this.btnOpenPortJkra_Click);
            // 
            // checkboxRemoveLastCharacterJkra
            // 
            this.checkboxRemoveLastCharacterJkra.AutoSize = true;
            this.checkboxRemoveLastCharacterJkra.Location = new System.Drawing.Point(65, 19);
            this.checkboxRemoveLastCharacterJkra.Name = "checkboxRemoveLastCharacterJkra";
            this.checkboxRemoveLastCharacterJkra.Size = new System.Drawing.Size(133, 17);
            this.checkboxRemoveLastCharacterJkra.TabIndex = 3;
            this.checkboxRemoveLastCharacterJkra.Text = "Remove last character";
            this.checkboxRemoveLastCharacterJkra.UseVisualStyleBackColor = true;
            this.checkboxRemoveLastCharacterJkra.CheckedChanged += new System.EventHandler(this.checkboxRemoveLastCharacterJkra_CheckedChanged);
            // 
            // btnCleanBufferJkra
            // 
            this.btnCleanBufferJkra.Location = new System.Drawing.Point(80, 97);
            this.btnCleanBufferJkra.Name = "btnCleanBufferJkra";
            this.btnCleanBufferJkra.Size = new System.Drawing.Size(124, 23);
            this.btnCleanBufferJkra.TabIndex = 2;
            this.btnCleanBufferJkra.Text = "Clean out buffer";
            this.btnCleanBufferJkra.UseVisualStyleBackColor = true;
            this.btnCleanBufferJkra.Click += new System.EventHandler(this.btnCleanBufferJkra_Click);
            // 
            // checkboxNewLineJkra
            // 
            this.checkboxNewLineJkra.AutoSize = true;
            this.checkboxNewLineJkra.Location = new System.Drawing.Point(93, 74);
            this.checkboxNewLineJkra.Name = "checkboxNewLineJkra";
            this.checkboxNewLineJkra.Size = new System.Drawing.Size(81, 17);
            this.checkboxNewLineJkra.TabIndex = 1;
            this.checkboxNewLineJkra.Text = "New line \\n";
            this.checkboxNewLineJkra.UseVisualStyleBackColor = true;
            this.checkboxNewLineJkra.CheckedChanged += new System.EventHandler(this.checkboxNewLineJkra_CheckedChanged);
            // 
            // btnScanPortJkra
            // 
            this.btnScanPortJkra.Location = new System.Drawing.Point(3, 39);
            this.btnScanPortJkra.Name = "btnScanPortJkra";
            this.btnScanPortJkra.Size = new System.Drawing.Size(75, 23);
            this.btnScanPortJkra.TabIndex = 0;
            this.btnScanPortJkra.Text = "Scan Port";
            this.btnScanPortJkra.UseVisualStyleBackColor = true;
            this.btnScanPortJkra.Click += new System.EventHandler(this.btnScanPortJkra_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rtbSerialCommsJkra);
            this.tabPage4.Controls.Add(this.checkboxLineNumberingSerialCommsJkra);
            this.tabPage4.Controls.Add(this.btnClearSerialCommsJkra);
            this.tabPage4.Controls.Add(this.checkboxAutoScrollSerialCommsJkra);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 385);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Serial Communication";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rtbSerialCommsJkra
            // 
            this.rtbSerialCommsJkra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rtbSerialCommsJkra.Location = new System.Drawing.Point(3, 7);
            this.rtbSerialCommsJkra.Name = "rtbSerialCommsJkra";
            this.rtbSerialCommsJkra.Size = new System.Drawing.Size(750, 346);
            this.rtbSerialCommsJkra.TabIndex = 3;
            this.rtbSerialCommsJkra.Text = "";
            // 
            // checkboxLineNumberingSerialCommsJkra
            // 
            this.checkboxLineNumberingSerialCommsJkra.AutoSize = true;
            this.checkboxLineNumberingSerialCommsJkra.Location = new System.Drawing.Point(92, 362);
            this.checkboxLineNumberingSerialCommsJkra.Name = "checkboxLineNumberingSerialCommsJkra";
            this.checkboxLineNumberingSerialCommsJkra.Size = new System.Drawing.Size(100, 17);
            this.checkboxLineNumberingSerialCommsJkra.TabIndex = 2;
            this.checkboxLineNumberingSerialCommsJkra.Text = "Line Numbering";
            this.checkboxLineNumberingSerialCommsJkra.UseVisualStyleBackColor = true;
            // 
            // btnClearSerialCommsJkra
            // 
            this.btnClearSerialCommsJkra.Location = new System.Drawing.Point(678, 359);
            this.btnClearSerialCommsJkra.Name = "btnClearSerialCommsJkra";
            this.btnClearSerialCommsJkra.Size = new System.Drawing.Size(75, 23);
            this.btnClearSerialCommsJkra.TabIndex = 1;
            this.btnClearSerialCommsJkra.Text = "clear";
            this.btnClearSerialCommsJkra.UseVisualStyleBackColor = true;
            this.btnClearSerialCommsJkra.Click += new System.EventHandler(this.btnClearSerialCommsJkra_Click);
            // 
            // checkboxAutoScrollSerialCommsJkra
            // 
            this.checkboxAutoScrollSerialCommsJkra.AutoSize = true;
            this.checkboxAutoScrollSerialCommsJkra.Location = new System.Drawing.Point(6, 362);
            this.checkboxAutoScrollSerialCommsJkra.Name = "checkboxAutoScrollSerialCommsJkra";
            this.checkboxAutoScrollSerialCommsJkra.Size = new System.Drawing.Size(77, 17);
            this.checkboxAutoScrollSerialCommsJkra.TabIndex = 0;
            this.checkboxAutoScrollSerialCommsJkra.Text = "Auto Scroll";
            this.checkboxAutoScrollSerialCommsJkra.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStripJkra);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripJkra;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripJkra.ResumeLayout(false);
            this.menuStripJkra.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3Design)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Design)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.LoggingGroupBoxJkra.ResumeLayout(false);
            this.gbxArduinoConnectJkra.ResumeLayout(false);
            this.gbxArduinoConnectJkra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Design)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrMain_TickJkra;
        private System.Windows.Forms.MenuStrip menuStripJkra;
        private System.Windows.Forms.ToolStripMenuItem mspFindFileJkra;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripViewJkra;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripHelpJkra;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mspAboutGameJkra;
        private System.Windows.Forms.ToolStripMenuItem mspAboutDesignJkra;
        private System.Windows.Forms.ToolStripMenuItem mspStarscreenViewJkra;
        private System.Windows.Forms.ToolStripMenuItem mspSeriaclCommsJkra;
        private System.Windows.Forms.ToolStripMenuItem mspGameViewJkra;
        private System.Windows.Forms.ToolStripMenuItem mspGuideJkra;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage StartscreenJkra;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxGameDifficultyJkra;
        private System.Windows.Forms.GroupBox LoggingGroupBoxJkra;
        private System.Windows.Forms.RichTextBox rtbLoggingArduConnectJkra;
        private System.Windows.Forms.GroupBox gbxArduinoConnectJkra;
        private System.Windows.Forms.ComboBox cbxArduPortJkra;
        private System.Windows.Forms.ComboBox cbxArduinoBaudrateJkra;
        private System.Windows.Forms.Button btnAboutArduConnectJkra;
        private System.Windows.Forms.CheckBox checkboxCarriageReturnJkra;
        private System.Windows.Forms.Button btnOpenPortJkra;
        private System.Windows.Forms.CheckBox checkboxRemoveLastCharacterJkra;
        private System.Windows.Forms.Button btnCleanBufferJkra;
        private System.Windows.Forms.CheckBox checkboxNewLineJkra;
        private System.Windows.Forms.Button btnScanPortJkra;
        private System.Windows.Forms.PictureBox pictureBox1Design;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem mspGameSettingsViewJkra;
        private System.Windows.Forms.ToolStripMenuItem mspArduinoConnectViewJkra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkboxRoundTwoJkra;
        private System.Windows.Forms.PictureBox pictureBox3Design;
        private System.Windows.Forms.PictureBox pictureBox2Design;
        private System.Windows.Forms.RichTextBox rtbSerialCommsJkra;
        private System.Windows.Forms.CheckBox checkboxLineNumberingSerialCommsJkra;
        private System.Windows.Forms.Button btnClearSerialCommsJkra;
        private System.Windows.Forms.CheckBox checkboxAutoScrollSerialCommsJkra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkboxEnableMusicjkra;
        private System.IO.Ports.SerialPort arduSerialPortCheckJkra;
        private GamePanel gamePanelJkra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbBrotherhoodArchiveJkra;
    }
}

