namespace MythicTracker
{
    partial class RankDlog
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRank = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSet = new System.Windows.Forms.Button();
            this.panelLevel = new System.Windows.Forms.Panel();
            this.upDownWins = new System.Windows.Forms.NumericUpDown();
            this.labelWins = new System.Windows.Forms.Label();
            this.upDownLevel = new System.Windows.Forms.NumericUpDown();
            this.labelLevel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownWins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rank:";
            // 
            // comboBoxRank
            // 
            this.comboBoxRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRank.FormattingEnabled = true;
            this.comboBoxRank.Items.AddRange(new object[] {
            "Bronze",
            "Silver",
            "Gold",
            "Platinum",
            "Diamond",
            "Mythic"});
            this.comboBoxRank.Location = new System.Drawing.Point(17, 29);
            this.comboBoxRank.Name = "comboBoxRank";
            this.comboBoxRank.Size = new System.Drawing.Size(229, 23);
            this.comboBoxRank.TabIndex = 1;
            this.comboBoxRank.SelectedIndexChanged += new System.EventHandler(this.comboBoxRank_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonSet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 50);
            this.panel1.TabIndex = 6;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(179, 14);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSet
            // 
            this.buttonSet.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSet.Location = new System.Drawing.Point(98, 14);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 8;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            // 
            // panelLevel
            // 
            this.panelLevel.Controls.Add(this.upDownWins);
            this.panelLevel.Controls.Add(this.labelWins);
            this.panelLevel.Controls.Add(this.upDownLevel);
            this.panelLevel.Controls.Add(this.labelLevel);
            this.panelLevel.Location = new System.Drawing.Point(12, 72);
            this.panelLevel.Name = "panelLevel";
            this.panelLevel.Size = new System.Drawing.Size(234, 60);
            this.panelLevel.TabIndex = 7;
            // 
            // upDownWins
            // 
            this.upDownWins.Location = new System.Drawing.Point(85, 22);
            this.upDownWins.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.upDownWins.Name = "upDownWins";
            this.upDownWins.Size = new System.Drawing.Size(58, 23);
            this.upDownWins.TabIndex = 9;
            // 
            // labelWins
            // 
            this.labelWins.AutoSize = true;
            this.labelWins.Location = new System.Drawing.Point(81, 4);
            this.labelWins.Name = "labelWins";
            this.labelWins.Size = new System.Drawing.Size(36, 15);
            this.labelWins.TabIndex = 8;
            this.labelWins.Text = "Wins:";
            // 
            // upDownLevel
            // 
            this.upDownLevel.Location = new System.Drawing.Point(5, 22);
            this.upDownLevel.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.upDownLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownLevel.Name = "upDownLevel";
            this.upDownLevel.Size = new System.Drawing.Size(58, 23);
            this.upDownLevel.TabIndex = 7;
            this.upDownLevel.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(2, 4);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(37, 15);
            this.labelLevel.TabIndex = 6;
            this.labelLevel.Text = "Level:";
            // 
            // RankDlog
            // 
            this.AcceptButton = this.buttonSet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(266, 213);
            this.Controls.Add(this.panelLevel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxRank);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RankDlog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Rank";
            this.Load += new System.EventHandler(this.RankDlog_Load);
            this.panel1.ResumeLayout(false);
            this.panelLevel.ResumeLayout(false);
            this.panelLevel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownWins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRank;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Panel panelLevel;
        private System.Windows.Forms.NumericUpDown upDownWins;
        private System.Windows.Forms.Label labelWins;
        private System.Windows.Forms.NumericUpDown upDownLevel;
        private System.Windows.Forms.Label labelLevel;
    }
}