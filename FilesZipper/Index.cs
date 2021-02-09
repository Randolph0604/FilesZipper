using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesZipper
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        #region Compress
        private void btnOpenDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.SelectedPath = @"C:\Users\Rando\OneDrive\Desktop";
                if (fbd.ShowDialog().Equals(DialogResult.OK))
                {
                    txtDirectory.Text = fbd.SelectedPath;
                    lstFiles.Items.AddRange(Directory.GetFiles(txtDirectory.Text, "*.*"));
                    lbTotalNumber.Text = lstFiles.Items.Count.ToString();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnZip_Click(object sender, EventArgs e)
        {      
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save Zip file";
                sfd.Filter = "Zip files|*.zip";
                sfd.InitialDirectory = @"C:\Users\Rando\OneDrive\Desktop";
                if (sfd.ShowDialog().Equals(DialogResult.OK))
                {
                    ZipFile.CreateFromDirectory(txtDirectory.Text, sfd.FileName);
                    MessageBox.Show("Files were compressed successfully", "Notice");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDirectory.Clear();
            lbTotalNumber.Text = "0";
            lstFiles.Items.Clear();
        }
        #endregion

        #region UnCompress
        private void btnOpenUnZip_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Open Zip file";
                ofd.Filter = "Zip files|*.zip";
                ofd.InitialDirectory = @"C:\Users\Rando\OneDrive\Desktop";
                if (ofd.ShowDialog().Equals(DialogResult.OK))
                {
                    txtUnZipDirectory.Text = ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void btnUnzip_Click(object sender, EventArgs e)
        {
            try
            {
                string route = Path.GetDirectoryName(txtUnZipDirectory.Text) + "\\" + Path.GetFileNameWithoutExtension(txtUnZipDirectory.Text);
                if (!Directory.Exists(route)) Directory.CreateDirectory(route);
                ZipFile.ExtractToDirectory(txtUnZipDirectory.Text, route);
                MessageBox.Show("Files were descompressed successfully", "Notice");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddUnZip_Click(object sender, EventArgs e)
        {
            txtUnZipDirectory.Clear();
        }
        #endregion
    }
}
