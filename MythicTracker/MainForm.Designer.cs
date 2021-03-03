namespace MythicTracker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelGames = new System.Windows.Forms.Label();
            this.progressBarTotal = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarDiamond = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBarPlatinum = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBarSilver = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBarGold = new System.Windows.Forms.ProgressBar();
            this.labelBronze = new System.Windows.Forms.Label();
            this.progressBarBronze = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.labelRank = new System.Windows.Forms.Label();
            this.labelRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuLoss = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItemDecrease = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItemNoDecrease = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonWin = new System.Windows.Forms.ToolStripSplitButton();
            this.advance1StepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advance2StepsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonLoss = new System.Windows.Forms.ToolStripSplitButton();
            this.doesNotAffectRankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affectsRankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRank = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSetRank = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonResetRank = new System.Windows.Forms.ToolStripSplitButton();
            this.resetSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSeasonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.labelClock = new System.Windows.Forms.Label();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelStreak = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelSeason = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelSessionGames = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelSessionPct = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelLast10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelSeasonGames = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelSeasonPct = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelMythic = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelMythicRecord = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelMythicGames = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelMythicPct = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelFileError = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelSave = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuLoss.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGames
            // 
            this.labelGames.AutoSize = true;
            this.labelGames.Font = new System.Drawing.Font("Beleren Small Caps", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGames.Location = new System.Drawing.Point(551, 48);
            this.labelGames.Name = "labelGames";
            this.labelGames.Size = new System.Drawing.Size(287, 32);
            this.labelGames.TabIndex = 0;
            this.labelGames.Text = "Games Remaining: 120";
            // 
            // progressBarTotal
            // 
            this.progressBarTotal.Location = new System.Drawing.Point(552, 83);
            this.progressBarTotal.Maximum = 120;
            this.progressBarTotal.Name = "progressBarTotal";
            this.progressBarTotal.Size = new System.Drawing.Size(299, 23);
            this.progressBarTotal.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Beleren Small Caps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Diamond:";
            // 
            // progressBarDiamond
            // 
            this.progressBarDiamond.Location = new System.Drawing.Point(12, 70);
            this.progressBarDiamond.Maximum = 24;
            this.progressBarDiamond.Name = "progressBarDiamond";
            this.progressBarDiamond.Size = new System.Drawing.Size(366, 23);
            this.progressBarDiamond.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Beleren Small Caps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Platinum:";
            // 
            // progressBarPlatinum
            // 
            this.progressBarPlatinum.Location = new System.Drawing.Point(12, 151);
            this.progressBarPlatinum.Maximum = 24;
            this.progressBarPlatinum.Name = "progressBarPlatinum";
            this.progressBarPlatinum.Size = new System.Drawing.Size(366, 23);
            this.progressBarPlatinum.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Beleren Small Caps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Silver:";
            // 
            // progressBarSilver
            // 
            this.progressBarSilver.Location = new System.Drawing.Point(12, 311);
            this.progressBarSilver.Maximum = 24;
            this.progressBarSilver.Name = "progressBarSilver";
            this.progressBarSilver.Size = new System.Drawing.Size(366, 23);
            this.progressBarSilver.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Beleren Small Caps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Gold:";
            // 
            // progressBarGold
            // 
            this.progressBarGold.Location = new System.Drawing.Point(12, 230);
            this.progressBarGold.Maximum = 24;
            this.progressBarGold.Name = "progressBarGold";
            this.progressBarGold.Size = new System.Drawing.Size(366, 23);
            this.progressBarGold.TabIndex = 8;
            // 
            // labelBronze
            // 
            this.labelBronze.AutoSize = true;
            this.labelBronze.Font = new System.Drawing.Font("Beleren Small Caps", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBronze.Location = new System.Drawing.Point(12, 374);
            this.labelBronze.Name = "labelBronze";
            this.labelBronze.Size = new System.Drawing.Size(66, 19);
            this.labelBronze.TabIndex = 13;
            this.labelBronze.Text = "Bronze:";
            // 
            // progressBarBronze
            // 
            this.progressBarBronze.Location = new System.Drawing.Point(12, 396);
            this.progressBarBronze.Maximum = 24;
            this.progressBarBronze.Name = "progressBarBronze";
            this.progressBarBronze.Size = new System.Drawing.Size(366, 23);
            this.progressBarBronze.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Beleren Small Caps", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(552, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 34);
            this.label8.TabIndex = 14;
            this.label8.Text = "Current Rank";
            // 
            // labelRank
            // 
            this.labelRank.BackColor = System.Drawing.SystemColors.Control;
            this.labelRank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRank.Font = new System.Drawing.Font("Beleren Small Caps", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRank.Location = new System.Drawing.Point(552, 173);
            this.labelRank.Name = "labelRank";
            this.labelRank.Size = new System.Drawing.Size(171, 34);
            this.labelRank.TabIndex = 15;
            this.labelRank.Text = "Bronze 4-0";
            this.labelRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRecord
            // 
            this.labelRecord.BackColor = System.Drawing.SystemColors.Control;
            this.labelRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRecord.Font = new System.Drawing.Font("Beleren Small Caps", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecord.Location = new System.Drawing.Point(729, 173);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(119, 34);
            this.labelRecord.TabIndex = 20;
            this.labelRecord.Text = "0-0";
            this.labelRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Beleren Small Caps", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(729, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 34);
            this.label2.TabIndex = 19;
            this.label2.Text = "Record";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // contextMenuLoss
            // 
            this.contextMenuLoss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItemDecrease,
            this.contextMenuItemNoDecrease});
            this.contextMenuLoss.Name = "contextMenuLoss";
            this.contextMenuLoss.Size = new System.Drawing.Size(181, 48);
            // 
            // contextMenuItemDecrease
            // 
            this.contextMenuItemDecrease.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.contextMenuItemDecrease.Name = "contextMenuItemDecrease";
            this.contextMenuItemDecrease.Size = new System.Drawing.Size(180, 22);
            this.contextMenuItemDecrease.Text = "Affects rank";
            this.contextMenuItemDecrease.Click += new System.EventHandler(this.contextMenuItemDecrease_Click);
            // 
            // contextMenuItemNoDecrease
            // 
            this.contextMenuItemNoDecrease.Name = "contextMenuItemNoDecrease";
            this.contextMenuItemNoDecrease.Size = new System.Drawing.Size(180, 22);
            this.contextMenuItemNoDecrease.Text = "Does not affect rank";
            this.contextMenuItemNoDecrease.Click += new System.EventHandler(this.contextMenuItemNoDecrease_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonWin,
            this.toolStripButtonLoss,
            this.toolStripSeparator1,
            this.toolStripButtonUndo,
            this.toolStripButtonRank,
            this.toolStripButtonSetRank,
            this.toolStripButtonResetRank,
            this.toolStripButtonAbout,
            this.toolStripButtonSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(867, 39);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonWin
            // 
            this.toolStripButtonWin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advance1StepToolStripMenuItem,
            this.advance2StepsToolStripMenuItem});
            this.toolStripButtonWin.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonWin.Image")));
            this.toolStripButtonWin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonWin.Name = "toolStripButtonWin";
            this.toolStripButtonWin.Size = new System.Drawing.Size(76, 36);
            this.toolStripButtonWin.Text = "Win";
            this.toolStripButtonWin.ButtonClick += new System.EventHandler(this.toolStripButtonWin_ButtonCClick);
            // 
            // advance1StepToolStripMenuItem
            // 
            this.advance1StepToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.advance1StepToolStripMenuItem.Name = "advance1StepToolStripMenuItem";
            this.advance1StepToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.advance1StepToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.advance1StepToolStripMenuItem.Text = "Advance 1 step";
            this.advance1StepToolStripMenuItem.Click += new System.EventHandler(this.advance1StepToolStripMenuItem_Click);
            // 
            // advance2StepsToolStripMenuItem
            // 
            this.advance2StepsToolStripMenuItem.Name = "advance2StepsToolStripMenuItem";
            this.advance2StepsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.advance2StepsToolStripMenuItem.Text = "Advance 2 steps";
            this.advance2StepsToolStripMenuItem.Click += new System.EventHandler(this.advance2StepsToolStripMenuItem_Click);
            // 
            // toolStripButtonLoss
            // 
            this.toolStripButtonLoss.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doesNotAffectRankToolStripMenuItem,
            this.affectsRankToolStripMenuItem});
            this.toolStripButtonLoss.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoss.Image")));
            this.toolStripButtonLoss.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoss.Name = "toolStripButtonLoss";
            this.toolStripButtonLoss.Size = new System.Drawing.Size(78, 36);
            this.toolStripButtonLoss.Text = "Loss";
            this.toolStripButtonLoss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonLoss.ButtonClick += new System.EventHandler(this.toolStripButtonLoss_ButtonClick);
            // 
            // doesNotAffectRankToolStripMenuItem
            // 
            this.doesNotAffectRankToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.doesNotAffectRankToolStripMenuItem.Name = "doesNotAffectRankToolStripMenuItem";
            this.doesNotAffectRankToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.doesNotAffectRankToolStripMenuItem.Text = "Go back 0 steps";
            this.doesNotAffectRankToolStripMenuItem.Click += new System.EventHandler(this.doesNotAffectRankToolStripMenuItem_Click);
            // 
            // affectsRankToolStripMenuItem
            // 
            this.affectsRankToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.affectsRankToolStripMenuItem.Name = "affectsRankToolStripMenuItem";
            this.affectsRankToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.affectsRankToolStripMenuItem.Text = "Go back 1 step";
            this.affectsRankToolStripMenuItem.Click += new System.EventHandler(this.affectsRankToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.Enabled = false;
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(72, 36);
            this.toolStripButtonUndo.Text = "Undo";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // toolStripButtonRank
            // 
            this.toolStripButtonRank.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRank.Image")));
            this.toolStripButtonRank.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRank.Name = "toolStripButtonRank";
            this.toolStripButtonRank.Size = new System.Drawing.Size(85, 36);
            this.toolStripButtonRank.Text = "Set rank";
            this.toolStripButtonRank.Click += new System.EventHandler(this.toolStripButtonRank_Click);
            // 
            // toolStripButtonSetRank
            // 
            this.toolStripButtonSetRank.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSetRank.Image")));
            this.toolStripButtonSetRank.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSetRank.Name = "toolStripButtonSetRank";
            this.toolStripButtonSetRank.Size = new System.Drawing.Size(96, 36);
            this.toolStripButtonSetRank.Text = "Set record";
            this.toolStripButtonSetRank.Click += new System.EventHandler(this.toolStripButtonSetRank_Click);
            // 
            // toolStripButtonResetRank
            // 
            this.toolStripButtonResetRank.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetSessionToolStripMenuItem,
            this.resetSeasonToolStripMenuItem});
            this.toolStripButtonResetRank.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonResetRank.Image")));
            this.toolStripButtonResetRank.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonResetRank.Name = "toolStripButtonResetRank";
            this.toolStripButtonResetRank.Size = new System.Drawing.Size(120, 36);
            this.toolStripButtonResetRank.Text = "Reset record";
            this.toolStripButtonResetRank.ButtonClick += new System.EventHandler(this.toolStripButtonResetRank_ButtonClick);
            // 
            // resetSessionToolStripMenuItem
            // 
            this.resetSessionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.resetSessionToolStripMenuItem.Name = "resetSessionToolStripMenuItem";
            this.resetSessionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetSessionToolStripMenuItem.Text = "Reset session";
            this.resetSessionToolStripMenuItem.Click += new System.EventHandler(this.resetSessionToolStripMenuItem_Click);
            // 
            // resetSeasonToolStripMenuItem
            // 
            this.resetSeasonToolStripMenuItem.Name = "resetSeasonToolStripMenuItem";
            this.resetSeasonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetSeasonToolStripMenuItem.Text = "Reset season";
            this.resetSeasonToolStripMenuItem.Click += new System.EventHandler(this.resetSeasonToolStripMenuItem_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(76, 36);
            this.toolStripButtonAbout.Text = "About";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSettings.Image")));
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(85, 36);
            this.toolStripButtonSettings.Text = "Settings";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
            // 
            // labelClock
            // 
            this.labelClock.BackColor = System.Drawing.Color.Black;
            this.labelClock.Font = new System.Drawing.Font("Beleren", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClock.ForeColor = System.Drawing.Color.White;
            this.labelClock.Location = new System.Drawing.Point(683, 393);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(168, 37);
            this.labelClock.TabIndex = 28;
            this.labelClock.Text = "00:00:00:00";
            this.labelClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerCountdown
            // 
            this.timerCountdown.Enabled = true;
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Beleren Small Caps", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(683, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 34);
            this.label1.TabIndex = 29;
            this.label1.Text = "Season Ends";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStreak
            // 
            this.labelStreak.BackColor = System.Drawing.SystemColors.Control;
            this.labelStreak.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStreak.Font = new System.Drawing.Font("Beleren Small Caps", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStreak.Location = new System.Drawing.Point(552, 274);
            this.labelStreak.Name = "labelStreak";
            this.labelStreak.Size = new System.Drawing.Size(171, 34);
            this.labelStreak.TabIndex = 31;
            this.labelStreak.Text = "Win 0";
            this.labelStreak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Beleren Small Caps", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(552, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 34);
            this.label9.TabIndex = 30;
            this.label9.Text = "Streak";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelSeason
            // 
            this.labelSeason.BackColor = System.Drawing.SystemColors.Control;
            this.labelSeason.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeason.Font = new System.Drawing.Font("Beleren Small Caps", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeason.Location = new System.Drawing.Point(729, 274);
            this.labelSeason.Name = "labelSeason";
            this.labelSeason.Size = new System.Drawing.Size(119, 34);
            this.labelSeason.TabIndex = 35;
            this.labelSeason.Text = "0-0";
            this.labelSeason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Beleren Small Caps", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(744, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 34);
            this.label10.TabIndex = 34;
            this.label10.Text = "Season";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusLabelSessionGames,
            this.statusLabelSessionPct,
            this.statusLabelClock,
            this.toolStripStatusLabel3,
            this.statusLabelSeasonGames,
            this.statusLabelSeasonPct,
            this.statusLabelLast10,
            this.statusLabelMythic,
            this.statusLabelMythicRecord,
            this.statusLabelMythicGames,
            this.statusLabelMythicPct,
            this.statusLabelFileError,
            this.statusLabelSave});
            this.statusStrip.Location = new System.Drawing.Point(0, 448);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(867, 24);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 36;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(51, 19);
            this.toolStripStatusLabel1.Text = "Session:";
            // 
            // statusLabelSessionGames
            // 
            this.statusLabelSessionGames.Name = "statusLabelSessionGames";
            this.statusLabelSessionGames.Size = new System.Drawing.Size(51, 19);
            this.statusLabelSessionGames.Text = "0 games";
            // 
            // statusLabelSessionPct
            // 
            this.statusLabelSessionPct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusLabelSessionPct.Name = "statusLabelSessionPct";
            this.statusLabelSessionPct.Size = new System.Drawing.Size(54, 19);
            this.statusLabelSessionPct.Text = "0.000 pct";
            // 
            // statusLabelLast10
            // 
            this.statusLabelLast10.Name = "statusLabelLast10";
            this.statusLabelLast10.Size = new System.Drawing.Size(66, 19);
            this.statusLabelLast10.Text = "Last 10: 0-0";
            // 
            // statusLabelClock
            // 
            this.statusLabelClock.Image = ((System.Drawing.Image)(resources.GetObject("statusLabelClock.Image")));
            this.statusLabelClock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statusLabelClock.Name = "statusLabelClock";
            this.statusLabelClock.Size = new System.Drawing.Size(65, 19);
            this.statusLabelClock.Text = "00:00:00";
            this.statusLabelClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(53, 19);
            this.toolStripStatusLabel3.Text = "Season:";
            // 
            // statusLabelSeasonGames
            // 
            this.statusLabelSeasonGames.Name = "statusLabelSeasonGames";
            this.statusLabelSeasonGames.Size = new System.Drawing.Size(51, 19);
            this.statusLabelSeasonGames.Text = "0 games";
            // 
            // statusLabelSeasonPct
            // 
            this.statusLabelSeasonPct.Name = "statusLabelSeasonPct";
            this.statusLabelSeasonPct.Size = new System.Drawing.Size(54, 19);
            this.statusLabelSeasonPct.Text = "0.000 pct";
            // 
            // statusLabelMythic
            // 
            this.statusLabelMythic.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.statusLabelMythic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.statusLabelMythic.Name = "statusLabelMythic";
            this.statusLabelMythic.Size = new System.Drawing.Size(52, 19);
            this.statusLabelMythic.Text = "Mythic:";
            this.statusLabelMythic.Visible = false;
            // 
            // statusLabelMythicRecord
            // 
            this.statusLabelMythicRecord.Name = "statusLabelMythicRecord";
            this.statusLabelMythicRecord.Size = new System.Drawing.Size(24, 19);
            this.statusLabelMythicRecord.Text = "0-0";
            this.statusLabelMythicRecord.Visible = false;
            // 
            // statusLabelMythicGames
            // 
            this.statusLabelMythicGames.Name = "statusLabelMythicGames";
            this.statusLabelMythicGames.Size = new System.Drawing.Size(51, 19);
            this.statusLabelMythicGames.Text = "0 games";
            this.statusLabelMythicGames.Visible = false;
            // 
            // statusLabelMythicPct
            // 
            this.statusLabelMythicPct.Name = "statusLabelMythicPct";
            this.statusLabelMythicPct.Size = new System.Drawing.Size(54, 19);
            this.statusLabelMythicPct.Text = "0.000 pct";
            this.statusLabelMythicPct.Visible = false;
            // 
            // statusLabelFileError
            // 
            this.statusLabelFileError.Image = ((System.Drawing.Image)(resources.GetObject("statusLabelFileError.Image")));
            this.statusLabelFileError.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statusLabelFileError.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.statusLabelFileError.Name = "statusLabelFileError";
            this.statusLabelFileError.Size = new System.Drawing.Size(203, 19);
            this.statusLabelFileError.Spring = true;
            this.statusLabelFileError.Text = "Unable to write output files.";
            this.statusLabelFileError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statusLabelFileError.Visible = false;
            // 
            // statusLabelSave
            // 
            this.statusLabelSave.Image = ((System.Drawing.Image)(resources.GetObject("statusLabelSave.Image")));
            this.statusLabelSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statusLabelSave.Name = "statusLabelSave";
            this.statusLabelSave.Size = new System.Drawing.Size(407, 19);
            this.statusLabelSave.Spring = true;
            this.statusLabelSave.Text = "Saving output files...";
            this.statusLabelSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.statusLabelSave.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(867, 472);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.labelSeason);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelStreak);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelClock);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelRank);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelBronze);
            this.Controls.Add(this.progressBarBronze);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.progressBarSilver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBarGold);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBarPlatinum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBarDiamond);
            this.Controls.Add(this.progressBarTotal);
            this.Controls.Add(this.labelGames);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mythic Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuLoss.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGames;
        private System.Windows.Forms.ProgressBar progressBarTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBarDiamond;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBarPlatinum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBarSilver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBarGold;
        private System.Windows.Forms.Label labelBronze;
        private System.Windows.Forms.ProgressBar progressBarBronze;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelRank;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuLoss;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemDecrease;
        private System.Windows.Forms.ToolStripMenuItem contextMenuItemNoDecrease;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripButtonLoss;
        private System.Windows.Forms.ToolStripMenuItem affectsRankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doesNotAffectRankToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonRank;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSetRank;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSplitButton toolStripButtonWin;
        private System.Windows.Forms.ToolStripMenuItem advance1StepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advance2StepsToolStripMenuItem;
        private System.Windows.Forms.Label labelStreak;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSeason;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripSplitButton toolStripButtonResetRank;
        private System.Windows.Forms.ToolStripMenuItem resetSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSeasonToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelSessionGames;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelSessionPct;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelSeasonGames;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelSeasonPct;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelFileError;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelSave;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelMythic;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelMythicRecord;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelMythicGames;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelMythicPct;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelLast10;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelClock;
    }
}

