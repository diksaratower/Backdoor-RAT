namespace BackdoorClient
{
    partial class RemouteCmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemouteCmd));
            this.sendButton = new System.Windows.Forms.Button();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.responseText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.consoleText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(386, 268);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(106, 36);
            this.sendButton.TabIndex = 11;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // commandTextBox
            // 
            this.commandTextBox.AcceptsReturn = true;
            this.commandTextBox.Location = new System.Drawing.Point(9, 277);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(371, 20);
            this.commandTextBox.TabIndex = 10;
            this.commandTextBox.TextChanged += new System.EventHandler(this.commandTextBox_TextChanged);
            // 
            // responseText
            // 
            this.responseText.AutoSize = true;
            this.responseText.Location = new System.Drawing.Point(12, 10);
            this.responseText.Name = "responseText";
            this.responseText.Size = new System.Drawing.Size(0, 13);
            this.responseText.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.consoleText);
            this.panel1.Controls.Add(this.responseText);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 231);
            this.panel1.TabIndex = 13;
            // 
            // consoleText
            // 
            this.consoleText.AutoSize = true;
            this.consoleText.Location = new System.Drawing.Point(15, 10);
            this.consoleText.MaximumSize = new System.Drawing.Size(440, 0);
            this.consoleText.Name = "consoleText";
            this.consoleText.Size = new System.Drawing.Size(439, 52);
            this.consoleText.TabIndex = 10;
            this.consoleText.Text = resources.GetString("consoleText.Text");
            // 
            // RemouteCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 325);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.commandTextBox);
            this.Name = "RemouteCmd";
            this.Text = "Cmd";
            this.Load += new System.EventHandler(this.RemouteCmd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.Label responseText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label consoleText;
    }
}