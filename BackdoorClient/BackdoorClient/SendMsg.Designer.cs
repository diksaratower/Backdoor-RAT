namespace BackdoorClient
{
    partial class SendMsg
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
            this.choseButtons = new System.Windows.Forms.ComboBox();
            this.choseIcon = new System.Windows.Forms.ComboBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.mesageText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choseButtons
            // 
            this.choseButtons.FormattingEnabled = true;
            this.choseButtons.ItemHeight = 13;
            this.choseButtons.Items.AddRange(new object[] {
            "Ок",
            "Ок, Отмена",
            "Отменить Повторить, Отмена",
            "Да, Нет, Отменить",
            "Да, Нет",
            "Да, Отменить"});
            this.choseButtons.Location = new System.Drawing.Point(311, 211);
            this.choseButtons.Name = "choseButtons";
            this.choseButtons.Size = new System.Drawing.Size(148, 21);
            this.choseButtons.TabIndex = 0;
            this.choseButtons.Text = "Ок";
            // 
            // choseIcon
            // 
            this.choseIcon.FormattingEnabled = true;
            this.choseIcon.ItemHeight = 13;
            this.choseIcon.Items.AddRange(new object[] {
            "Звездочка",
            "Ошибка",
            "Восклицание",
            "Рука",
            "Информация",
            "Без иконки",
            "Вопрос",
            "Остановка",
            "Опастность"});
            this.choseIcon.Location = new System.Drawing.Point(28, 72);
            this.choseIcon.Name = "choseIcon";
            this.choseIcon.Size = new System.Drawing.Size(115, 21);
            this.choseIcon.TabIndex = 1;
            this.choseIcon.Text = "Ошибка";
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(28, 27);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(101, 20);
            this.Subject.TabIndex = 2;
            this.Subject.Text = "Хацкер";
            // 
            // mesageText
            // 
            this.mesageText.Location = new System.Drawing.Point(56, 124);
            this.mesageText.Multiline = true;
            this.mesageText.Name = "mesageText";
            this.mesageText.Size = new System.Drawing.Size(301, 59);
            this.mesageText.TabIndex = 3;
            this.mesageText.Text = "Привет братан 😎";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Подпись:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Иконка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Текст сообщения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кнопки:";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(297, 55);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(153, 52);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // SendMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 244);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mesageText);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.choseIcon);
            this.Controls.Add(this.choseButtons);
            this.Name = "SendMsg";
            this.Text = "SendMsg";
            this.Load += new System.EventHandler(this.SendMsg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox choseButtons;
        private System.Windows.Forms.ComboBox choseIcon;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.TextBox mesageText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sendButton;
    }
}