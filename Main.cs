using System;
using System.Data;
using System.Timers;
using System.Windows.Forms;
using WinSCP;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;


namespace Liller_Backup_Tool
{
    public partial class MainForm : Form
    {
       

        //create data table
        DataTable table;
        public MainForm()
        {
            InitializeComponent();
            
        }


       

        //form load
        private void MainForm_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Files Uploaded", typeof(String));

            uploadedTableGrid.DataSource = table;
            uploadedTableGrid.Columns["Files Uploaded"].Width = 300;
        }

        

        //------------------ EVENT OBJECTS ------------------ //



        //select folder button
        private void butOpen_Click_1(object sender, EventArgs e)
        {
            selectDirectory();
        }


        //upload button
        private void butBackup_Click(object sender, EventArgs e)
        {
            fileUpload();
        }


        //delete button
        private void butDelete_Click(object sender, EventArgs e)
        {
            deleteFiles();
        }


        //footer link label
        private void footerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            visitLink();
        }


        //------------------ EVENT TRIGGER METHODS ------------------ //


       //select folder method
        private void selectDirectory()
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users\\%USERNAME%\\Documents";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                buPath.Text = dialog.FileName;
            }
        }


        //upload method
        private void fileUpload()
        {
            SessionOptions sessionOptions = new SessionOptions
            {
                Protocol = Protocol.Ftp,
                HostName = @ftpHost.Text, 
                UserName = @ftpUser.Text, 
                Password = @ftpPass.Text, 


            };

            using (Session session = new Session())
            {

                // Connect
                session.Open(sessionOptions);
                session.FileTransferred += FileTransferred;
                //progress
  

                // Synchronize files
                SynchronizationResult synchronizationResult;
                synchronizationResult =
                    session.SynchronizeDirectories(
                        SynchronizationMode.Remote, @buPath.Text, "/backup", false); // "/backup" can be modified to desired path on remote server

    }
        }


        //delete files method
        private void deleteFiles()
        {
            string path = @buPath.Text;

            DirectoryInfo directory = new DirectoryInfo(path);

            foreach (FileInfo file in directory.EnumerateFiles())
            {
                file.Delete();
            }

            foreach (DirectoryInfo dir in directory.EnumerateDirectories())
            {
                dir.Delete(true);
            }
        }


        //click footer link method
        private void visitLink()
        {
            // Change the color of the link text by setting LinkVisited to true.
            // footerLabel.LinkVisited = true;

            //open link
            System.Diagnostics.Process.Start("https://lahtinen.cc");
        }


        //uploaded files table method
        private void FileTransferred(object sender, TransferEventArgs e)
        {

            table.Rows.Add(e.FileName);
        }

    }
}

