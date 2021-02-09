
namespace FilesZipper
{
    partial class Index
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCompress = new System.Windows.Forms.TabPage();
            this.lbTotalNumber = new System.Windows.Forms.Label();
            this.lbTotalFiles = new System.Windows.Forms.Label();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnZip = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.lbFileDirectory = new System.Windows.Forms.Label();
            this.btnOpenDirectory = new System.Windows.Forms.Button();
            this.tabDecompress = new System.Windows.Forms.TabPage();
            this.btnUnzip = new System.Windows.Forms.Button();
            this.btnAddUnZip = new System.Windows.Forms.Button();
            this.txtUnZipDirectory = new System.Windows.Forms.TextBox();
            this.lbUnZipDirectory = new System.Windows.Forms.Label();
            this.btnOpenUnZip = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCompress.SuspendLayout();
            this.tabDecompress.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCompress);
            this.tabControl1.Controls.Add(this.tabDecompress);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(544, 341);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCompress
            // 
            this.tabCompress.Controls.Add(this.lbTotalNumber);
            this.tabCompress.Controls.Add(this.lbTotalFiles);
            this.tabCompress.Controls.Add(this.lstFiles);
            this.tabCompress.Controls.Add(this.btnZip);
            this.tabCompress.Controls.Add(this.btnAdd);
            this.tabCompress.Controls.Add(this.txtDirectory);
            this.tabCompress.Controls.Add(this.lbFileDirectory);
            this.tabCompress.Controls.Add(this.btnOpenDirectory);
            this.tabCompress.Location = new System.Drawing.Point(4, 22);
            this.tabCompress.Name = "tabCompress";
            this.tabCompress.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompress.Size = new System.Drawing.Size(536, 315);
            this.tabCompress.TabIndex = 0;
            this.tabCompress.Text = "Compress";
            this.tabCompress.UseVisualStyleBackColor = true;
            // 
            // lbTotalNumber
            // 
            this.lbTotalNumber.AutoSize = true;
            this.lbTotalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalNumber.Location = new System.Drawing.Point(96, 229);
            this.lbTotalNumber.Name = "lbTotalNumber";
            this.lbTotalNumber.Size = new System.Drawing.Size(16, 16);
            this.lbTotalNumber.TabIndex = 10;
            this.lbTotalNumber.Text = "0";
            // 
            // lbTotalFiles
            // 
            this.lbTotalFiles.AutoSize = true;
            this.lbTotalFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFiles.Location = new System.Drawing.Point(29, 229);
            this.lbTotalFiles.Name = "lbTotalFiles";
            this.lbTotalFiles.Size = new System.Drawing.Size(69, 16);
            this.lbTotalFiles.TabIndex = 9;
            this.lbTotalFiles.Text = "Total files:";
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(31, 66);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(454, 160);
            this.lstFiles.TabIndex = 7;
            // 
            // btnZip
            // 
            this.btnZip.BackColor = System.Drawing.Color.White;
            this.btnZip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZip.Location = new System.Drawing.Point(222, 273);
            this.btnZip.Name = "btnZip";
            this.btnZip.Size = new System.Drawing.Size(75, 23);
            this.btnZip.TabIndex = 6;
            this.btnZip.Text = "Done";
            this.btnZip.UseVisualStyleBackColor = false;
            this.btnZip.Click += new System.EventHandler(this.btnZip_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(492, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(32, 40);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(454, 20);
            this.txtDirectory.TabIndex = 2;
            // 
            // lbFileDirectory
            // 
            this.lbFileDirectory.AutoSize = true;
            this.lbFileDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileDirectory.Location = new System.Drawing.Point(28, 21);
            this.lbFileDirectory.Name = "lbFileDirectory";
            this.lbFileDirectory.Size = new System.Drawing.Size(234, 16);
            this.lbFileDirectory.TabIndex = 1;
            this.lbFileDirectory.Text = "Select the directory with the files to Zip.";
            // 
            // btnOpenDirectory
            // 
            this.btnOpenDirectory.BackColor = System.Drawing.Color.White;
            this.btnOpenDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDirectory.Location = new System.Drawing.Point(492, 37);
            this.btnOpenDirectory.Name = "btnOpenDirectory";
            this.btnOpenDirectory.Size = new System.Drawing.Size(30, 23);
            this.btnOpenDirectory.TabIndex = 0;
            this.btnOpenDirectory.Text = "...";
            this.btnOpenDirectory.UseVisualStyleBackColor = false;
            this.btnOpenDirectory.Click += new System.EventHandler(this.btnOpenDirectory_Click);
            // 
            // tabDecompress
            // 
            this.tabDecompress.Controls.Add(this.btnUnzip);
            this.tabDecompress.Controls.Add(this.btnAddUnZip);
            this.tabDecompress.Controls.Add(this.txtUnZipDirectory);
            this.tabDecompress.Controls.Add(this.lbUnZipDirectory);
            this.tabDecompress.Controls.Add(this.btnOpenUnZip);
            this.tabDecompress.Location = new System.Drawing.Point(4, 22);
            this.tabDecompress.Name = "tabDecompress";
            this.tabDecompress.Padding = new System.Windows.Forms.Padding(3);
            this.tabDecompress.Size = new System.Drawing.Size(536, 315);
            this.tabDecompress.TabIndex = 1;
            this.tabDecompress.Text = "Decompress";
            this.tabDecompress.UseVisualStyleBackColor = true;
            // 
            // btnUnzip
            // 
            this.btnUnzip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnzip.Location = new System.Drawing.Point(222, 273);
            this.btnUnzip.Name = "btnUnzip";
            this.btnUnzip.Size = new System.Drawing.Size(75, 23);
            this.btnUnzip.TabIndex = 11;
            this.btnUnzip.Text = "Done";
            this.btnUnzip.UseVisualStyleBackColor = true;
            this.btnUnzip.Click += new System.EventHandler(this.btnUnzip_Click);
            // 
            // btnAddUnZip
            // 
            this.btnAddUnZip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUnZip.Location = new System.Drawing.Point(492, 66);
            this.btnAddUnZip.Name = "btnAddUnZip";
            this.btnAddUnZip.Size = new System.Drawing.Size(30, 23);
            this.btnAddUnZip.TabIndex = 10;
            this.btnAddUnZip.Text = "+";
            this.btnAddUnZip.UseVisualStyleBackColor = true;
            this.btnAddUnZip.Click += new System.EventHandler(this.btnAddUnZip_Click);
            // 
            // txtUnZipDirectory
            // 
            this.txtUnZipDirectory.Location = new System.Drawing.Point(32, 40);
            this.txtUnZipDirectory.Name = "txtUnZipDirectory";
            this.txtUnZipDirectory.Size = new System.Drawing.Size(454, 20);
            this.txtUnZipDirectory.TabIndex = 9;
            // 
            // lbUnZipDirectory
            // 
            this.lbUnZipDirectory.AutoSize = true;
            this.lbUnZipDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnZipDirectory.Location = new System.Drawing.Point(28, 21);
            this.lbUnZipDirectory.Name = "lbUnZipDirectory";
            this.lbUnZipDirectory.Size = new System.Drawing.Size(163, 16);
            this.lbUnZipDirectory.TabIndex = 8;
            this.lbUnZipDirectory.Text = "Select the Zip file to Unzip.";
            // 
            // btnOpenUnZip
            // 
            this.btnOpenUnZip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenUnZip.Location = new System.Drawing.Point(492, 37);
            this.btnOpenUnZip.Name = "btnOpenUnZip";
            this.btnOpenUnZip.Size = new System.Drawing.Size(30, 23);
            this.btnOpenUnZip.TabIndex = 7;
            this.btnOpenUnZip.Text = "...";
            this.btnOpenUnZip.UseVisualStyleBackColor = true;
            this.btnOpenUnZip.Click += new System.EventHandler(this.btnOpenUnZip_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 341);
            this.Controls.Add(this.tabControl1);
            this.Name = "Index";
            this.Text = "FileZipper";
            this.tabControl1.ResumeLayout(false);
            this.tabCompress.ResumeLayout(false);
            this.tabCompress.PerformLayout();
            this.tabDecompress.ResumeLayout(false);
            this.tabDecompress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCompress;
        private System.Windows.Forms.TabPage tabDecompress;
        private System.Windows.Forms.Button btnOpenDirectory;
        private System.Windows.Forms.Button btnZip;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label lbFileDirectory;
        private System.Windows.Forms.Button btnUnzip;
        private System.Windows.Forms.Button btnAddUnZip;
        private System.Windows.Forms.TextBox txtUnZipDirectory;
        private System.Windows.Forms.Label lbUnZipDirectory;
        private System.Windows.Forms.Button btnOpenUnZip;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Label lbTotalNumber;
        private System.Windows.Forms.Label lbTotalFiles;
    }
}

