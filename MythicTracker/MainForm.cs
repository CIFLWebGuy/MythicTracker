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
using System.Xml;
using System.Xml.Linq;

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
        private readonly string dataFile;
        private int seasonGamesStart;
        private int sessionGamesStart;

        public MainForm()
        {
            InitializeComponent();

            sessionData = new SessionData();
            resultList = new List<bool>();

#if DEBUG
            dataFile = "records.xml";
#else
            dataFile = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\MythicTracker\\records.xml";
#endif

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
            sessionData.Remaining = GetGamesRemaining();
            labelGames.Text = $"Steps Remaining: {sessionData.Remaining}";
        }

        private int GetGamesRemaining()
        {
            return 120 - sessionData.CurrentRank.Rank * 24 - sessionData.CurrentRank.Level * 6 - sessionData.CurrentRank.Wins;
        }

        private void DoLoss(int steps)
        {
            SaveUndoBuffer();
            QueueResult(false);

            if (toolStripButtonMatch.Checked)
                steps *= 2;

            sessionData.Session.Loss++;
            sessionData.Season.Loss++;

            if(!sessionData.WonLastGame)
                sessionData.Streak--;
            else
                sessionData.Streak = -1;

            sessionData.WonLastGame = false;

            if (sessionData.CurrentRank.Rank < 5 && !(sessionData.CurrentRank.Level == 0 && sessionData.CurrentRank.Wins == 0))
            {
                sessionData.CurrentRank.Wins -= steps;
            }
            else if (sessionData.CurrentRank.Rank == 5)
            {
                sessionData.Mythic.Loss++;
            }
            
            if (sessionData.CurrentRank.Wins < 0)
            {
                sessionData.CurrentRank.Wins = 6 - steps;
                sessionData.CurrentRank.Level--;
            }

            if (sessionData.CurrentRank.Level < 0)
            {
                sessionData.CurrentRank.Rank--;
                sessionData.CurrentRank.Level = 3;
            }

            if (sessionData.CurrentRank.Rank < 0)
                sessionData.CurrentRank.Rank = 0;

            DisplayRank();
        }

        private void UpdateProgress()
        {
            switch (sessionData.CurrentRank.Rank)
            {
                case 0:
                    progressBarDiamond.Value = 0;
                    progressBarPlatinum.Value = 0;
                    progressBarGold.Value = 0;
                    progressBarSilver.Value = 0;
                    progressBarBronze.Value = sessionData.CurrentRank.Level * 6 + sessionData.CurrentRank.Wins;
                    break;

                case 1:
                    progressBarDiamond.Value = 0;
                    progressBarPlatinum.Value = 0;
                    progressBarGold.Value = 0;
                    progressBarSilver.Value = sessionData.CurrentRank.Level * 6 + sessionData.CurrentRank.Wins;
                    progressBarBronze.Value = 24;
                    break;

                case 2:
                    progressBarDiamond.Value = 0;
                    progressBarPlatinum.Value = 0;
                    progressBarGold.Value = sessionData.CurrentRank.Level * 6 + sessionData.CurrentRank.Wins;
                    progressBarSilver.Value = 24;
                    progressBarBronze.Value = 24;
                    break;

                case 3:
                    progressBarDiamond.Value = 0;
                    progressBarPlatinum.Value = sessionData.CurrentRank.Level * 6 + sessionData.CurrentRank.Wins;
                    progressBarGold.Value = 24;
                    progressBarSilver.Value = 24;
                    progressBarBronze.Value = 24;
                    break;

                case 4:
                    progressBarDiamond.Value = sessionData.CurrentRank.Level * 6 + sessionData.CurrentRank.Wins;
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

            if (sessionData.CurrentRank.Rank != 5)
                progressBarTotal.Value = sessionData.CurrentRank.Rank * 24 + sessionData.CurrentRank.Level * 6 + sessionData.CurrentRank.Wins;
            else
                progressBarTotal.Value = progressBarTotal.Maximum;
        }

        private void DisplayRank()
        {
            switch (sessionData.CurrentRank.Rank)
            {
                case 0:
                    labelRank.Text = $"Bronze {4 - sessionData.CurrentRank.Level}-{sessionData.CurrentRank.Wins}";
                    break;

                case 1:
                    labelRank.Text = $"Silver {4 - sessionData.CurrentRank.Level}-{sessionData.CurrentRank.Wins}";
                    break;

                case 2:
                    labelRank.Text = $"Gold {4 - sessionData.CurrentRank.Level}-{sessionData.CurrentRank.Wins}";
                    break;

                case 3:
                    labelRank.Text = $"Platinum {4 - sessionData.CurrentRank.Level}-{sessionData.CurrentRank.Wins}";
                    break;

                case 4:
                    labelRank.Text = $"Diamond {4 - sessionData.CurrentRank.Level}-{sessionData.CurrentRank.Wins}";
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

            statusLabelMythicRecord.Text = $"{sessionData.Mythic.Win} - {sessionData.Mythic.Loss}";
            statusLabelMythicGames.Text = $"{sessionData.Mythic.Win + sessionData.Mythic.Loss}";
            statusLabelMythicPct.Text = string.Format("{0:0.000} pct", sessionData.Mythic.Pct);

            statusLabelDeltaSeason.Text = string.Format("∆GR: {0:+0;-0;+0}", seasonGamesStart- sessionData.Remaining);
            statusLabelDeltaSession.Text = string.Format("∆GR: {0:+0;-0;+0}", sessionGamesStart - sessionData.Remaining);

            if (undoBuffer == null)
                toolStripButtonUndo.Enabled = false;
            else
                toolStripButtonUndo.Enabled = true;

            if(sessionData.CurrentRank.Rank == 5)
            {
                statusLabelMythic.Visible = true;
                statusLabelMythicRecord.Visible = true;
                statusLabelMythicGames.Visible = true;
                statusLabelMythicPct.Visible = true;
                statusLabelMythic.Visible = true;
            }
            else
            {
                statusLabelMythic.Visible = false;
                statusLabelMythicRecord.Visible = false;
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

            undoBuffer.CurrentRank.Level = sessionData.CurrentRank.Level;
            undoBuffer.CurrentRank.Rank = sessionData.CurrentRank.Rank;
            undoBuffer.CurrentRank.Wins = sessionData.CurrentRank.Wins;
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

            sessionData.CurrentRank.Level = undoBuffer.CurrentRank.Level;
            sessionData.CurrentRank.Rank = undoBuffer.CurrentRank.Rank;
            sessionData.CurrentRank.Wins = undoBuffer.CurrentRank.Wins;
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

            if (sessionData.CurrentRank.Rank < 5)
            {
                if (toolStripButtonMatch.Checked)
                    sessionData.CurrentRank.Wins += steps * 2;
                else
                    sessionData.CurrentRank.Wins += steps;

                if (sessionData.CurrentRank.Wins > 5)
                {
                    sessionData.CurrentRank.Wins -= 6;
                    sessionData.CurrentRank.Level++;
                }

                if (sessionData.CurrentRank.Level > 3)
                {
                    sessionData.CurrentRank.Level = 0;
                    sessionData.CurrentRank.Rank++;
                }
            }
            else
            {
                sessionData.Mythic.Win += steps;
            }

            DisplayRank();
        }

        private RankData GetStartingRank()
        {
            RankData newRank = new RankData();

            XDocument doc = XDocument.Load($"{Application.StartupPath}\\SeasonReset.xml");
            XElement root = doc.Element("ranks");

            XElement rank = root.Elements("rank").Where(r => r.Attribute("value").Value == sessionData.CurrentRank.Rank.ToString())
                    .Elements("levels")
                        .Elements("level").Where(l => l.Attribute("value").Value == sessionData.CurrentRank.Level.ToString()).FirstOrDefault()
                            .Element("newRank");

            newRank.Rank = int.Parse(rank.Attribute("rank").Value);
            newRank.Level = int.Parse(rank.Attribute("level").Value);
            newRank.Wins = 0;

            return newRank;
        }

        private void ResetRank(bool resetSeason)
        {
            SaveUndoBuffer();

            if (resetSeason)
            {
                RankData newRank = GetStartingRank();

                using (RankDlog dlog = new RankDlog())
                {
                    dlog.Text = "Select Starting Rank";
                    dlog.WinsVisible = false;
                    dlog.Rank = newRank.Rank;
                    dlog.Level = newRank.Level;
                    dlog.Wins = 0;

                    if (dlog.ShowDialog() != DialogResult.OK)
                        return;

                    sessionData.CurrentRank.Rank = dlog.Rank;
                    sessionData.CurrentRank.Level = dlog.Level;
                    sessionData.CurrentRank.Wins = 0;
                }

                sessionData.Season.Win = 0;
                sessionData.Season.Loss = 0;

                seasonGamesStart = GetGamesRemaining();
            }

            sessionData.Session.Win = 0;
            sessionData.Session.Loss = 0;
            sessionData.Streak = 0;

            sessionStart = DateTime.Now;
            sessionGamesStart = GetGamesRemaining();

            DisplayRank();
        }

        private void SaveData()
        {
            XDocument doc = new XDocument();
            
            XElement root = new XElement("data");
            
            XElement record = new XElement("record");
            record.SetAttributeValue("win", sessionData.Season.Win);
            record.SetAttributeValue("loss", sessionData.Season.Loss);

            XElement ladder = new XElement("ladder");
            ladder.SetAttributeValue("rank", sessionData.CurrentRank.Rank);
            ladder.SetAttributeValue("level", sessionData.CurrentRank.Level);
            ladder.SetAttributeValue("wins", sessionData.CurrentRank.Wins);
            ladder.SetAttributeValue("start", seasonGamesStart);

            XElement mythic = new XElement("mythic");
            mythic.SetAttributeValue("win", sessionData.Mythic.Win);
            mythic.SetAttributeValue("loss", sessionData.Mythic.Loss);

            XElement games = new XElement("games");

            foreach(bool won in resultList)
            {
                XElement game = new XElement("game");
                game.SetAttributeValue("result", won ? "W" : "L");

                games.Add(game);
            }

            doc.Add(root);
            root.Add(record);
            root.Add(ladder);
            root.Add(mythic);
            root.Add(games);

            string path = Path.GetDirectoryName(dataFile);

            if (path != "" && !Directory.Exists(path))
                Directory.CreateDirectory(path);

            doc.Save(dataFile);
        }

        public void LoadData()
        {
            if (!File.Exists(dataFile))
                return;

            sessionData = new SessionData();

            XDocument document = XDocument.Load(dataFile);
            XElement root = document.Element("data");
            XElement record = root.Element("record");
            XElement ladder = root.Element("ladder");
            XElement mythic = root.Element("mythic");
            XElement games = root.Element("games");

            if (record != null)
            {
                sessionData.Season.Win = int.Parse(record.Attribute("win").Value);
                sessionData.Season.Loss = int.Parse(record.Attribute("loss").Value);
            }

            if (ladder != null)
            {
                sessionData.CurrentRank.Rank = int.Parse(ladder.Attribute("rank").Value);
                sessionData.CurrentRank.Level = int.Parse(ladder.Attribute("level").Value);
                sessionData.CurrentRank.Wins = int.Parse(ladder.Attribute("wins").Value);

                if (ladder.Attribute("start") != null)
                    seasonGamesStart = int.Parse(ladder.Attribute("start").Value);
                else
                    seasonGamesStart = GetGamesRemaining();
            }

            if (mythic != null)
            {
                sessionData.Mythic.Win = int.Parse(mythic.Attribute("win").Value);
                sessionData.Mythic.Loss = int.Parse(mythic.Attribute("loss").Value);
            }

            if (games != null)
            {
                foreach (XElement e in games.Elements())
                {
                    resultList.Add(e.Attribute("result").Value == "W");
                }
            }
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
                            DoLoss(1);
                        }

                        if (modifer == (ModiferKey.Control | ModiferKey.Alt))
                        {
                            DoLoss(0);
                        }

                        if(modifer == (ModiferKey.Control | ModiferKey.Shift))
                        {
                            DoLoss(2);
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
            RegisterHotKey(this.Handle, 4, (uint)(ModiferKey.Control | ModiferKey.Shift) , (uint)Keys.OemMinus);

            if (Properties.Settings.Default.OutputPath == "")
                Properties.Settings.Default.OutputPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\MythicTracker";

            LoadData();

            sessionGamesStart = GetGamesRemaining();

            GetSeasonEnd();
            DisplayRank();
            UpdateClock();

            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();

            Properties.Settings.Default.Save();

            for (int i = 0; i < 4; i++)
            {
                UnregisterHotKey(this.Handle, i);
            }
        }

        private void contextMenuItemDecrease_Click(object sender, EventArgs e)
        {
            DoLoss(1);
        }

        private void contextMenuItemNoDecrease_Click(object sender, EventArgs e)
        {
            DoLoss(0);
        }

        private void toolStripButtonWin_ButtonCClick(object sender, EventArgs e)
        {
            DoWin(1);
        }

        private void affectsRankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoLoss(1);
        }

        private void doesNotAffectRankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoLoss(0);
        }

        private void toolStripButtonRank_Click(object sender, EventArgs e)
        {
            using (RankDlog dlog = new RankDlog())
            {
                dlog.Rank = sessionData.CurrentRank.Rank;
                dlog.Level = sessionData.CurrentRank.Level;
                dlog.Wins = sessionData.CurrentRank.Wins;

                if (dlog.ShowDialog() != DialogResult.OK)
                    return;

                sessionData.CurrentRank.Rank = dlog.Rank;
                sessionData.CurrentRank.Level = dlog.Level;
                sessionData.CurrentRank.Wins = dlog.Wins;

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
            DoLoss(1);
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

        private void goBack2StepsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoLoss(2);
        }
    }
}
