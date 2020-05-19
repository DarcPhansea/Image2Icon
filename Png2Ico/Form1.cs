using Png2Ico.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Png2Ico {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            if (Settings.Default.filePath.Length == 0) {
                Settings.Default.filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            }
            this.openImgDialog.DefaultExt = "png";
            this.openImgDialog.Filter = "Image files (*.png *.jpg ...)|*.png;*.jpg;*.jpeg;*.tif;*.tiff;*.bmp;*.raw|All files (*.*)|*.*";
        }

        private void btnGetFile_Click(object sender, EventArgs e) {
            this.openImgDialog.InitialDirectory = Settings.Default.filePath;

            if (this.openImgDialog.ShowDialog() != DialogResult.OK) return;
             
            if (this.openImgDialog.CheckFileExists) {
                txtImage.Text = this.openImgDialog.FileName;
                txtIco.Text = Path.GetFileNameWithoutExtension(txtImage.Text) + ".ico";
                Settings.Default.filePath = Path.GetDirectoryName(txtImage.Text);
                Settings.Default.Save();
            } else {
                MessageBox.Show("Invalid File!");
            }
        }

        private void btnConvert_Click(object sender, EventArgs e) {
            if (txtImage.Text != string.Empty) {
                Converter.Convert(txtImage.Text, $"{Settings.Default.filePath}\\{txtIco.Text}", (float)sizePercent.Value, chkRatio.Checked);

                MessageBox.Show("File Saved!");
            } else {
                MessageBox.Show("Cannot Convert, File is invalid!");
            }

        }
    }
}
