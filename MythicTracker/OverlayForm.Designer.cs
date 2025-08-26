namespace MythicTracker
{
    partial class OverlayForm
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
            this.labelSession = new System.Windows.Forms.Label();
            this.labelStreak = new System.Windows.Forms.Label();
            this.labelSeason = new System.Windows.Forms.Label();
            this.labelRank = new System.Windows.Forms.Label();
            this.labelSteps = new System.Windows.Forms.Label();
            this.labelLast10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSession
            // 
            this.labelSession.AutoSize = true;
            this.labelSession.Font = new System.Drawing.Font("Beleren Small Caps", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSession.Location = new System.Drawing.Point(10, 20);
            this.labelSession.Name = "labelSession";
            this.labelSession.Size = new System.Drawing.Size(149, 28);
            this.labelSession.TabIndex = 0;
            this.labelSession.Text = "Session: 0-0";
            // 
            // labelStreak
            // 
            this.labelStreak.AutoSize = true;
            this.labelStreak.Font = new System.Drawing.Font("Beleren Small Caps", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStreak.Location = new System.Drawing.Point(197, 20);
            this.labelStreak.Name = "labelStreak";
            this.labelStreak.Size = new System.Drawing.Size(180, 28);
            this.labelStreak.TabIndex = 1;
            this.labelStreak.Text = "Streak: Lose 10";
            // 
            // labelSeason
            // 
            this.labelSeason.AutoSize = true;
            this.labelSeason.Font = new System.Drawing.Font("Beleren Small Caps", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeason.Location = new System.Drawing.Point(427, 20);
            this.labelSeason.Name = "labelSeason";
            this.labelSeason.Size = new System.Drawing.Size(144, 28);
            this.labelSeason.TabIndex = 2;
            this.labelSeason.Text = "Season: 0-0";
            // 
            // labelRank
            // 
            this.labelRank.AutoSize = true;
            this.labelRank.Font = new System.Drawing.Font("Beleren Small Caps", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRank.Location = new System.Drawing.Point(651, 20);
            this.labelRank.Name = "labelRank";
            this.labelRank.Size = new System.Drawing.Size(131, 28);
            this.labelRank.TabIndex = 3;
            this.labelRank.Text = "Diamond 4";
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Font = new System.Drawing.Font("Beleren Small Caps", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSteps.Location = new System.Drawing.Point(1114, 20);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(240, 28);
            this.labelSteps.TabIndex = 4;
            this.labelSteps.Text = "Steps remaining: 120";
            // 
            // labelLast10
            // 
            this.labelLast10.AutoSize = true;
            this.labelLast10.Font = new System.Drawing.Font("Beleren Small Caps", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLast10.Location = new System.Drawing.Point(847, 20);
            this.labelLast10.Name = "labelLast10";
            this.labelLast10.Size = new System.Drawing.Size(154, 28);
            this.labelLast10.TabIndex = 5;
            this.labelLast10.Text = "Last 10: 10-0";
            // 
            // OverlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 67);
            this.ControlBox = false;
            this.Controls.Add(this.labelLast10);
            this.Controls.Add(this.labelSteps);
            this.Controls.Add(this.labelRank);
            this.Controls.Add(this.labelSeason);
            this.Controls.Add(this.labelStreak);
            this.Controls.Add(this.labelSession);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OverlayForm";
            this.Text = "Stat Overlay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSession;
        private System.Windows.Forms.Label labelStreak;
        private System.Windows.Forms.Label labelSeason;
        private System.Windows.Forms.Label labelRank;
        private System.Windows.Forms.Label labelSteps;
        private System.Windows.Forms.Label labelLast10;
    }
}