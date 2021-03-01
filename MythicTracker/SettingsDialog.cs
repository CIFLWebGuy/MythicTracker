using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MythicTracker
{
    public partial class SettingsDialog : Form
    {
        /// <summary>
        /// Gets/sets the path of the output file.
        /// </summary>
        public string OutputPath
        {
            get
            {
                return textBoxPath.Text;
            }
            set
            {
                textBoxPath.Text = value;
            }
        }

        /// <summary>
        /// Initalizes a SettingsDialog object.
        /// </summary>
        public SettingsDialog()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog dlog = new FolderBrowserDialog())
            {
                dlog.Description = "Select the folder to place the output files.";
                dlog.ShowNewFolderButton = true;
                dlog.SelectedPath = Properties.Settings.Default.OutputPath;
                
                if (dlog.ShowDialog() == DialogResult.OK)
                {
                    textBoxPath.Text = dlog.SelectedPath;
                }
            }
        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            textBoxPath.Text = Properties.Settings.Default.OutputPath;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(textBoxPath.Text == "")
            {
                MessageBox.Show("Please enter a path to save the output files.", "Save Settings");
                textBoxPath.Focus();
            }

            DialogResult = DialogResult.OK;
        }
    }
}
