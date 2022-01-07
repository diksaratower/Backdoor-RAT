namespace BackdoorClient
{
    partial class ScreenViewStream
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
            this.translScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.translScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // translScreen
            // 
            this.translScreen.Location = new System.Drawing.Point(12, 12);
            this.translScreen.Name = "translScreen";
            this.translScreen.Size = new System.Drawing.Size(1140, 641);
            this.translScreen.TabIndex = 0;
            this.translScreen.TabStop = false;
            this.translScreen.Click += new System.EventHandler(this.translScreen_Click);
            // 
            // ScreenViewStream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 659);
            this.Controls.Add(this.translScreen);
            this.Name = "ScreenViewStream";
            this.Text = "ScreenViewStream";
            this.Load += new System.EventHandler(this.ScreenViewStream_Load);
            ((System.ComponentModel.ISupportInitialize)(this.translScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox translScreen;
    }
}