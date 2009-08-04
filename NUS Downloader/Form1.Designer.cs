﻿namespace NUS_Downloader
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
            this.TMDButton = new System.Windows.Forms.Button();
            this.titleidbox = new System.Windows.Forms.TextBox();
            this.downloadstartbtn = new System.Windows.Forms.Button();
            this.statusbox = new System.Windows.Forms.TextBox();
            this.packbox = new System.Windows.Forms.CheckBox();
            this.dlprogress = new System.Windows.Forms.ProgressBar();
            this.localuse = new System.Windows.Forms.CheckBox();
            this.NUSDownloader = new System.ComponentModel.BackgroundWorker();
            this.titleversion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.getcerts = new System.Windows.Forms.Button();
            this.wadnamebox = new System.Windows.Forms.TextBox();
            this.ignoreticket = new System.Windows.Forms.CheckBox();
            this.decryptbox = new System.Windows.Forms.CheckBox();
            this.databaseButton = new System.Windows.Forms.Button();
            this.databaseStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SystemMenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.IOSMenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.VCMenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.C64MenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.GenesisMenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.MSXMenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.N64MenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.NeoGeoMenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.NESMenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.SegaMSMenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.SNESMenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.TurboGrafx16MenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.TurboGrafxCDMenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.VCArcadeMenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.WiiWareMenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RegionCodesList = new System.Windows.Forms.ToolStripMenuItem();
            this.truchabox = new System.Windows.Forms.CheckBox();
            this.tmdgpbox = new System.Windows.Forms.GroupBox();
            this.tmdversiontrucha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newtitleidbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.requiredIOSbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ticketgpbox = new System.Windows.Forms.GroupBox();
            this.timelimitsecs = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.timelimitenabledcb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ckeyindexcb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dlcamntbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.titleIDIV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.titlekeybox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.shamelessvariablelabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.contentsEdit = new System.Windows.Forms.ListBox();
            this.contentModBox = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button17 = new System.Windows.Forms.Button();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.updateDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseStrip.SuspendLayout();
            this.tmdgpbox.SuspendLayout();
            this.ticketgpbox.SuspendLayout();
            this.contentModBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TMDButton
            // 
            this.TMDButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TMDButton.Location = new System.Drawing.Point(128, 12);
            this.TMDButton.Name = "TMDButton";
            this.TMDButton.Size = new System.Drawing.Size(50, 20);
            this.TMDButton.TabIndex = 0;
            this.TMDButton.Text = "TMD...";
            this.TMDButton.UseVisualStyleBackColor = true;
            this.TMDButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleidbox
            // 
            this.titleidbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleidbox.Location = new System.Drawing.Point(12, 38);
            this.titleidbox.MaxLength = 16;
            this.titleidbox.Name = "titleidbox";
            this.titleidbox.Size = new System.Drawing.Size(176, 20);
            this.titleidbox.TabIndex = 2;
            this.titleidbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titleidbox.TextChanged += new System.EventHandler(this.titleidbox_TextChanged);
            // 
            // downloadstartbtn
            // 
            this.downloadstartbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downloadstartbtn.Location = new System.Drawing.Point(12, 64);
            this.downloadstartbtn.Name = "downloadstartbtn";
            this.downloadstartbtn.Size = new System.Drawing.Size(250, 25);
            this.downloadstartbtn.TabIndex = 4;
            this.downloadstartbtn.Text = "Start NUS Download!";
            this.downloadstartbtn.UseVisualStyleBackColor = true;
            this.downloadstartbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // statusbox
            // 
            this.statusbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusbox.Location = new System.Drawing.Point(12, 116);
            this.statusbox.Multiline = true;
            this.statusbox.Name = "statusbox";
            this.statusbox.Size = new System.Drawing.Size(250, 268);
            this.statusbox.TabIndex = 5;
            // 
            // packbox
            // 
            this.packbox.AutoSize = true;
            this.packbox.Location = new System.Drawing.Point(12, 422);
            this.packbox.Name = "packbox";
            this.packbox.Size = new System.Drawing.Size(92, 17);
            this.packbox.TabIndex = 6;
            this.packbox.Text = "Pack -> WAD";
            this.packbox.UseVisualStyleBackColor = true;
            this.packbox.CheckedChanged += new System.EventHandler(this.packbox_CheckedChanged);
            // 
            // dlprogress
            // 
            this.dlprogress.Location = new System.Drawing.Point(12, 95);
            this.dlprogress.Name = "dlprogress";
            this.dlprogress.Size = new System.Drawing.Size(250, 15);
            this.dlprogress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.dlprogress.TabIndex = 7;
            // 
            // localuse
            // 
            this.localuse.AutoSize = true;
            this.localuse.Checked = true;
            this.localuse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.localuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localuse.Location = new System.Drawing.Point(12, 468);
            this.localuse.Name = "localuse";
            this.localuse.Size = new System.Drawing.Size(167, 17);
            this.localuse.TabIndex = 8;
            this.localuse.Text = "Use/Keep Present Local Files";
            this.localuse.UseVisualStyleBackColor = true;
            // 
            // NUSDownloader
            // 
            this.NUSDownloader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.NUSDownloader_DoWork);
            // 
            // titleversion
            // 
            this.titleversion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleversion.Location = new System.Drawing.Point(204, 38);
            this.titleversion.MaxLength = 8;
            this.titleversion.Name = "titleversion";
            this.titleversion.Size = new System.Drawing.Size(58, 20);
            this.titleversion.TabIndex = 3;
            this.titleversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titleversion.TextChanged += new System.EventHandler(this.titleversion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(194, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "v";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter a Title ID Below:";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(154, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 20);
            this.button2.TabIndex = 14;
            this.button2.Text = "About";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // getcerts
            // 
            this.getcerts.BackColor = System.Drawing.Color.Bisque;
            this.getcerts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getcerts.Location = new System.Drawing.Point(48, 246);
            this.getcerts.Name = "getcerts";
            this.getcerts.Size = new System.Drawing.Size(176, 46);
            this.getcerts.TabIndex = 16;
            this.getcerts.Text = "Generate Certs";
            this.getcerts.UseVisualStyleBackColor = false;
            this.getcerts.Click += new System.EventHandler(this.getcerts_Click);
            // 
            // wadnamebox
            // 
            this.wadnamebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wadnamebox.Enabled = false;
            this.wadnamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wadnamebox.Location = new System.Drawing.Point(102, 421);
            this.wadnamebox.MaxLength = 99999;
            this.wadnamebox.Name = "wadnamebox";
            this.wadnamebox.Size = new System.Drawing.Size(160, 18);
            this.wadnamebox.TabIndex = 17;
            // 
            // ignoreticket
            // 
            this.ignoreticket.AutoSize = true;
            this.ignoreticket.Location = new System.Drawing.Point(12, 445);
            this.ignoreticket.Name = "ignoreticket";
            this.ignoreticket.Size = new System.Drawing.Size(135, 17);
            this.ignoreticket.TabIndex = 18;
            this.ignoreticket.Text = "Ignore Ticket if Missing";
            this.ignoreticket.UseVisualStyleBackColor = true;
            // 
            // decryptbox
            // 
            this.decryptbox.AutoSize = true;
            this.decryptbox.Location = new System.Drawing.Point(154, 445);
            this.decryptbox.Name = "decryptbox";
            this.decryptbox.Size = new System.Drawing.Size(108, 17);
            this.decryptbox.TabIndex = 19;
            this.decryptbox.Text = "Decrypt Contents";
            this.decryptbox.UseVisualStyleBackColor = true;
            // 
            // databaseButton
            // 
            this.databaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.databaseButton.Location = new System.Drawing.Point(184, 12);
            this.databaseButton.Name = "databaseButton";
            this.databaseButton.Size = new System.Drawing.Size(78, 20);
            this.databaseButton.TabIndex = 20;
            this.databaseButton.Text = "Database...";
            this.databaseButton.UseVisualStyleBackColor = true;
            this.databaseButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // databaseStrip
            // 
            this.databaseStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemMenuList,
            this.IOSMenuList,
            this.VCMenuList,
            this.WiiWareMenuList,
            this.toolStripSeparator1,
            this.RegionCodesList,
            this.toolStripSeparator2,
            this.updateDatabaseToolStripMenuItem});
            this.databaseStrip.Name = "databaseStrip";
            this.databaseStrip.ShowItemToolTips = false;
            this.databaseStrip.Size = new System.Drawing.Size(164, 170);
            // 
            // SystemMenuList
            // 
            this.SystemMenuList.AutoSize = false;
            this.SystemMenuList.Name = "SystemMenuList";
            this.SystemMenuList.Size = new System.Drawing.Size(154, 22);
            this.SystemMenuList.Text = "System";
            // 
            // IOSMenuList
            // 
            this.IOSMenuList.Name = "IOSMenuList";
            this.IOSMenuList.Size = new System.Drawing.Size(163, 22);
            this.IOSMenuList.Text = "IOS";
            // 
            // VCMenuList
            // 
            this.VCMenuList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.C64MenuList,
            this.GenesisMenuList,
            this.MSXMenuList,
            this.N64MenuList,
            this.NeoGeoMenuList,
            this.NESMenuList,
            this.SegaMSMenuList,
            this.SNESMenuList,
            this.TurboGrafx16MenuList,
            this.TurboGrafxCDMenuList,
            this.VCArcadeMenuList});
            this.VCMenuList.Name = "VCMenuList";
            this.VCMenuList.Size = new System.Drawing.Size(163, 22);
            this.VCMenuList.Text = "Virtual Console";
            // 
            // C64MenuList
            // 
            this.C64MenuList.Name = "C64MenuList";
            this.C64MenuList.Size = new System.Drawing.Size(194, 22);
            this.C64MenuList.Text = "Commodore 64";
            // 
            // GenesisMenuList
            // 
            this.GenesisMenuList.Name = "GenesisMenuList";
            this.GenesisMenuList.Size = new System.Drawing.Size(194, 22);
            this.GenesisMenuList.Text = "Mega Drive/Genesis";
            // 
            // MSXMenuList
            // 
            this.MSXMenuList.Name = "MSXMenuList";
            this.MSXMenuList.Size = new System.Drawing.Size(194, 22);
            this.MSXMenuList.Text = "MSX";
            // 
            // N64MenuList
            // 
            this.N64MenuList.Name = "N64MenuList";
            this.N64MenuList.Size = new System.Drawing.Size(194, 22);
            this.N64MenuList.Text = "Nintendo 64";
            // 
            // NeoGeoMenuList
            // 
            this.NeoGeoMenuList.Name = "NeoGeoMenuList";
            this.NeoGeoMenuList.Size = new System.Drawing.Size(194, 22);
            this.NeoGeoMenuList.Text = "NeoGeo";
            // 
            // NESMenuList
            // 
            this.NESMenuList.Name = "NESMenuList";
            this.NESMenuList.Size = new System.Drawing.Size(194, 22);
            this.NESMenuList.Text = "NES";
            // 
            // SegaMSMenuList
            // 
            this.SegaMSMenuList.Name = "SegaMSMenuList";
            this.SegaMSMenuList.Size = new System.Drawing.Size(194, 22);
            this.SegaMSMenuList.Text = "Sega Master System";
            // 
            // SNESMenuList
            // 
            this.SNESMenuList.Name = "SNESMenuList";
            this.SNESMenuList.Size = new System.Drawing.Size(194, 22);
            this.SNESMenuList.Text = "SNES";
            // 
            // TurboGrafx16MenuList
            // 
            this.TurboGrafx16MenuList.Name = "TurboGrafx16MenuList";
            this.TurboGrafx16MenuList.Size = new System.Drawing.Size(194, 22);
            this.TurboGrafx16MenuList.Text = "TruboGrafx-16";
            // 
            // TurboGrafxCDMenuList
            // 
            this.TurboGrafxCDMenuList.Name = "TurboGrafxCDMenuList";
            this.TurboGrafxCDMenuList.Size = new System.Drawing.Size(194, 22);
            this.TurboGrafxCDMenuList.Text = "TurboGrafx-CD";
            // 
            // VCArcadeMenuList
            // 
            this.VCArcadeMenuList.Name = "VCArcadeMenuList";
            this.VCArcadeMenuList.Size = new System.Drawing.Size(194, 22);
            this.VCArcadeMenuList.Text = "Virtual Console Arcade";
            // 
            // WiiWareMenuList
            // 
            this.WiiWareMenuList.Name = "WiiWareMenuList";
            this.WiiWareMenuList.Size = new System.Drawing.Size(163, 22);
            this.WiiWareMenuList.Text = "WiiWare";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // RegionCodesList
            // 
            this.RegionCodesList.Name = "RegionCodesList";
            this.RegionCodesList.Size = new System.Drawing.Size(163, 22);
            this.RegionCodesList.Text = "Region Codes";
            this.RegionCodesList.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.RegionCodesList_DropDownItemClicked);
            // 
            // truchabox
            // 
            this.truchabox.AutoSize = true;
            this.truchabox.Location = new System.Drawing.Point(184, 468);
            this.truchabox.Name = "truchabox";
            this.truchabox.Size = new System.Drawing.Size(60, 17);
            this.truchabox.TabIndex = 21;
            this.truchabox.Text = "Trucha";
            this.truchabox.UseVisualStyleBackColor = true;
            // 
            // tmdgpbox
            // 
            this.tmdgpbox.Controls.Add(this.tmdversiontrucha);
            this.tmdgpbox.Controls.Add(this.label5);
            this.tmdgpbox.Controls.Add(this.newtitleidbox);
            this.tmdgpbox.Controls.Add(this.label4);
            this.tmdgpbox.Controls.Add(this.requiredIOSbox);
            this.tmdgpbox.Controls.Add(this.label3);
            this.tmdgpbox.Location = new System.Drawing.Point(278, 12);
            this.tmdgpbox.Name = "tmdgpbox";
            this.tmdgpbox.Size = new System.Drawing.Size(249, 77);
            this.tmdgpbox.TabIndex = 22;
            this.tmdgpbox.TabStop = false;
            this.tmdgpbox.Text = "Fake (Trucha) TMD Signing...";
            // 
            // tmdversiontrucha
            // 
            this.tmdversiontrucha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tmdversiontrucha.Location = new System.Drawing.Point(181, 24);
            this.tmdversiontrucha.MaxLength = 6;
            this.tmdversiontrucha.Name = "tmdversiontrucha";
            this.tmdversiontrucha.Size = new System.Drawing.Size(62, 20);
            this.tmdversiontrucha.TabIndex = 5;
            this.tmdversiontrucha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Version:";
            // 
            // newtitleidbox
            // 
            this.newtitleidbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newtitleidbox.Location = new System.Drawing.Point(80, 50);
            this.newtitleidbox.MaxLength = 16;
            this.newtitleidbox.Name = "newtitleidbox";
            this.newtitleidbox.Size = new System.Drawing.Size(163, 20);
            this.newtitleidbox.TabIndex = 3;
            this.newtitleidbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "New Title ID:";
            // 
            // requiredIOSbox
            // 
            this.requiredIOSbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.requiredIOSbox.Location = new System.Drawing.Point(80, 24);
            this.requiredIOSbox.MaxLength = 3;
            this.requiredIOSbox.Name = "requiredIOSbox";
            this.requiredIOSbox.Size = new System.Drawing.Size(44, 20);
            this.requiredIOSbox.TabIndex = 1;
            this.requiredIOSbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Requires IOS:";
            // 
            // ticketgpbox
            // 
            this.ticketgpbox.Controls.Add(this.timelimitsecs);
            this.ticketgpbox.Controls.Add(this.label11);
            this.ticketgpbox.Controls.Add(this.timelimitenabledcb);
            this.ticketgpbox.Controls.Add(this.label10);
            this.ticketgpbox.Controls.Add(this.ckeyindexcb);
            this.ticketgpbox.Controls.Add(this.label9);
            this.ticketgpbox.Controls.Add(this.dlcamntbox);
            this.ticketgpbox.Controls.Add(this.label8);
            this.ticketgpbox.Controls.Add(this.titleIDIV);
            this.ticketgpbox.Controls.Add(this.label7);
            this.ticketgpbox.Controls.Add(this.titlekeybox);
            this.ticketgpbox.Controls.Add(this.label6);
            this.ticketgpbox.Location = new System.Drawing.Point(278, 127);
            this.ticketgpbox.Name = "ticketgpbox";
            this.ticketgpbox.Size = new System.Drawing.Size(249, 180);
            this.ticketgpbox.TabIndex = 23;
            this.ticketgpbox.TabStop = false;
            this.ticketgpbox.Text = "Fake (Trucha) Ticket Signing...";
            // 
            // timelimitsecs
            // 
            this.timelimitsecs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timelimitsecs.Location = new System.Drawing.Point(95, 99);
            this.timelimitsecs.MaxLength = 10;
            this.timelimitsecs.Name = "timelimitsecs";
            this.timelimitsecs.Size = new System.Drawing.Size(148, 20);
            this.timelimitsecs.TabIndex = 15;
            this.timelimitsecs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Time (Seconds):";
            // 
            // timelimitenabledcb
            // 
            this.timelimitenabledcb.FormattingEnabled = true;
            this.timelimitenabledcb.Items.AddRange(new object[] {
            "0 - Disabled",
            "1 - Enabled"});
            this.timelimitenabledcb.Location = new System.Drawing.Point(95, 72);
            this.timelimitenabledcb.Name = "timelimitenabledcb";
            this.timelimitenabledcb.Size = new System.Drawing.Size(149, 21);
            this.timelimitenabledcb.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Time Limit:";
            // 
            // ckeyindexcb
            // 
            this.ckeyindexcb.FormattingEnabled = true;
            this.ckeyindexcb.Items.AddRange(new object[] {
            "0 - Standard Key",
            "1 - Korean Key"});
            this.ckeyindexcb.Location = new System.Drawing.Point(95, 45);
            this.ckeyindexcb.Name = "ckeyindexcb";
            this.ckeyindexcb.Size = new System.Drawing.Size(149, 21);
            this.ckeyindexcb.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Common Key:";
            // 
            // dlcamntbox
            // 
            this.dlcamntbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dlcamntbox.Location = new System.Drawing.Point(95, 19);
            this.dlcamntbox.MaxLength = 6;
            this.dlcamntbox.Name = "dlcamntbox";
            this.dlcamntbox.Size = new System.Drawing.Size(148, 20);
            this.dlcamntbox.TabIndex = 9;
            this.dlcamntbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Amount of DLC:";
            // 
            // titleIDIV
            // 
            this.titleIDIV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleIDIV.Location = new System.Drawing.Point(95, 151);
            this.titleIDIV.MaxLength = 16;
            this.titleIDIV.Name = "titleIDIV";
            this.titleIDIV.Size = new System.Drawing.Size(148, 20);
            this.titleIDIV.TabIndex = 7;
            this.titleIDIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Title ID / IV:";
            // 
            // titlekeybox
            // 
            this.titlekeybox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titlekeybox.Location = new System.Drawing.Point(95, 125);
            this.titlekeybox.MaxLength = 16;
            this.titlekeybox.Name = "titlekeybox";
            this.titlekeybox.Size = new System.Drawing.Size(148, 20);
            this.titlekeybox.TabIndex = 5;
            this.titlekeybox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Title Key:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(350, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 26);
            this.button1.TabIndex = 24;
            this.button1.Text = "Write Changes to TMD...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(350, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 26);
            this.button4.TabIndex = 25;
            this.button4.Text = "Write Changes to Ticket...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(278, 313);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 26);
            this.button5.TabIndex = 26;
            this.button5.Text = "Revert";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(278, 95);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 26);
            this.button6.TabIndex = 27;
            this.button6.Text = "Revert";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(278, 377);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(249, 33);
            this.button7.TabIndex = 28;
            this.button7.Text = "Finished with Trucha Changes...";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // shamelessvariablelabel
            // 
            this.shamelessvariablelabel.AutoSize = true;
            this.shamelessvariablelabel.Location = new System.Drawing.Point(285, 322);
            this.shamelessvariablelabel.Name = "shamelessvariablelabel";
            this.shamelessvariablelabel.Size = new System.Drawing.Size(0, 13);
            this.shamelessvariablelabel.TabIndex = 30;
            this.shamelessvariablelabel.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(213, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 27);
            this.button3.TabIndex = 31;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // contentsEdit
            // 
            this.contentsEdit.FormattingEnabled = true;
            this.contentsEdit.Location = new System.Drawing.Point(9, 19);
            this.contentsEdit.Name = "contentsEdit";
            this.contentsEdit.ScrollAlwaysVisible = true;
            this.contentsEdit.Size = new System.Drawing.Size(198, 173);
            this.contentsEdit.TabIndex = 32;
            // 
            // contentModBox
            // 
            this.contentModBox.Controls.Add(this.button16);
            this.contentModBox.Controls.Add(this.button13);
            this.contentModBox.Controls.Add(this.button15);
            this.contentModBox.Controls.Add(this.button14);
            this.contentModBox.Controls.Add(this.button12);
            this.contentModBox.Controls.Add(this.contentsEdit);
            this.contentModBox.Controls.Add(this.button8);
            this.contentModBox.Controls.Add(this.button11);
            this.contentModBox.Controls.Add(this.button9);
            this.contentModBox.Controls.Add(this.button10);
            this.contentModBox.Location = new System.Drawing.Point(268, 153);
            this.contentModBox.Name = "contentModBox";
            this.contentModBox.Size = new System.Drawing.Size(249, 327);
            this.contentModBox.TabIndex = 41;
            this.contentModBox.TabStop = false;
            this.contentModBox.Text = "Edit Title Contents";
            this.contentModBox.Visible = false;
            // 
            // button16
            // 
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.Image = global::NUS_Downloader.Properties.Resources.bug_add;
            this.button16.Location = new System.Drawing.Point(136, 198);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(26, 26);
            this.button16.TabIndex = 44;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button13
            // 
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Image = global::NUS_Downloader.Properties.Resources.link;
            this.button13.Location = new System.Drawing.Point(104, 198);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(26, 26);
            this.button13.TabIndex = 43;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button15
            // 
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Location = new System.Drawing.Point(9, 235);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(230, 26);
            this.button15.TabIndex = 42;
            this.button15.Text = "Revert";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Location = new System.Drawing.Point(9, 268);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(230, 50);
            this.button14.TabIndex = 41;
            this.button14.Text = "Overwrite Title Contents...";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.Location = new System.Drawing.Point(72, 198);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(26, 26);
            this.button12.TabIndex = 40;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(213, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(26, 26);
            this.button8.TabIndex = 33;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(9, 198);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(26, 26);
            this.button11.TabIndex = 36;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(213, 53);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(26, 26);
            this.button9.TabIndex = 34;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(41, 198);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(26, 26);
            this.button10.TabIndex = 35;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Image = ((System.Drawing.Image)(resources.GetObject("radioButton1.Image")));
            this.radioButton1.Location = new System.Drawing.Point(12, 385);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 31);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Image = ((System.Drawing.Image)(resources.GetObject("radioButton2.Image")));
            this.radioButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton2.Location = new System.Drawing.Point(78, 385);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 31);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button17
            // 
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.Location = new System.Drawing.Point(278, 345);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(249, 26);
            this.button17.TabIndex = 42;
            this.button17.Text = "Modify Individual Contents...";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(160, 6);
            // 
            // updateDatabaseToolStripMenuItem
            // 
            this.updateDatabaseToolStripMenuItem.Name = "updateDatabaseToolStripMenuItem";
            this.updateDatabaseToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.updateDatabaseToolStripMenuItem.Text = "Update Database";
            this.updateDatabaseToolStripMenuItem.Click += new System.EventHandler(this.updateDatabaseToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 492);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.shamelessvariablelabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contentModBox);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.ticketgpbox);
            this.Controls.Add(this.tmdgpbox);
            this.Controls.Add(this.truchabox);
            this.Controls.Add(this.databaseButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.decryptbox);
            this.Controls.Add(this.ignoreticket);
            this.Controls.Add(this.wadnamebox);
            this.Controls.Add(this.getcerts);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleversion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.localuse);
            this.Controls.Add(this.dlprogress);
            this.Controls.Add(this.packbox);
            this.Controls.Add(this.statusbox);
            this.Controls.Add(this.downloadstartbtn);
            this.Controls.Add(this.titleidbox);
            this.Controls.Add(this.TMDButton);
            this.Controls.Add(this.button6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(545, 520);
            this.MinimumSize = new System.Drawing.Size(280, 520);
            this.Name = "Form1";
            this.Text = "NUSD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.databaseStrip.ResumeLayout(false);
            this.tmdgpbox.ResumeLayout(false);
            this.tmdgpbox.PerformLayout();
            this.ticketgpbox.ResumeLayout(false);
            this.ticketgpbox.PerformLayout();
            this.contentModBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TMDButton;
        private System.Windows.Forms.TextBox titleidbox;
        private System.Windows.Forms.Button downloadstartbtn;
        private System.Windows.Forms.TextBox statusbox;
        private System.Windows.Forms.CheckBox packbox;
        private System.Windows.Forms.ProgressBar dlprogress;
        private System.Windows.Forms.CheckBox localuse;
        private System.ComponentModel.BackgroundWorker NUSDownloader;
        private System.Windows.Forms.TextBox titleversion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button getcerts;
        private System.Windows.Forms.TextBox wadnamebox;
        private System.Windows.Forms.CheckBox ignoreticket;
        private System.Windows.Forms.CheckBox decryptbox;
        private System.Windows.Forms.Button databaseButton;
        private System.Windows.Forms.ContextMenuStrip databaseStrip;
        private System.Windows.Forms.ToolStripMenuItem SystemMenuList;
        private System.Windows.Forms.ToolStripMenuItem IOSMenuList;
        private System.Windows.Forms.ToolStripMenuItem VCMenuList;
        private System.Windows.Forms.ToolStripMenuItem WiiWareMenuList;
        private System.Windows.Forms.ToolStripMenuItem C64MenuList;
        private System.Windows.Forms.ToolStripMenuItem NeoGeoMenuList;
        private System.Windows.Forms.ToolStripMenuItem NESMenuList;
        private System.Windows.Forms.ToolStripMenuItem SNESMenuList;
        private System.Windows.Forms.ToolStripMenuItem N64MenuList;
        private System.Windows.Forms.ToolStripMenuItem MSXMenuList;
        private System.Windows.Forms.ToolStripMenuItem TurboGrafx16MenuList;
        private System.Windows.Forms.ToolStripMenuItem SegaMSMenuList;
        private System.Windows.Forms.ToolStripMenuItem GenesisMenuList;
        private System.Windows.Forms.ToolStripMenuItem VCArcadeMenuList;
        private System.Windows.Forms.ToolStripMenuItem TurboGrafxCDMenuList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem RegionCodesList;
        private System.Windows.Forms.CheckBox truchabox;
        private System.Windows.Forms.GroupBox tmdgpbox;
        private System.Windows.Forms.GroupBox ticketgpbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newtitleidbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox requiredIOSbox;
        private System.Windows.Forms.TextBox tmdversiontrucha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dlcamntbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox titleIDIV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox titlekeybox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox timelimitenabledcb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ckeyindexcb;
        private System.Windows.Forms.TextBox timelimitsecs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label shamelessvariablelabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox contentsEdit;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox contentModBox;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem updateDatabaseToolStripMenuItem;
    }
}

