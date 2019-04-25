using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ArmA_Template_Finder
{
    public partial class MainForm : Form
    {
        private Properties.Settings Settings { get { return Properties.Settings.Default; } }
        private List<string> Templates = new List<string>();


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(Settings.LastFile))
                tbTerrainBuilderFile.Text = Settings.LastFile;
            if (!String.IsNullOrWhiteSpace(Settings.LastTemplatePath))
                tbTemplateFolder.Text = Settings.LastTemplatePath;

            tbTerrainBuilderFile.TextChanged += textBox_TextChanged;
            tbTemplateFolder.TextChanged += textBox_TextChanged;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Settings.LastFile = tbTerrainBuilderFile.Text;
            Settings.LastTemplatePath = tbTemplateFolder.Text;

            Settings.Save();
            Settings.Reload();
        }

        private void btnTBFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                tbTerrainBuilderFile.Text = openFileDialog.FileName;
        }

        private void btnTemplFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                tbTemplateFolder.Text = folderBrowserDialog.SelectedPath;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Settings.LastFile) || !Directory.Exists(Settings.LastTemplatePath))
            {
                MessageBox.Show(String.Format("{0} does not exist!", (!File.Exists(Settings.LastFile)) ? "The TerrainBuilder file" : "The Template folder")
                    , "Error!"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);

                return;
            }

            EnableControls(false);

            Templates.Clear();
            lbFoundItems.Items.Clear();

            foreach (string file in Directory.GetFiles(Settings.LastTemplatePath, "*.tml"))
            {
                var xml = XDocument.Load(file);

                Templates.AddRange(from c in xml.Root.Descendants("Template")
                                   select c.Element("Name").Value.ToLower());
            }

            List<string> fileEntries = new List<string>();

            using (StreamReader sr = new StreamReader(Settings.LastFile))
            {
                string line;
                string entry;
                while ((line = sr.ReadLine()) != null)
                {
                    entry = line.Substring(1, line.IndexOf(';') - 2);

                    if (!fileEntries.Contains(entry))
                        fileEntries.Add(entry.ToLower());
                }
            }

            foreach (string entry in fileEntries)
            {
                if (!Templates.Contains(entry) && !lbFoundItems.Items.Contains(entry))
                    lbFoundItems.Items.Add(entry);
            }

            if (lbFoundItems.Items.Count == 0)
                MessageBox.Show("No missing templates found!");

            EnableControls(true);
        }

        void EnableControls(bool value)
        {
            this.tbTerrainBuilderFile.Enabled = value;
            this.tbTemplateFolder.Enabled = value;
            this.btnFind.Enabled = value;
            this.btnTBFile.Enabled = value;
            this.btnTemplFolder.Enabled = value;
        }

        private void contextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (lbFoundItems.SelectedIndex < 0)
            {
                e.Cancel = true;
                return;
            }
        }

        private void menuCopy_Click(object sender, EventArgs e)
        {
            if (lbFoundItems.SelectedIndex < 0)
                return;

            Clipboard.SetText(lbFoundItems.SelectedItem.ToString());
        }
       

        private void menuDelete_Click(object sender, EventArgs e)
        {
            if (lbFoundItems.SelectedIndex < 0)
                return;

            lbFoundItems.Items.RemoveAt(lbFoundItems.SelectedIndex);
        }
    }
}
