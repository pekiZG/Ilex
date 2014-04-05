namespace Ilex
{
    partial class IlexForm
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSync = new System.Windows.Forms.TabPage();
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.groupBoxCategories = new System.Windows.Forms.GroupBox();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.tabPageBackup = new System.Windows.Forms.TabPage();
            this.buttonSelectLocation = new System.Windows.Forms.Button();
            this.textBoxSaveLocation = new System.Windows.Forms.TextBox();
            this.groupBoxNotifications = new System.Windows.Forms.GroupBox();
            this.textBoxNotifications = new System.Windows.Forms.TextBox();
            this.BackupButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.labelWhereToBackup = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageSync.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            this.tabPageBackup.SuspendLayout();
            this.groupBoxNotifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 419);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(624, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(624, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageSync);
            this.tabControl.Controls.Add(this.tabPageBackup);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(624, 395);
            this.tabControl.TabIndex = 2;
            // 
            // tabPageSync
            // 
            this.tabPageSync.Controls.Add(this.groupBoxProducts);
            this.tabPageSync.Controls.Add(this.groupBoxCategories);
            this.tabPageSync.Controls.Add(this.groupBoxSettings);
            this.tabPageSync.Location = new System.Drawing.Point(4, 22);
            this.tabPageSync.Name = "tabPageSync";
            this.tabPageSync.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSync.Size = new System.Drawing.Size(616, 369);
            this.tabPageSync.TabIndex = 0;
            this.tabPageSync.Text = "Sync";
            this.tabPageSync.UseVisualStyleBackColor = true;
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Location = new System.Drawing.Point(9, 114);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Size = new System.Drawing.Size(200, 100);
            this.groupBoxProducts.TabIndex = 2;
            this.groupBoxProducts.TabStop = false;
            this.groupBoxProducts.Text = "Products";
            // 
            // groupBoxCategories
            // 
            this.groupBoxCategories.Location = new System.Drawing.Point(9, 7);
            this.groupBoxCategories.Name = "groupBoxCategories";
            this.groupBoxCategories.Size = new System.Drawing.Size(200, 100);
            this.groupBoxCategories.TabIndex = 1;
            this.groupBoxCategories.TabStop = false;
            this.groupBoxCategories.Text = "Categories";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.textBoxServerName);
            this.groupBoxSettings.Controls.Add(this.labelServer);
            this.groupBoxSettings.Controls.Add(this.buttonSaveSettings);
            this.groupBoxSettings.Controls.Add(this.textBoxPassword);
            this.groupBoxSettings.Controls.Add(this.labelPassword);
            this.groupBoxSettings.Controls.Add(this.textBoxUsername);
            this.groupBoxSettings.Controls.Add(this.labelUsername);
            this.groupBoxSettings.Location = new System.Drawing.Point(408, 7);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(200, 208);
            this.groupBoxSettings.TabIndex = 0;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(84, 35);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(100, 20);
            this.textBoxServerName.TabIndex = 6;
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(20, 38);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(41, 13);
            this.labelServer.TabIndex = 5;
            this.labelServer.Text = "Server:";
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(63, 148);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveSettings.TabIndex = 4;
            this.buttonSaveSettings.Text = "Save";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(84, 88);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(20, 91);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(84, 61);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(20, 64);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username:";
            // 
            // tabPageBackup
            // 
            this.tabPageBackup.Controls.Add(this.labelWhereToBackup);
            this.tabPageBackup.Controls.Add(this.buttonSelectLocation);
            this.tabPageBackup.Controls.Add(this.textBoxSaveLocation);
            this.tabPageBackup.Controls.Add(this.groupBoxNotifications);
            this.tabPageBackup.Controls.Add(this.BackupButton);
            this.tabPageBackup.Location = new System.Drawing.Point(4, 22);
            this.tabPageBackup.Name = "tabPageBackup";
            this.tabPageBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBackup.Size = new System.Drawing.Size(616, 369);
            this.tabPageBackup.TabIndex = 1;
            this.tabPageBackup.Text = "Backup";
            this.tabPageBackup.UseVisualStyleBackColor = true;
            // 
            // buttonSelectLocation
            // 
            this.buttonSelectLocation.Location = new System.Drawing.Point(278, 56);
            this.buttonSelectLocation.Name = "buttonSelectLocation";
            this.buttonSelectLocation.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectLocation.TabIndex = 3;
            this.buttonSelectLocation.Text = "Select";
            this.buttonSelectLocation.UseVisualStyleBackColor = true;
            this.buttonSelectLocation.Click += new System.EventHandler(this.buttonSelectLocation_Click);
            // 
            // textBoxSaveLocation
            // 
            this.textBoxSaveLocation.Location = new System.Drawing.Point(172, 58);
            this.textBoxSaveLocation.Name = "textBoxSaveLocation";
            this.textBoxSaveLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxSaveLocation.TabIndex = 2;
            // 
            // groupBoxNotifications
            // 
            this.groupBoxNotifications.Controls.Add(this.textBoxNotifications);
            this.groupBoxNotifications.Location = new System.Drawing.Point(448, 6);
            this.groupBoxNotifications.Name = "groupBoxNotifications";
            this.groupBoxNotifications.Size = new System.Drawing.Size(160, 120);
            this.groupBoxNotifications.TabIndex = 1;
            this.groupBoxNotifications.TabStop = false;
            this.groupBoxNotifications.Text = "Notifications";
            // 
            // textBoxNotifications
            // 
            this.textBoxNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNotifications.Location = new System.Drawing.Point(3, 16);
            this.textBoxNotifications.Multiline = true;
            this.textBoxNotifications.Name = "textBoxNotifications";
            this.textBoxNotifications.Size = new System.Drawing.Size(154, 101);
            this.textBoxNotifications.TabIndex = 0;
            // 
            // BackupButton
            // 
            this.BackupButton.Location = new System.Drawing.Point(451, 132);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(75, 23);
            this.BackupButton.TabIndex = 0;
            this.BackupButton.Text = "Backup";
            this.BackupButton.UseVisualStyleBackColor = true;
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // labelWhereToBackup
            // 
            this.labelWhereToBackup.AutoSize = true;
            this.labelWhereToBackup.Location = new System.Drawing.Point(73, 61);
            this.labelWhereToBackup.Name = "labelWhereToBackup";
            this.labelWhereToBackup.Size = new System.Drawing.Size(93, 13);
            this.labelWhereToBackup.TabIndex = 4;
            this.labelWhereToBackup.Text = "Where to backup:";
            // 
            // IlexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "IlexForm";
            this.Text = "Ilex d.o.o. - Administration Tools (ver.1.0.0.6)";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageSync.ResumeLayout(false);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.tabPageBackup.ResumeLayout(false);
            this.tabPageBackup.PerformLayout();
            this.groupBoxNotifications.ResumeLayout(false);
            this.groupBoxNotifications.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageSync;
        private System.Windows.Forms.TabPage tabPageBackup;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.GroupBox groupBoxCategories;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.GroupBox groupBoxNotifications;
        private System.Windows.Forms.TextBox textBoxNotifications;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Button buttonSelectLocation;
        private System.Windows.Forms.TextBox textBoxSaveLocation;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label labelWhereToBackup;
    }
}

