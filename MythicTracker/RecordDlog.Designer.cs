namespace MythicTracker
{
    partial class RecordDlog
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
            this.upDownWin = new System.Windows.Forms.NumericUpDown();
            this.upDownLoss = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.upDownSeasonWin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.upDownSeasonLoss = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxStreak = new System.Windows.Forms.ComboBox();
            this.upDownStreak = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.upDownMythicWin = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.upDownMythicLoss = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upDownWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLoss)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSeasonWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSeasonLoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownStreak)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMythicWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMythicLoss)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wins:";
            // 
            // upDownWin
            // 
            this.upDownWin.Location = new System.Drawing.Point(6, 38);
            this.upDownWin.Name = "upDownWin";
            this.upDownWin.Size = new System.Drawing.Size(55, 23);
            this.upDownWin.TabIndex = 1;
            // 
            // upDownLoss
            // 
            this.upDownLoss.Location = new System.Drawing.Point(67, 38);
            this.upDownLoss.Name = "upDownLoss";
            this.upDownLoss.Size = new System.Drawing.Size(55, 23);
            this.upDownLoss.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Losses:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 50);
            this.panel1.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(334, 15);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(253, 15);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.upDownWin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.upDownLoss);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Session";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.upDownSeasonWin);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.upDownSeasonLoss);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(147, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Season";
            // 
            // upDownSeasonWin
            // 
            this.upDownSeasonWin.Location = new System.Drawing.Point(6, 38);
            this.upDownSeasonWin.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.upDownSeasonWin.Name = "upDownSeasonWin";
            this.upDownSeasonWin.Size = new System.Drawing.Size(55, 23);
            this.upDownSeasonWin.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Wins:";
            // 
            // upDownSeasonLoss
            // 
            this.upDownSeasonLoss.Location = new System.Drawing.Point(67, 38);
            this.upDownSeasonLoss.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.upDownSeasonLoss.Name = "upDownSeasonLoss";
            this.upDownSeasonLoss.Size = new System.Drawing.Size(55, 23);
            this.upDownSeasonLoss.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Losses:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Streak:";
            // 
            // comboBoxStreak
            // 
            this.comboBoxStreak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStreak.FormattingEnabled = true;
            this.comboBoxStreak.Items.AddRange(new object[] {
            "Win",
            "Loss"});
            this.comboBoxStreak.Location = new System.Drawing.Point(12, 129);
            this.comboBoxStreak.Name = "comboBoxStreak";
            this.comboBoxStreak.Size = new System.Drawing.Size(84, 23);
            this.comboBoxStreak.TabIndex = 3;
            // 
            // upDownStreak
            // 
            this.upDownStreak.Location = new System.Drawing.Point(102, 129);
            this.upDownStreak.Name = "upDownStreak";
            this.upDownStreak.Size = new System.Drawing.Size(55, 23);
            this.upDownStreak.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.upDownMythicWin);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.upDownMythicLoss);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(282, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 73);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mythic";
            // 
            // upDownMythicWin
            // 
            this.upDownMythicWin.Location = new System.Drawing.Point(6, 38);
            this.upDownMythicWin.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.upDownMythicWin.Name = "upDownMythicWin";
            this.upDownMythicWin.Size = new System.Drawing.Size(55, 23);
            this.upDownMythicWin.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Wins:";
            // 
            // upDownMythicLoss
            // 
            this.upDownMythicLoss.Location = new System.Drawing.Point(67, 38);
            this.upDownMythicLoss.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.upDownMythicLoss.Name = "upDownMythicLoss";
            this.upDownMythicLoss.Size = new System.Drawing.Size(55, 23);
            this.upDownMythicLoss.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Losses:";
            // 
            // RecordDlog
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(421, 239);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.upDownStreak);
            this.Controls.Add(this.comboBoxStreak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordDlog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Record";
            this.Load += new System.EventHandler(this.RecordDlog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upDownWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownLoss)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSeasonWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownSeasonLoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownStreak)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMythicWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMythicLoss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown upDownWin;
        private System.Windows.Forms.NumericUpDown upDownLoss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown upDownSeasonWin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown upDownSeasonLoss;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStreak;
        private System.Windows.Forms.NumericUpDown upDownStreak;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown upDownMythicWin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown upDownMythicLoss;
        private System.Windows.Forms.Label label7;
    }
}