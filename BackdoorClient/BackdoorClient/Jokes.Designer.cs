namespace BackdoorClient
{
    partial class Jokes
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
            this.lockMouse = new System.Windows.Forms.Button();
            this.unLockMouse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearScreen = new System.Windows.Forms.Button();
            this.dirtyScreen = new System.Windows.Forms.Button();
            this.dirtyScreenValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.moveDirtyWindows = new System.Windows.Forms.CheckBox();
            this.shutdownMachine = new System.Windows.Forms.Button();
            this.disebleTaskMgr = new System.Windows.Forms.Button();
            this.enebleTaskMgr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.blockMachine = new System.Windows.Forms.Button();
            this.unblockMachine = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.getSysInfBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dirtyScreenValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lockMouse
            // 
            this.lockMouse.Location = new System.Drawing.Point(12, 38);
            this.lockMouse.Name = "lockMouse";
            this.lockMouse.Size = new System.Drawing.Size(89, 37);
            this.lockMouse.TabIndex = 0;
            this.lockMouse.Text = "Заморз. Мышь";
            this.lockMouse.UseVisualStyleBackColor = true;
            this.lockMouse.Click += new System.EventHandler(this.lockMouse_Click);
            // 
            // unLockMouse
            // 
            this.unLockMouse.Location = new System.Drawing.Point(107, 38);
            this.unLockMouse.Name = "unLockMouse";
            this.unLockMouse.Size = new System.Drawing.Size(89, 37);
            this.unLockMouse.TabIndex = 1;
            this.unLockMouse.Text = "Разморз. Мышь";
            this.unLockMouse.UseVisualStyleBackColor = true;
            this.unLockMouse.Click += new System.EventHandler(this.unLockMouse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Мышь:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Замусорить экран:";
            // 
            // clearScreen
            // 
            this.clearScreen.Location = new System.Drawing.Point(521, 22);
            this.clearScreen.Name = "clearScreen";
            this.clearScreen.Size = new System.Drawing.Size(62, 37);
            this.clearScreen.TabIndex = 4;
            this.clearScreen.Text = "Очистить";
            this.clearScreen.UseVisualStyleBackColor = true;
            this.clearScreen.Click += new System.EventHandler(this.clearScreen_Click);
            // 
            // dirtyScreen
            // 
            this.dirtyScreen.Location = new System.Drawing.Point(453, 22);
            this.dirtyScreen.Name = "dirtyScreen";
            this.dirtyScreen.Size = new System.Drawing.Size(62, 37);
            this.dirtyScreen.TabIndex = 5;
            this.dirtyScreen.Text = "Замусорить";
            this.dirtyScreen.UseVisualStyleBackColor = true;
            this.dirtyScreen.Click += new System.EventHandler(this.dirtyScreen_Click);
            // 
            // dirtyScreenValue
            // 
            this.dirtyScreenValue.Location = new System.Drawing.Point(266, 66);
            this.dirtyScreenValue.Name = "dirtyScreenValue";
            this.dirtyScreenValue.Size = new System.Drawing.Size(80, 20);
            this.dirtyScreenValue.TabIndex = 6;
            this.dirtyScreenValue.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кол-во окон:";
            // 
            // moveDirtyWindows
            // 
            this.moveDirtyWindows.AutoSize = true;
            this.moveDirtyWindows.Checked = true;
            this.moveDirtyWindows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.moveDirtyWindows.Location = new System.Drawing.Point(376, 69);
            this.moveDirtyWindows.Name = "moveDirtyWindows";
            this.moveDirtyWindows.Size = new System.Drawing.Size(119, 17);
            this.moveDirtyWindows.TabIndex = 8;
            this.moveDirtyWindows.Text = "Передвигать окна";
            this.moveDirtyWindows.UseVisualStyleBackColor = true;
            // 
            // shutdownMachine
            // 
            this.shutdownMachine.Location = new System.Drawing.Point(12, 102);
            this.shutdownMachine.Name = "shutdownMachine";
            this.shutdownMachine.Size = new System.Drawing.Size(111, 42);
            this.shutdownMachine.TabIndex = 9;
            this.shutdownMachine.Text = "Выключить уд. машину";
            this.shutdownMachine.UseVisualStyleBackColor = true;
            this.shutdownMachine.Click += new System.EventHandler(this.shutdownMachine_Click);
            // 
            // disebleTaskMgr
            // 
            this.disebleTaskMgr.Location = new System.Drawing.Point(158, 92);
            this.disebleTaskMgr.Name = "disebleTaskMgr";
            this.disebleTaskMgr.Size = new System.Drawing.Size(115, 23);
            this.disebleTaskMgr.TabIndex = 10;
            this.disebleTaskMgr.Text = "Выкл. дисп.Задач";
            this.disebleTaskMgr.UseVisualStyleBackColor = true;
            this.disebleTaskMgr.Click += new System.EventHandler(this.disebleTaskMgr_Click);
            // 
            // enebleTaskMgr
            // 
            this.enebleTaskMgr.Location = new System.Drawing.Point(158, 121);
            this.enebleTaskMgr.Name = "enebleTaskMgr";
            this.enebleTaskMgr.Size = new System.Drawing.Size(115, 23);
            this.enebleTaskMgr.TabIndex = 11;
            this.enebleTaskMgr.Text = "Вкыл. дисп.Задач";
            this.enebleTaskMgr.UseVisualStyleBackColor = true;
            this.enebleTaskMgr.Click += new System.EventHandler(this.enebleTaskMgr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Заблокировать уд. машину:";
            // 
            // blockMachine
            // 
            this.blockMachine.Location = new System.Drawing.Point(18, 223);
            this.blockMachine.Name = "blockMachine";
            this.blockMachine.Size = new System.Drawing.Size(75, 23);
            this.blockMachine.TabIndex = 13;
            this.blockMachine.Text = "Блок.";
            this.blockMachine.UseVisualStyleBackColor = true;
            this.blockMachine.Click += new System.EventHandler(this.blockMachine_Click);
            // 
            // unblockMachine
            // 
            this.unblockMachine.Location = new System.Drawing.Point(118, 222);
            this.unblockMachine.Name = "unblockMachine";
            this.unblockMachine.Size = new System.Drawing.Size(75, 23);
            this.unblockMachine.TabIndex = 14;
            this.unblockMachine.Text = "Разблок.";
            this.unblockMachine.UseVisualStyleBackColor = true;
            this.unblockMachine.Click += new System.EventHandler(this.unblockMachine_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Мышка встаёт в 0, 0 дисп. отключен,\r\nвсе ока свёрнуты, рабочего стола нет";
            // 
            // getSysInfBut
            // 
            this.getSysInfBut.Location = new System.Drawing.Point(485, 114);
            this.getSysInfBut.Name = "getSysInfBut";
            this.getSysInfBut.Size = new System.Drawing.Size(89, 37);
            this.getSysInfBut.TabIndex = 16;
            this.getSysInfBut.Text = "инфор. о уд. системе";
            this.getSysInfBut.UseVisualStyleBackColor = true;
            this.getSysInfBut.Click += new System.EventHandler(this.getSysInfBut_Click);
            // 
            // Jokes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 324);
            this.Controls.Add(this.getSysInfBut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.unblockMachine);
            this.Controls.Add(this.blockMachine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enebleTaskMgr);
            this.Controls.Add(this.disebleTaskMgr);
            this.Controls.Add(this.shutdownMachine);
            this.Controls.Add(this.moveDirtyWindows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dirtyScreenValue);
            this.Controls.Add(this.dirtyScreen);
            this.Controls.Add(this.clearScreen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unLockMouse);
            this.Controls.Add(this.lockMouse);
            this.Name = "Jokes";
            this.Text = "Jokes";
            this.Load += new System.EventHandler(this.Jokes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dirtyScreenValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lockMouse;
        private System.Windows.Forms.Button unLockMouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearScreen;
        private System.Windows.Forms.Button dirtyScreen;
        private System.Windows.Forms.NumericUpDown dirtyScreenValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox moveDirtyWindows;
        private System.Windows.Forms.Button shutdownMachine;
        private System.Windows.Forms.Button disebleTaskMgr;
        private System.Windows.Forms.Button enebleTaskMgr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button blockMachine;
        private System.Windows.Forms.Button unblockMachine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button getSysInfBut;
    }
}