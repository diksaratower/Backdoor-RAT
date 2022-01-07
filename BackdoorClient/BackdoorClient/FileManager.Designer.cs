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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fidndTaskButton
            // 
            this.fidndTaskButton.Location = new System.Drawing.Point(264, 14);
            this.fidndTaskButton.Name = "fidndTaskButton";
            this.fidndTaskButton.Size = new System.Drawing.Size(67, 22);
            this.fidndTaskButton.TabIndex = 12;
            this.fidndTaskButton.UseVisualStyleBackColor = true;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(45, 15);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(213, 20);
            this.pathTextBox.TabIndex = 11;
            this.pathTextBox.Text = "c:/";
            // 
            // statsLabel
            // 
            this.statsLabel.AutoSize = true;
            this.statsLabel.Location = new System.Drawing.Point(374, 23);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(54, 13);
            this.statsLabel.TabIndex = 10;
            this.statsLabel.Text = "Найдено:";
            // 
            // refreshFilesBut
            // 
            this.refreshFilesBut.Location = new System.Drawing.Point(377, 219);
            this.refreshFilesBut.Name = "refreshFilesBut";
            this.refreshFilesBut.Size = new System.Drawing.Size(119, 26);
            this.refreshFilesBut.TabIndex = 9;
            this.refreshFilesBut.Text = "Обновить список";
            this.refreshFilesBut.UseVisualStyleBackColor = true;
            this.refreshFilesBut.Click += new System.EventHandler(this.refreshFilesBut_Click);
            // 
            // removeFileButton
            // 
            this.removeFileButton.Location = new System.Drawing.Point(377, 283);
            this.removeFileButton.Name = "removeFileButton";
            this.removeFileButton.Size = new System.Drawing.Size(119, 27);
            this.removeFileButton.TabIndex = 8;
            this.removeFileButton.Text = "Удалить";
            this.removeFileButton.UseVisualStyleBackColor = true;
            this.removeFileButton.Click += new System.EventHandler(this.removeFileButton_Click);
            // 
            // filesView
            // 
            this.filesView.Location = new System.Drawing.Point(45, 44);
            this.filesView.Name = "filesView";
            this.filesView.Size = new System.Drawing.Size(286, 266);
            this.filesView.TabIndex = 7;
            // 
            // startFileBut
            // 
            this.startFileBut.Location = new System.Drawing.Point(377, 251);
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
            this.resulteText.Location = new System.Drawing.Point(374, 57);
            this.resulteText.Name = "resulteText";
            this.resulteText.Size = new System.Drawing.Size(0, 13);
            this.resulteText.TabIndex = 14;
            // 
            // downloadBut
            // 
            this.downloadBut.Location = new System.Drawing.Point(377, 187);
            this.downloadBut.Name = "downloadBut";
            this.downloadBut.Size = new System.Drawing.Size(119, 26);
            this.downloadBut.TabIndex = 15;
            this.downloadBut.Text = "Скачать файл";
            this.downloadBut.UseVisualStyleBackColor = true;
            this.downloadBut.Click += new System.EventHandler(this.downloadBut_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripSeparator1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 120);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "toolStripMenuItem4";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 325);
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
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}