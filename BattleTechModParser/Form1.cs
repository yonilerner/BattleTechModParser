using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BattleTechModParser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void select_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV Files|*.csv";
            dialog.Title = "Select a VersionManifest File";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.file_input.Text = dialog.FileName;
            }
        }

        private void patch_button_handler(bool enable)
        {
            var path = this.file_input.Text;
            if (!File.Exists(path))
            {
                MessageBox.Show("File \"" + path + "\" does not exist.");
                return;
            }
            try
            {
                Parser.PatchFile(path, enable);
                MessageBox.Show("File patched!");
            }
            catch (IOException e)
            {
                MessageBox.Show("Couldnt patch the file. Make sure no other programs are using it");
            }
        }

        private void patch_button_Click(object sender, EventArgs e)
        {
            patch_button_handler(true);
        }

        private void unpatch_button_Click(object sender, EventArgs e)
        {
            patch_button_handler(false);
        }
    }
}
