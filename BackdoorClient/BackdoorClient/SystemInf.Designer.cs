namespace BackdoorClient
{
    partial class SystemInf
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
            this.updateBut = new System.Windows.Forms.Button();
            this.SysNameLabel = new System.Windows.Forms.Label();
            this.SystemTimeLabel = new System.Windows.Forms.Label();
            this.ipAddrLabel = new System.Windows.Forms.Label();
            this.usNameLabel = new System.Windows.Forms.Label();
            this.numBuildLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateBut
            // 
            this.updateBut.Location = new System.Drawing.Point(422, 206);
            this.updateBut.Name = "updateBut";
            this.updateBut.Size = new System.Drawing.Size(93, 38);
            this.updateBut.TabIndex = 0;
            this.updateBut.Text = "Обновить";
            this.updateBut.UseVisualStyleBackColor = true;
            this.updateBut.Click += new System.EventHandler(this.updateBut_Click);
            // 
            // SysNameLabel
            // 
            this.SysNameLabel.AutoSize = true;
            this.SysNameLabel.Location = new System.Drawing.Point(28, 33);
            this.SysNameLabel.Name = "SysNameLabel";
            this.SysNameLabel.Size = new System.Drawing.Size(54, 13);
            this.SysNameLabel.TabIndex = 1;
            this.SysNameLabel.Text = "Система:";
            // 
            // SystemTimeLabel
            // 
            this.SystemTimeLabel.AutoSize = true;
            this.SystemTimeLabel.Location = new System.Drawing.Point(28, 84);
            this.SystemTimeLabel.Name = "SystemTimeLabel";
            this.SystemTimeLabel.Size = new System.Drawing.Size(101, 13);
            this.SystemTimeLabel.TabIndex = 2;
            this.SystemTimeLabel.Text = "Системное время:";
            // 
            // ipAddrLabel
            // 
            this.ipAddrLabel.AutoSize = true;
            this.ipAddrLabel.Location = new System.Drawing.Point(28, 119);
            this.ipAddrLabel.Name = "ipAddrLabel";
            this.ipAddrLabel.Size = new System.Drawing.Size(58, 13);
            this.ipAddrLabel.TabIndex = 3;
            this.ipAddrLabel.Text = "Ip аддрес:";
            // 
            // usNameLabel
            // 
            this.usNameLabel.AutoSize = true;
            this.usNameLabel.Location = new System.Drawing.Point(28, 148);
            this.usNameLabel.Name = "usNameLabel";
            this.usNameLabel.Size = new System.Drawing.Size(83, 13);
            this.usNameLabel.TabIndex = 4;
            this.usNameLabel.Text = "Пользователь:";
            // 
            // numBuildLabel
            // 
            this.numBuildLabel.AutoSize = true;
            this.numBuildLabel.Location = new System.Drawing.Point(28, 61);
            this.numBuildLabel.Name = "numBuildLabel";
            this.numBuildLabel.Size = new System.Drawing.Size(77, 13);
            this.numBuildLabel.TabIndex = 5;
            this.numBuildLabel.Text = "Номер билда:";
            // 
            // SystemInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 256);
            this.Controls.Add(this.numBuildLabel);
            this.Controls.Add(this.usNameLabel);
            this.Controls.Add(this.ipAddrLabel);
            this.Controls.Add(this.SystemTimeLabel);
            this.Controls.Add(this.SysNameLabel);
            this.Controls.Add(this.updateBut);
            this.Name = "SystemInf";
            this.Text = "SystemInf";
            this.Load += new System.EventHandler(this.SystemInf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateBut;
        private System.Windows.Forms.Label SysNameLabel;
        private System.Windows.Forms.Label SystemTimeLabel;
        private System.Windows.Forms.Label ipAddrLabel;
        private System.Windows.Forms.Label usNameLabel;
        private System.Windows.Forms.Label numBuildLabel;
    }
}