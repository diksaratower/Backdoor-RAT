namespace BackdoorClient
{
    partial class FileManager
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
            this.components = new System.ComponentModel.Container();
            this.fidndTaskButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.statsLabel = new System.Windows.Forms.Label();
            this.refreshFilesBut = new System.Windows.Forms.Button();
            this.removeFileButton = new System.Windows.Forms.Button();
            this.filesView = new System.Windows.Forms.TreeView();
            this.startFileBut = new System.Windows.Forms.Button();
            this.resulteText = new System.Windows.Forms.Label();
            this.downloadBut = new System.Windows.Forms.Button();
            this.fileManagmentMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToParentFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileManagmentMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // fidndTaskButton
            // 
            this.fidndTaskButton.Location = new System.Drawing.Point(335, 13);
            this.fidndTaskButton.Name = "fidndTaskButton";
            this.fidndTaskButton.Size = new System.Drawing.Size(67, 22);
            this.fidndTaskButton.TabIndex = 12;
            this.fidndTaskButton.UseVisualStyleBackColor = true;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(45, 15);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(284, 20);
            this.pathTextBox.TabIndex = 11;
            this.pathTextBox.Text = "c:/";
            // 
            // statsLabel
            // 
            this.statsLabel.AutoSize = true;
            this.statsLabel.Location = new System.Drawing.Point(458, 32);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(54, 13);
            this.statsLabel.TabIndex = 10;
            this.statsLabel.Text = "Найдено:";
            // 
            // refreshFilesBut
            // 
            this.refreshFilesBut.Location = new System.Drawing.Point(461, 228);
            this.refreshFilesBut.Name = "refreshFilesBut";
            this.refreshFilesBut.Size = new System.Drawing.Size(119, 26);
            this.refreshFilesBut.TabIndex = 9;
            this.refreshFilesBut.Text = "Обновить список";
            this.refreshFilesBut.UseVisualStyleBackColor = true;
            this.refreshFilesBut.Click += new System.EventHandler(this.refreshFilesBut_Click);
            // 
            // removeFileButton
            // 
            this.removeFileButton.Location = new System.Drawing.Point(461, 292);
            this.removeFileButton.Name = "removeFileButton";
            this.removeFileButton.Size = new System.Drawing.Size(119, 27);
            this.removeFileButton.TabIndex = 8;
            this.removeFileButton.Text = "Удалить";
            this.removeFileButton.UseVisualStyleBackColor = true;
            this.removeFileButton.Click += new System.EventHandler(this.removeFileButton_Click);
            // 
            // filesView
            // 
            this.filesView.ContextMenuStrip = this.fileManagmentMenu;
            this.filesView.Location = new System.Drawing.Point(45, 44);
            this.filesView.Name = "filesView";
            this.filesView.Size = new System.Drawing.Size(357, 275);
            this.filesView.TabIndex = 7;
            // 
            // startFileBut
            // 
            this.startFileBut.Location = new System.Drawing.Point(461, 260);
            this.startFileBut.Name = "startFileBut";
            this.startFileBut.Size = new System.Drawing.Size(119, 26);
            this.startFileBut.TabIndex = 13;
            this.startFileBut.Text = "Запустить";
            this.startFileBut.UseVisualStyleBackColor = true;
            this.startFileBut.Click += new System.EventHandler(this.startFileBut_Click);
            // 
            // resulteText
            // 
            this.resulteText.AutoSize = true;
            this.resulteText.Location = new System.Drawing.Point(458, 66);
            this.resulteText.Name = "resulteText";
            this.resulteText.Size = new System.Drawing.Size(0, 13);
            this.resulteText.TabIndex = 14;
            // 
            // downloadBut
            // 
            this.downloadBut.Location = new System.Drawing.Point(461, 196);
            this.downloadBut.Name = "downloadBut";
            this.downloadBut.Size = new System.Drawing.Size(119, 26);
            this.downloadBut.TabIndex = 15;
            this.downloadBut.Text = "Скачать файл";
            this.downloadBut.UseVisualStyleBackColor = true;
            this.downloadBut.Click += new System.EventHandler(this.downloadBut_Click);
            // 
            // fileManagmentMenu
            // 
            this.fileManagmentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshtoolStripMenuItem,
            this.goToFolderToolStripMenuItem,
            this.goToParentFolderToolStripMenuItem,
            this.downloadToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.startToolStripMenuItem});
            this.fileManagmentMenu.Name = "fileManagmentMenu";
            this.fileManagmentMenu.Size = new System.Drawing.Size(176, 136);
            this.fileManagmentMenu.Opening += new System.ComponentModel.CancelEventHandler(this.fileManagmentMenu_Opening);
            // 
            // RefreshtoolStripMenuItem
            // 
            this.RefreshtoolStripMenuItem.Name = "RefreshtoolStripMenuItem";
            this.RefreshtoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RefreshtoolStripMenuItem.Text = "Обновить";
            this.RefreshtoolStripMenuItem.Click += new System.EventHandler(this.RefreshtoolStripMenuItem_Click);
            // 
            // goToFolderToolStripMenuItem
            // 
            this.goToFolderToolStripMenuItem.Name = "goToFolderToolStripMenuItem";
            this.goToFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goToFolderToolStripMenuItem.Text = "Перейти в папку";
            this.goToFolderToolStripMenuItem.Click += new System.EventHandler(this.goToFolderToolStripMenuItem_Click);
            // 
            // goToParentFolderToolStripMenuItem
            // 
            this.goToParentFolderToolStripMenuItem.Name = "goToParentFolderToolStripMenuItem";
            this.goToParentFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goToParentFolderToolStripMenuItem.Text = "Перейти в р.папку";
            this.goToParentFolderToolStripMenuItem.Click += new System.EventHandler(this.goToParentFolderToolStripMenuItem_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.downloadToolStripMenuItem.Text = "Скачать";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startToolStripMenuItem.Text = "Запустить";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 350);
            this.Controls.Add(this.downloadBut);
            this.Controls.Add(this.resulteText);
            this.Controls.Add(this.startFileBut);
            this.Controls.Add(this.fidndTaskButton);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.statsLabel);
            this.Controls.Add(this.refreshFilesBut);
            this.Controls.Add(this.removeFileButton);
            this.Controls.Add(this.filesView);
            this.Name = "FileManager";
            this.Text = "FileManager";
            this.Load += new System.EventHandler(this.FileManager_Load);
            this.fileManagmentMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fidndTaskButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label statsLabel;
        private System.Windows.Forms.Button refreshFilesBut;
        private System.Windows.Forms.Button removeFileButton;
        private System.Windows.Forms.TreeView filesView;
        private System.Windows.Forms.Button startFileBut;
        private System.Windows.Forms.Label resulteText;
        private System.Windows.Forms.Button downloadBut;
        private System.Windows.Forms.ContextMenuStrip fileManagmentMenu;
        private System.Windows.Forms.ToolStripMenuItem RefreshtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToParentFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
    }
}