using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicTracker
{
    public partial class MainForm : Form
    {
        // Registers a hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        // Unregisters the hot key with Windows.
        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private SessionData sessionData;
        private SessionData undoBuffer;

        private const int WM_HOTKEY = 0x0312;
        private DateTime endTimeUtc;
        private DateTime sessionStart;
        private List<bool> resultList;

        public MainForm()
        {
            InitializeComponent();

            sessionData = new SessionData();
            resultList = new List<bool>();
        }

        private void UpdateClock()
        {
            if (DateTime.UtcNow > endTimeUtc)
            {
                GetSeasonEnd();
            }

            TimeSpan timeLeft = endTimeUtc - DateTime.UtcNow;
            TimeSpan session = DateTime.Now - sessionStart;

            labelClock.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", timeLeft.Days, timeLeft.Hours, timeLeft.Minutes, timeLeft.Seconds);
            statusLabelClock.Text = String.Format("{0:00}:{1:00}:{2:00}", session.Hours, session.Minutes, session.Seconds);
        }

        private void UpdateRemaining()
        {
            sessionData.Remaining = 120 - sessionData.Rank * 24 - sessionData.Level * 6 - sessionData.RankWins;
            labelGames.Text = $"Games Remaining: {sessionData.Remaining}";
        }

        private void DoLoss(bool loseRank)
        {
            SaveUndoBuffer();
            QueueResult(false);

            sessionData.Session.Loss++;
            sessionData.Season.Loss++;

            if(!sessionData.WonLastGame)
                sessionData.Streak--;
            else
                sessionData.Streak = -1;

            sessionData.WonLastGame = false;

            if (loseRank && sessionData.Rank < 5 && !(sessionData.Level == 0 && sessionData.RankWins == 0))
            {
                sessionData.RankWins--;
            }
            else if (sessionData.Rank == 5)
            {
                sessionData.Mythic.Loss++;
            }
            
            if (sessionData.RankWins < 0)
            {
                sessionData.RankWins = 5;
                sessionData.Level--;
            }

            if (sessionData.Level < 0)
            {
                sessionData.Rank--;
                sessionData.Level = 3;
            }

            if (sessionData.Rank < 0)
                sessionData.Rank = 0;

            DisplayRank();
        }

        private void UpdateProgress()
        {
            switch (sessionData.Rank)
            {
                case 0:
                    progressBarDiamond.Value = 0;
                    progressBarPlatinum.Value = 0;
                    progressBarGold.Value = 0;
                    progressBarSilver.Value = 0;
                    progressBarBronze.Value = sessionData.Level * 6 + sessionData.RankWins;
                    break;

                case 1:
                    progressBarDiamond.Value = 0;
                    progressBarPlatinum.Value = 0;
                    progressBarGold.Value = 0;
                    progressBarSilver.Value = sessionData.Level * 6 + sessionData.RankWins;
                    progressBarBronze.Value = 24;
                    break;

                case 2:
                    progressBarDiamond.Value = 0;
                    progressBarPlatinum.Value = 0;
                    progressBarGold.Value = sessionData.Level * 6 + sessionData.RankWins;
                    progressBarSilver.Value = 24;
                    progressBarBronze.Value = 24;
                    break;

                case 3:
                    progressBarDiamond.Value = 0;
                    progressBarPlatinum.Value = sessionData.Level * 6 + sessionData.RankWins;
                    progressBarGold.Value = 24;
                    progressBarSilver.Value = 24;
                    progressBarBronze.Value = 24;
                    break;

                case 4:
                    progressBarDiamond.Value = sessionData.Level * 6 + sessionData.RankWins;
                    progressBarPlatinum.Value = 24;
                    progressBarGold.Value = 24;
                    progressBarSilver.Value = 24;
                    progressBarBronze.Value = 24;
                    break;

                case 5:
                    progressBarDiamond.Value = 24;
                    progressBarPlatinum.Value = 24;
                    progressBarGold.Value = 24;
                    progressBarSilver.Value = 24;
                    progressBarBronze.Value = 24;
                    break;
            }

            if (sessionData.Rank != 5)
                progressBarTotal.Value = sessionData.Rank * 24 + sessionData.Level * 6 + sessionData.RankWins;
            else
                progressBarTotal.Value = progressBarTotal.Maximum;
        }

        private void DisplayRank()
        {
            switch (sessionData.Rank)
            {
                case 0:
                    labelRank.Text = $"Bronze {4 - sessionData.Level}-{sessionData.RankWins}";
                    break;

                case 1:
                    labelRank.Text = $"Silver {4 - sessionData.Level}-{sessionData.RankWins}";
                    break;

                case 2:
                    labelRank.Text = $"Gold {4 - sessionData.Level}-{sessionData.RankWins}";
                    break;

                case 3:
                    labelRank.Text = $"Platinum {4 - sessionData.Level}-{sessionData.RankWins}";
                    break;

                case 4:
                    labelRank.Text = $"Diamond {4 - sessionData.Level}-{sessionData.RankWins}";
                    break;

                case 5:
                    labelRank.Text = "MYTHIC";
                    break;
            }

            statusLabelFileError.Visible = false;
            statusLabelFileError.ToolTipText = "";

            UpdateRemaining();
            UpdateProgress();
            UpdateLast10();

            labelRecord.Text = $"{sessionData.Session.Win} - {sessionData.Session.Loss}";
            labelSeason.Text = $"{sessionData.Season.Win} - {sessionData.Season.Loss}";

            statusLabelSessionGames.Text = $"{sessionData.Session.Win + sessionData.Session.Loss} games";
            statusLabelSessionPct.Text = string.Format("{0:0.000} pct", sessionData.Session.Pct);
            
            statusLabelSeasonGames.Text = $"{sessionData.Season.Win + sessionData.Season.Loss} games";
            statusLabelSeasonPct.Text = string.Format("{0:0.000} pct", sessionData.Season.Pct);

            statusLabelMythic.Text = $"{sessionData.Mythic.Win} - {sessionData.Mythic.Loss}";
            statusLabelMythicGames.Text = $"{sessionData.Mythic.Win + sessionData.Mythic.Loss}";
            statusLabelMythicPct.Text = string.Format("{0:0.000} pct", sessionData.Mythic.Pct);

            if (undoBuffer == null)
                toolStripButtonUndo.Enabled = false;
            else
                toolStripButtonUndo.Enabled = true;

            if(sessionData.Rank == 5)
            {
                statusLabelMythic.Visible = true;
                statusLabelMythicGames.Visible = true;
                statusLabelMythicPct.Visible = true;
                statusLabelMythic.Visible = true;
            }
            else
            {
                statusLabelMythic.Visible = false;
                statusLabelMythicGames.Visible = false;
                statusLabelMythicPct.Visible = false;
                statusLabelMythic.Visible = false;
            }

            if (sessionData.Streak == 0)
            {
                labelStreak.Text = "None";
            }
            else if(sessionData.Streak > 0)
            {
                labelStreak.Text = $"Win {Math.Abs(sessionData.Streak)}";
            }
            else
            {
                labelStreak.Text = $"Lose {Math.Abs(sessionData.Streak)}";
            }

            statusLabelSave.Visible = true;

            Task.Run(() => WriteOutputFiles());
        }

        private void UpdateLast10()
        {
            int win = 0;
            int loss = 0;

            foreach(bool r in resultList)
            {
                if (r)
                    win++;
                else
                    loss++;
            }

            statusLabelLast10.Text = $"Last 10: {win} - {loss}";
        }

        private void WriteOutputFiles()
        {
            if (!Directory.Exists(Properties.Settings.Default.OutputPath))
                Directory.CreateDirectory(Properties.Settings.Default.OutputPath);

            string mythic = "";

            if (sessionData.Mythic.Win + sessionData.Mythic.Loss > 0)
            {
                mythic = $"Mythic: {sessionData.Mythic.Win} - {sessionData.Mythic.Loss}";
            }

            try
            {
                File.WriteAllText(Properties.Settings.Default.OutputPath + "\\records.txt", labelRecord.Text);
                File.WriteAllText(Properties.Settings.Default.OutputPath + "\\Rank.txt", labelRank.Text);
                File.WriteAllText(Properties.Settings.Default.OutputPath + "\\Season.txt", labelSeason.Text);
                File.WriteAllText(Properties.Settings.Default.OutputPath + "\\Streak.txt", labelStreak.Text);
                File.WriteAllText(Properties.Settings.Default.OutputPath + "\\games.txt", $"Wins needed: {sessionData.Remaining}");
                File.WriteAllText(Properties.Settings.Default.OutputPath + "\\mythic.txt", mythic);
                File.WriteAllText(Properties.Settings.Default.OutputPath + "\\last10.txt", statusLabelLast10.Text);               
            }
            catch (IOException ex)
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() =>
                    {
                        statusLabelFileError.Visible = true;
                        statusLabelFileError.ToolTipText = ex.Message;
                    }));
                }
                else
                {
                    statusLabelFileError.Visible = true;
                }
            }

            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    statusLabelSave.Visible = false;
                }));
            }
            else
            {
                statusLabelSave.Visible = false;
            }
        }

        private void GetSeasonEnd()
        {
            int lastDay = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            DateTime endTimePst = new DateTime(DateTime.Now.Year, DateTime.Now.Month, lastDay, 12, 0, 0);
            TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");

            endTimeUtc = TimeZoneInfo.ConvertTime(endTimePst, pst, TimeZoneInfo.Utc);

            if (DateTime.UtcNow > endTimeUtc)
            {
                DateTime next = DateTime.Now.AddMonths(1);

                lastDay = DateTime.DaysInMonth(next.Year, next.Month);
                endTimePst = new DateTime(next.Year, next.Month, lastDay, 12, 0, 0);
                endTimeUtc = TimeZoneInfo.ConvertTime(endTimePst, pst, TimeZoneInfo.Utc);

                undoBuffer = null;
            }
        }

        private void SaveUndoBuffer()
        {
            if (undoBuffer == null)
                undoBuffer = new SessionData();

            undoBuffer.Level = sessionData.Level;
            undoBuffer.Rank = sessionData.Rank;
            undoBuffer.RankWins = sessionData.RankWins;
            undoBuffer.Remaining = sessionData.Remaining;
            undoBuffer.Streak = sessionData.Streak;
            undoBuffer.WonLastGame = sessionData.WonLastGame;
            undoBuffer.Mythic.Win = sessionData.Mythic.Win;
            undoBuffer.Mythic.Loss = sessionData.Mythic.Loss;
            undoBuffer.Season.Win = sessionData.Season.Win;
            undoBuffer.Season.Loss = sessionData.Season.Loss;
            undoBuffer.Session.Win = sessionData.Session.Win;
            undoBuffer.Session.Loss = sessionData.Session.Loss;
        }

        private void DoUndo()
        {
            if (undoBuffer == null)
                undoBuffer = new SessionData();

            sessionData.Level = undoBuffer.Level;
            sessionData.Rank = undoBuffer.Rank;
            sessionData.RankWins = undoBuffer.RankWins;
            sessionData.Remaining = undoBuffer.Remaining;
            sessionData.Streak = undoBuffer.Streak;
            sessionData.WonLastGame = undoBuffer.WonLastGame;
            sessionData.Mythic.Win = undoBuffer.Mythic.Win;
            sessionData.Mythic.Loss = undoBuffer.Mythic.Loss;
            sessionData.Season.Win = undoBuffer.Season.Win;
            sessionData.Season.Loss = undoBuffer.Season.Loss;
            sessionData.Session.Win = undoBuffer.Session.Win;
            sessionData.Session.Loss = undoBuffer.Session.Loss;

            if (resultList.Count > 0)
                resultList.RemoveAt(resultList.Count - 1);

            undoBuffer = null;
            DisplayRank();
        }

        private void QueueResult(bool wonGame)
        {
            resultList.Add(wonGame);

            if (resultList.Count > 10)
                resultList.RemoveAt(0);
        }

        private void DoWin(int steps)
        {
            SaveUndoBuffer();
            QueueResult(true);

            sessionData.Session.Win++;
            sessionData.Season.Win++;

            if (sessionData.WonLastGame)
                sessionData.Streak++;
            else
                sessionData.Streak = 1;

            sessionData.WonLastGame = true;

            if (sessionData.Rank < 5)
            {
                sessionData.RankWins += steps;

                if (sessionData.RankWins > 5)
                {
                    sessionData.RankWins -= 6;
                    sessionData.Level++;
                }

                if (sessionData.Level > 3)
                {
                    sessionData.Level = 0;
                    sessionData.Rank++;
                }
            }
            else
            {
                sessionData.Mythic.Win += steps;
            }

            DisplayRank();
        }

        private void ResetRank(bool resetSeason)
        {
            SaveUndoBuffer();

            sessionData.Session.Win = 0;
            sessionData.Session.Loss = 0;
            sessionData.Streak = 0;

            if(resetSeason)
            {
                sessionData.Season.Win = 0;
                sessionData.Season.Loss = 0;
            }

            sessionStart = DateTime.Now;
            DisplayRank();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_HOTKEY)
            {
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xffff);
                ModiferKey modifer = (ModiferKey)((int)m.LParam & 0xffff);

                switch (key)
                {
                    case Keys.Oemplus:
                        if (modifer == ModiferKey.Control)
                        {
                            DoWin(1);
                        }

                        if (modifer == (ModiferKey.Control | ModiferKey.Alt))
                        {
                            DoWin(2);
                        }

                        break;

                    case Keys.OemMinus:
                        if (modifer == ModiferKey.Control)
                        {
                            DoLoss(true);
                        }

                        if (modifer == (ModiferKey.Control | ModiferKey.Alt))
                        {
                            DoLoss(false);
                        }

                        break;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            sessionStart = DateTime.Now;

            RegisterHotKey(this.Handle, 0, (uint)ModiferKey.Control, (uint)Keys.Oemplus);
            RegisterHotKey(this.Handle, 1, (uint)(ModiferKey.Control | ModiferKey.Alt), (uint)Keys.Oemplus);
            RegisterHotKey(this.Handle, 2, (uint)ModiferKey.Control, (uint)Keys.OemMinus);
            RegisterHotKey(this.Handle, 3, (uint)(ModiferKey.Control | ModiferKey.Alt), (uint)Keys.OemMinus);

            if (Properties.Settings.Default.OutputPath == "")
                Properties.Settings.Default.OutputPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\MythicTracker";

            sessionData.Rank = Properties.Settings.Default.Rank;
            sessionData.Level = Properties.Settings.Default.Level;
            sessionData.RankWins = Properties.Settings.Default.Wins;

            sessionData.Season.Win = Properties.Settings.Default.SeasonWin;
            sessionData.Season.Loss = Properties.Settings.Default.SeasonLoss;
            sessionData.Mythic.Win = Properties.Settings.Default.MythicWin;
            sessionData.Mythic.Loss = Properties.Settings.Default.MythicLoss;

            GetSeasonEnd();
            DisplayRank();
            UpdateClock();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Rank = sessionData.Rank;
            Properties.Settings.Default.Level = sessionData.Level;
            Properties.Settings.Default.Wins = sessionData.RankWins;
            Properties.Settings.Default.SeasonWin = sessionData.Season.Win;
            Properties.Settings.Default.SeasonLoss = sessionData.Season.Loss;
            Properties.Settings.Default.MythicWin = sessionData.Mythic.Win;
            Properties.Settings.Default.MythicLoss = sessionData.Mythic.Loss;

            Properties.Settings.Default.Save();

            for (int i = 0; i < 4; i++)
            {
                UnregisterHotKey(this.Handle, i);
            }
        }

        private void contextMenuItemDecrease_Click(object sender, EventArgs e)
        {
            DoLoss(true);
        }

        private void contextMenuItemNoDecrease_Click(object sender, EventArgs e)
        {
            DoLoss(false);
        }

        private void toolStripButtonWin_ButtonCClick(object sender, EventArgs e)
        {
            DoWin(1);
        }

        private void affectsRankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoLoss(true);
        }

        private void doesNotAffectRankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoLoss(false);
        }

        private void toolStripButtonRank_Click(object sender, EventArgs e)
        {
            using (RankDlog dlog = new RankDlog())
            {
                dlog.Rank = sessionData.Rank;
                dlog.Level = sessionData.Level;
                dlog.Wins = sessionData.RankWins;

                if (dlog.ShowDialog() != DialogResult.OK)
                    return;

                sessionData.Rank = dlog.Rank;
                sessionData.Level = dlog.Level;
                sessionData.RankWins = dlog.Wins;

                DisplayRank();
            }
        }

        private void toolStripButtonSetRank_Click(object sender, EventArgs e)
        {
            using (RecordDlog dlog = new RecordDlog())
            {
                dlog.Wins = sessionData.Session.Win;
                dlog.Losses = sessionData.Session.Loss;
                dlog.SeasonWin = sessionData.Season.Win;
                dlog.SeasonLoss = sessionData.Season.Loss;
                dlog.Streak = sessionData.Streak;

                if (dlog.ShowDialog() != DialogResult.OK)
                    return;

                sessionData.Session.Win = dlog.Wins;
                sessionData.Session.Loss = dlog.Losses;

                sessionData.Season.Win = dlog.SeasonWin;
                sessionData.Season.Loss = dlog.SeasonLoss;

                sessionData.Streak = dlog.Streak;

                DisplayRank();
            }
        }

        private void toolStripButtonResetRank_Click(object sender, EventArgs e)
        {
        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            using (AboutDlog dlog = new AboutDlog())
            {
                dlog.ShowDialog();
            }
        }

        private void toolStripButtonLoss_ButtonClick(object sender, EventArgs e)
        {
            DoLoss(true);
        }

        private void advance1StepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoWin(1);
        }

        private void advance2StepsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoWin(2);
        }

        private void toolStripButtonResetRank_ButtonClick(object sender, EventArgs e)
        {
            ResetRank(false);
        }

        private void resetSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetRank(false);
        }

        private void resetSeasonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetRank(true);
        }

        private void toolStripButtonSettings_Click(object sender, EventArgs e)
        {
            using(SettingsDialog dlog = new SettingsDialog())
            {
                if(dlog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.OutputPath = dlog.OutputPath;
                    DisplayRank();
                }
            }
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            DoUndo();
        }
    }
}
