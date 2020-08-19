namespace Liller_Backup_Tool
{
    partial class MainForm
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
            this.butOpen = new System.Windows.Forms.Button();
            this.butBackup = new System.Windows.Forms.Button();
            this.buPath = new System.Windows.Forms.TextBox();
            this.uploadedTableGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.butDelete = new System.Windows.Forms.Button();
            this.footerLabel = new System.Windows.Forms.LinkLabel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.ftpHost = new System.Windows.Forms.TextBox();
            this.ftpUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ftpPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.uploadedTableGrid)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder being uploaded";
            // 
            // butOpen
            // 
            this.butOpen.Location = new System.Drawing.Point(9, 97);
            this.butOpen.Name = "butOpen";
            this.butOpen.Size = new System.Drawing.Size(100, 23);
            this.butOpen.TabIndex = 1;
            this.butOpen.Text = "Select Folder";
            this.butOpen.UseVisualStyleBackColor = true;
            this.butOpen.Click += new System.EventHandler(this.butOpen_Click_1);
            // 
            // butBackup
            // 
            this.butBackup.Location = new System.Drawing.Point(9, 137);
            this.butBackup.Name = "butBackup";
            this.butBackup.Size = new System.Drawing.Size(100, 23);
            this.butBackup.TabIndex = 2;
            this.butBackup.Text = "Start Upload";
            this.butBackup.UseVisualStyleBackColor = true;
            this.butBackup.Click += new System.EventHandler(this.butBackup_Click);
            // 
            // buPath
            // 
            this.buPath.Location = new System.Drawing.Point(9, 49);
            this.buPath.Name = "buPath";
            this.buPath.ReadOnly = true;
            this.buPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.buPath.Size = new System.Drawing.Size(206, 20);
            this.buPath.TabIndex = 4;
            this.buPath.Text = "C:\\Users\\%USERNAME%\\Documents";
            // 
            // uploadedTableGrid
            // 
            this.uploadedTableGrid.AllowUserToAddRows = false;
            this.uploadedTableGrid.AllowUserToDeleteRows = false;
            this.uploadedTableGrid.AllowUserToResizeColumns = false;
            this.uploadedTableGrid.AllowUserToResizeRows = false;
            this.uploadedTableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uploadedTableGrid.ColumnHeadersVisible = false;
            this.uploadedTableGrid.Location = new System.Drawing.Point(253, 49);
            this.uploadedTableGrid.Name = "uploadedTableGrid";
            this.uploadedTableGrid.RowHeadersVisible = false;
            this.uploadedTableGrid.Size = new System.Drawing.Size(161, 150);
            this.uploadedTableGrid.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Uploaded Files";
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(115, 137);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(100, 23);
            this.butDelete.TabIndex = 8;
            this.butDelete.Text = "Delete Local Files";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // footerLabel
            // 
            this.footerLabel.AutoSize = true;
            this.footerLabel.Location = new System.Drawing.Point(250, 211);
            this.footerLabel.Name = "footerLabel";
            this.footerLabel.Size = new System.Drawing.Size(164, 13);
            this.footerLabel.TabIndex = 9;
            this.footerLabel.TabStop = true;
            this.footerLabel.Text = "Mattias Lahtinen | LAHTINEN.CC";
            this.footerLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.footerLabel_LinkClicked);
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(1, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(494, 293);
            this.tabControl2.TabIndex = 10;
            // 
            // tabPage4
            // 
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage4.Controls.Add(this.pBar1);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.footerLabel);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.butDelete);
            this.tabPage4.Controls.Add(this.uploadedTableGrid);
            this.tabPage4.Controls.Add(this.buPath);
            this.tabPage4.Controls.Add(this.butOpen);
            this.tabPage4.Controls.Add(this.butBackup);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(486, 264);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Home";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(486, 264);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Settings";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Host";
            // 
            // ftpHost
            // 
            this.ftpHost.Location = new System.Drawing.Point(12, 31);
            this.ftpHost.Name = "ftpHost";
            this.ftpHost.Size = new System.Drawing.Size(140, 20);
            this.ftpHost.TabIndex = 2;
            // 
            // ftpUser
            // 
            this.ftpUser.Location = new System.Drawing.Point(13, 70);
            this.ftpUser.Name = "ftpUser";
            this.ftpUser.Size = new System.Drawing.Size(140, 20);
            this.ftpUser.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username";
            // 
            // ftpPass
            // 
            this.ftpPass.Location = new System.Drawing.Point(13, 109);
            this.ftpPass.Name = "ftpPass";
            this.ftpPass.Size = new System.Drawing.Size(140, 20);
            this.ftpPass.TabIndex = 4;
            this.ftpPass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ftpPass);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ftpUser);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ftpHost);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(7, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 145);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FTP Settings";
            // 
            // pBar1
            // 
            this.pBar1.Location = new System.Drawing.Point(9, 175);
            this.pBar1.Name = "pBar1";
            this.pBar1.Size = new System.Drawing.Size(206, 24);
            this.pBar1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 296);
            this.Controls.Add(this.tabControl2);
            this.Name = "MainForm";
            this.Text = "Liller Backup Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uploadedTableGrid)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butOpen;
        private System.Windows.Forms.Button butBackup;
        private System.Windows.Forms.TextBox buPath;
        private System.Windows.Forms.DataGridView uploadedTableGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.LinkLabel footerLabel;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ftpPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ftpUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ftpHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pBar1;
    }
}

