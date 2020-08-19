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
            ((System.ComponentModel.ISupportInitialize)(this.uploadedTableGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder being uploaded";
            // 
            // butOpen
            // 
            this.butOpen.Location = new System.Drawing.Point(24, 111);
            this.butOpen.Name = "butOpen";
            this.butOpen.Size = new System.Drawing.Size(100, 23);
            this.butOpen.TabIndex = 1;
            this.butOpen.Text = "Select Folder";
            this.butOpen.UseVisualStyleBackColor = true;
            this.butOpen.Click += new System.EventHandler(this.butOpen_Click_1);
            // 
            // butBackup
            // 
            this.butBackup.Location = new System.Drawing.Point(24, 161);
            this.butBackup.Name = "butBackup";
            this.butBackup.Size = new System.Drawing.Size(100, 23);
            this.butBackup.TabIndex = 2;
            this.butBackup.Text = "Start Upload";
            this.butBackup.UseVisualStyleBackColor = true;
            this.butBackup.Click += new System.EventHandler(this.butBackup_Click);
            // 
            // buPath
            // 
            this.buPath.Location = new System.Drawing.Point(24, 61);
            this.buPath.Multiline = true;
            this.buPath.Name = "buPath";
            this.buPath.ReadOnly = true;
            this.buPath.Size = new System.Drawing.Size(206, 31);
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
            this.uploadedTableGrid.Location = new System.Drawing.Point(294, 61);
            this.uploadedTableGrid.Name = "uploadedTableGrid";
            this.uploadedTableGrid.RowHeadersVisible = false;
            this.uploadedTableGrid.Size = new System.Drawing.Size(161, 150);
            this.uploadedTableGrid.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Uploaded Files";
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(130, 161);
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
            this.footerLabel.Location = new System.Drawing.Point(294, 254);
            this.footerLabel.Name = "footerLabel";
            this.footerLabel.Size = new System.Drawing.Size(164, 13);
            this.footerLabel.TabIndex = 9;
            this.footerLabel.TabStop = true;
            this.footerLabel.Text = "Mattias Lahtinen | LAHTINEN.CC";
            this.footerLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.footerLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 292);
            this.Controls.Add(this.footerLabel);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uploadedTableGrid);
            this.Controls.Add(this.buPath);
            this.Controls.Add(this.butBackup);
            this.Controls.Add(this.butOpen);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Liller Backup Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uploadedTableGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

