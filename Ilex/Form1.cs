using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace Ilex
{
    public partial class IlexForm : Form
    {
        public IlexForm()
        {
            InitializeComponent();
            textBoxUsername.Text = Properties.Settings.Default.Username;
            textBoxPassword.Text = Properties.Settings.Default.Password;
            textBoxServerName.Text = Properties.Settings.Default.ServerName;
            textBoxSaveLocation.Text = Properties.Settings.Default.SaveLocation;
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            ServerConnection myConnection = new ServerConnection();
            myConnection.LoginSecure = false;
            myConnection.ServerInstance = Properties.Settings.Default.ServerName;
            myConnection.Login = Properties.Settings.Default.Username;
            myConnection.Password = Properties.Settings.Default.Password;

            Server myServer = new Server(myConnection);

            try
            {
                myServer.ConnectionContext.Connect();
            }
            catch (Exception ex)
            {
                textBoxNotifications.Text = ex.Message;
                //throw;
            }

            Database myDatabase = new Database();
            myDatabase.Name = "Adips2010";

            Backup bkpDBFull = new Backup();
            /* Specify whether you want to back up database or files or log */
            bkpDBFull.Action = BackupActionType.Database;
            /* Specify the name of the database to back up */
            bkpDBFull.Database = myDatabase.Name;
            /* You can take backup on several media type (disk or tape), here I am
             * using File type and storing backup on the file system */
            bkpDBFull.Devices.AddDevice(@Properties.Settings.Default.SaveLocation, DeviceType.File);
            bkpDBFull.BackupSetName = "Adips2010 database Backup";
            bkpDBFull.BackupSetDescription = "Adips2010 database - Full Backup";

            /* You can specify Initialize = false (default) to create a new 
             * backup set which will be appended as last backup set on the media. You
             * can specify Initialize = true to make the backup as first set on the
             * medium and to overwrite any other existing backup sets if the all the
             * backup sets have expired and specified backup set name matches with
             * the name on the medium */
            bkpDBFull.Initialize = false;

            /* Wiring up events for progress monitoring */
            //bkpDBFull.PercentComplete += CompletionStatusInPercent;
            //bkpDBFull.Complete += Backup_Completed;

            /* SqlBackup method starts to take back up
             * You can also use SqlBackupAsync method to perform the backup 
             * operation asynchronously */
            bkpDBFull.SqlBackup(myServer);
            textBoxNotifications.Text = "Yay, I made a backup :)";
            System.Diagnostics.Process.Start("explorer.exe", "/select, " + textBoxSaveLocation.Text);



            ////Connect to the local, default instance of SQL Server. 
            //Server srv = new Server();
            ////Reference the Adips2010 database. 
            //Database db = new Database(); // default(Database);
            //db = srv.Databases["Adips2010"];

            ////Define a Backup object variable. 
            //Backup bk = new Backup();

            ////Specify the type of backup, the description, the name, and the database to be backed up. 
            //bk.Action = BackupActionType.Database;
            //bk.Devices.AddDevice(@"E:\Adips2010.bak", DeviceType.File);
            //bk.BackupSetDescription = "Full backup of Adips2010";
            //bk.BackupSetName = "Adips2010 Backup";
            //bk.Database = "Adips2010";

            ////Declare a BackupDeviceItem by supplying the backup device file name in the constructor, and the type of device is a file. 
            //BackupDeviceItem bdi = default(BackupDeviceItem);
            //bdi = new BackupDeviceItem("Full_Backup_Adips2010", DeviceType.File);

            ////Add the device to the Backup object. 
            //bk.Devices.Add(bdi);
            ////Set the Incremental property to False to specify that this is a full database backup. 
            //bk.Incremental = false;

            ////Run SqlBackup to perform the full database backup on the instance of SQL Server. 
            //bk.SqlBackup(srv);

            ////Remove the backup device from the Backup object. 
            //bk.Devices.Remove(bdi);

            ////Remove the backup files from the hard disk.
            ////This location is dependent on the installation of SQL Server
            ////File.Delete("C:\\Program Files\\Microsoft SQL Server\\MSSQL11.MSSQLSERVER\\MSSQL\\Backup\\Test_Full_Backup1");
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = textBoxUsername.Text;
            Properties.Settings.Default.Password = textBoxPassword.Text;
            Properties.Settings.Default.ServerName = textBoxServerName.Text;
            Properties.Settings.Default.Save();
        }

        private void buttonSelectLocation_Click(object sender, EventArgs e)
        {
            SaveFileDialog mySaveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "myBackup";
            saveFileDialog.DefaultExt = "bak";
            saveFileDialog.Filter = "Backup Files | *.bak";
            saveFileDialog.ShowDialog();

            textBoxSaveLocation.Text = saveFileDialog.FileName;
            Properties.Settings.Default.SaveLocation = textBoxSaveLocation.Text;
            Properties.Settings.Default.Save();
        }
    }
}
