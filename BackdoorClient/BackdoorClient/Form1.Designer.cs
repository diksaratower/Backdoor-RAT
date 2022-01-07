namespace BackdoorClient
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectButton = new System.Windows.Forms.Button();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connText = new System.Windows.Forms.Label();
            this.taskMgrButton = new System.Windows.Forms.Button();
            this.sendMesageBut = new System.Windows.Forms.Button();
            this.crashSysButton = new System.Windows.Forms.Button();
            this.filesManagerBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.screenTraslBut = new System.Windows.Forms.Button();
            this.jokesButton = new System.Windows.Forms.Button();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.CmdButton = new System.Windows.Forms.Button();
            this.ConnFromUser = new System.Windows.Forms.Button();
            this.ConnctionUserText = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.ConnectionQueue = new System.Windows.Forms.TreeView();
            this.IpAddrBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(560, 14);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(83, 35);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Подключить";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(484, 14);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(61, 20);
            this.portTextBox.TabIndex = 2;
            this.portTextBox.Text = "7777";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Порт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Адрес:";
            // 
            // connText
            // 
            this.connText.AutoSize = true;
            this.connText.ForeColor = System.Drawing.Color.Crimson;
            this.connText.Location = new System.Drawing.Point(226, 47);
            this.connText.Name = "connText";
            this.connText.Size = new System.Drawing.Size(85, 13);
            this.connText.TabIndex = 5;
            this.connText.Text = "Не подключено";
            // 
            // taskMgrButton
            // 
            this.taskMgrButton.Location = new System.Drawing.Point(484, 117);
            this.taskMgrButton.Name = "taskMgrButton";
            this.taskMgrButton.Size = new System.Drawing.Size(88, 32);
            this.taskMgrButton.TabIndex = 9;
            this.taskMgrButton.Text = "Дисп. задач";
            this.taskMgrButton.UseVisualStyleBackColor = true;
            this.taskMgrButton.Click += new System.EventHandler(this.taskMgrButton_Click);
            // 
            // sendMesageBut
            // 
            this.sendMesageBut.Location = new System.Drawing.Point(484, 171);
            this.sendMesageBut.Name = "sendMesageBut";
            this.sendMesageBut.Size = new System.Drawing.Size(88, 32);
            this.sendMesageBut.TabIndex = 10;
            this.sendMesageBut.Text = "Сообщ. Пол.";
            this.sendMesageBut.UseVisualStyleBackColor = true;
            this.sendMesageBut.Click += new System.EventHandler(this.sendMesageBut_Click);
            // 
            // crashSysButton
            // 
            this.crashSysButton.Location = new System.Drawing.Point(582, 117);
            this.crashSysButton.Name = "crashSysButton";
            this.crashSysButton.Size = new System.Drawing.Size(88, 32);
            this.crashSysButton.TabIndex = 11;
            this.crashSysButton.Text = "Краш. сист";
            this.crashSysButton.UseVisualStyleBackColor = true;
            this.crashSysButton.Click += new System.EventHandler(this.crashSysButton_Click);
            // 
            // filesManagerBut
            // 
            this.filesManagerBut.Location = new System.Drawing.Point(582, 171);
            this.filesManagerBut.Name = "filesManagerBut";
            this.filesManagerBut.Size = new System.Drawing.Size(88, 32);
            this.filesManagerBut.TabIndex = 12;
            this.filesManagerBut.Text = "Файлы";
            this.filesManagerBut.UseVisualStyleBackColor = true;
            this.filesManagerBut.Click += new System.EventHandler(this.filesManagerBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "(вним. очень\r\nопасно)";
            // 
            // screenTraslBut
            // 
            this.screenTraslBut.Location = new System.Drawing.Point(582, 223);
            this.screenTraslBut.Name = "screenTraslBut";
            this.screenTraslBut.Size = new System.Drawing.Size(88, 32);
            this.screenTraslBut.TabIndex = 14;
            this.screenTraslBut.Text = "Трансл Экран";
            this.screenTraslBut.UseVisualStyleBackColor = true;
            this.screenTraslBut.Click += new System.EventHandler(this.screenTraslBut_Click);
            // 
            // jokesButton
            // 
            this.jokesButton.Location = new System.Drawing.Point(484, 223);
            this.jokesButton.Name = "jokesButton";
            this.jokesButton.Size = new System.Drawing.Size(88, 32);
            this.jokesButton.TabIndex = 15;
            this.jokesButton.Text = "Приколы";
            this.jokesButton.UseVisualStyleBackColor = true;
            this.jokesButton.Click += new System.EventHandler(this.jokesButton_Click);
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Location = new System.Drawing.Point(649, 14);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(77, 35);
            this.DisconnectBtn.TabIndex = 16;
            this.DisconnectBtn.Text = "Отключить";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // CmdButton
            // 
            this.CmdButton.Location = new System.Drawing.Point(582, 270);
            this.CmdButton.Name = "CmdButton";
            this.CmdButton.Size = new System.Drawing.Size(88, 32);
            this.CmdButton.TabIndex = 17;
            this.CmdButton.Text = "Консоль";
            this.CmdButton.UseVisualStyleBackColor = true;
            this.CmdButton.Click += new System.EventHandler(this.CmdButton_Click);
            // 
            // ConnFromUser
            // 
            this.ConnFromUser.Location = new System.Drawing.Point(12, 341);
            this.ConnFromUser.Name = "ConnFromUser";
            this.ConnFromUser.Size = new System.Drawing.Size(89, 31);
            this.ConnFromUser.TabIndex = 22;
            this.ConnFromUser.Text = "Подключить";
            this.ConnFromUser.UseVisualStyleBackColor = true;
            this.ConnFromUser.Click += new System.EventHandler(this.ConnFromUser_Click);
            // 
            // ConnctionUserText
            // 
            this.ConnctionUserText.AutoSize = true;
            this.ConnctionUserText.Location = new System.Drawing.Point(3, 0);
            this.ConnctionUserText.Name = "ConnctionUserText";
            this.ConnctionUserText.Size = new System.Drawing.Size(93, 13);
            this.ConnctionUserText.TabIndex = 0;
            this.ConnctionUserText.Text = "Пока ничего нет.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Подключить:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.ConnctionUserText);
            this.panel1.Location = new System.Drawing.Point(15, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 20);
            this.panel1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Подключения макс:";
            // 
            // ConnectionQueue
            // 
            this.ConnectionQueue.BackColor = System.Drawing.Color.White;
            this.ConnectionQueue.Location = new System.Drawing.Point(12, 80);
            this.ConnectionQueue.Name = "ConnectionQueue";
            this.ConnectionQueue.Size = new System.Drawing.Size(311, 201);
            this.ConnectionQueue.TabIndex = 19;
            // 
            // IpAddrBox
            // 
            this.IpAddrBox.FormattingEnabled = true;
            this.IpAddrBox.Location = new System.Drawing.Point(229, 14);
            this.IpAddrBox.Name = "IpAddrBox";
            this.IpAddrBox.Size = new System.Drawing.Size(183, 21);
            this.IpAddrBox.TabIndex = 23;
            this.IpAddrBox.Text = "127.0.0.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 395);
            this.Controls.Add(this.IpAddrBox);
            this.Controls.Add(this.ConnFromUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ConnectionQueue);
            this.Controls.Add(this.CmdButton);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.jokesButton);
            this.Controls.Add(this.screenTraslBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filesManagerBut);
            this.Controls.Add(this.crashSysButton);
            this.Controls.Add(this.sendMesageBut);
            this.Controls.Add(this.taskMgrButton);
            this.Controls.Add(this.connText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.ConnectButton);
            this.Name = "Form1";
            this.Text = "Копытень RAT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label connText;
        private System.Windows.Forms.Button taskMgrButton;
        private System.Windows.Forms.Button sendMesageBut;
        private System.Windows.Forms.Button crashSysButton;
        private System.Windows.Forms.Button filesManagerBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button screenTraslBut;
        private System.Windows.Forms.Button jokesButton;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.Button CmdButton;
        private System.Windows.Forms.Button ConnFromUser;
        private System.Windows.Forms.Label ConnctionUserText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView ConnectionQueue;
        private System.Windows.Forms.ComboBox IpAddrBox;
    }
}

