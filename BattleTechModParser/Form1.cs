using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BattleTechModParser
{
    public partial class Form1 : Form
    {
        private static string ManifestLocationSetting = "ManifestLocation";
        public Form1()
        {
            InitializeComponent();
            try
            {
                ParserTest.enable();
                ParserTest.disable();
            }
            catch (Exception e)
            {
                MessageBox.Show("There is a problem with the patcher!");
                Environment.Exit(1);
            }
            if (Properties.Settings.Default[ManifestLocationSetting] != null)
            {
                this.file_input.Text = (string) Properties.Settings.Default[ManifestLocationSetting];
            }
            else
            {
                use_default();
            }
        }

        private void use_default()
        {
            var defaultFileGuess = Utils.GetBestFileGuess();
            if (defaultFileGuess != null)
            {
                this.file_input.Text = defaultFileGuess;
            }
        }

        private void select_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSV Files|*.csv";
            dialog.Title = "Select a Manifest File";

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

        private void file_input_TextChanged(object sender, EventArgs e)
        {
            update_settings();
        }

        private void update_settings()
        {
            Properties.Settings.Default[ManifestLocationSetting] = this.file_input.Text;
            Properties.Settings.Default.Save();
        }

        private void use_default_button_Click(object sender, EventArgs e)
        {
            use_default();
        }
    }
}
