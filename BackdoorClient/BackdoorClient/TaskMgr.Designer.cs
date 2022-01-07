namespace BackdoorClient
{
    partial class TaskMgr
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
            this.taskill = new System.Windows.Forms.Button();
            this.RefreshTasks = new System.Windows.Forms.Button();
            this.tasksView = new System.Windows.Forms.TreeView();
            this.processValue = new System.Windows.Forms.Label();
            this.findTaskTextBox = new System.Windows.Forms.TextBox();
            this.findTaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskill
            // 
            this.taskill.Location = new System.Drawing.Point(368, 281);
            this.taskill.Name = "taskill";
            this.taskill.Size = new System.Drawing.Size(119, 27);
            this.taskill.TabIndex = 2;
            this.taskill.Text = "Убить задачу";
            this.taskill.UseVisualStyleBackColor = true;
            this.taskill.Click += new System.EventHandler(this.taskill_Click);
            // 
            // RefreshTasks
            // 
            this.RefreshTasks.Location = new System.Drawing.Point(368, 238);
            this.RefreshTasks.Name = "RefreshTasks";
            this.RefreshTasks.Size = new System.Drawing.Size(119, 26);
            this.RefreshTasks.TabIndex = 3;
            this.RefreshTasks.Text = "Обновить список";
            this.RefreshTasks.UseVisualStyleBackColor = true;
            this.RefreshTasks.Click += new System.EventHandler(this.RefreshTasks_Click);
            // 
            // tasksView
            // 
            this.tasksView.Location = new System.Drawing.Point(36, 42);
            this.tasksView.Name = "tasksView";
            this.tasksView.Size = new System.Drawing.Size(286, 266);
            this.tasksView.TabIndex = 1;
            this.tasksView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tasksView_AfterSelect);
            // 
            // processValue
            // 
            this.processValue.AutoSize = true;
            this.processValue.Location = new System.Drawing.Point(365, 21);
            this.processValue.Name = "processValue";
            this.processValue.Size = new System.Drawing.Size(98, 13);
            this.processValue.TabIndex = 4;
            this.processValue.Text = " К-лво процессов:";
            // 
            // findTaskTextBox
            // 
            this.findTaskTextBox.Location = new System.Drawing.Point(36, 13);
            this.findTaskTextBox.Name = "findTaskTextBox";
            this.findTaskTextBox.Size = new System.Drawing.Size(213, 20);
            this.findTaskTextBox.TabIndex = 5;
            this.findTaskTextBox.TextChanged += new System.EventHandler(this.findTaskTextBox_TextChanged);
            // 
            // findTaskButton
            // 
            this.findTaskButton.Location = new System.Drawing.Point(255, 12);
            this.findTaskButton.Name = "findTaskButton";
            this.findTaskButton.Size = new System.Drawing.Size(67, 22);
            this.findTaskButton.TabIndex = 6;
            this.findTaskButton.Text = "искать";
            this.findTaskButton.UseVisualStyleBackColor = true;
            this.findTaskButton.Click += new System.EventHandler(this.findTaskButton_Click);
            // 
            // TaskMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 325);
            this.Controls.Add(this.findTaskButton);
            this.Controls.Add(this.findTaskTextBox);
            this.Controls.Add(this.processValue);
            this.Controls.Add(this.RefreshTasks);
            this.Controls.Add(this.taskill);
            this.Controls.Add(this.tasksView);
            this.Name = "TaskMgr";
            this.Text = "TaskMgr";
            this.Load += new System.EventHandler(this.TaskMgr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button taskill;
        private System.Windows.Forms.Button RefreshTasks;
        private System.Windows.Forms.TreeView tasksView;
        private System.Windows.Forms.Label processValue;
        private System.Windows.Forms.TextBox findTaskTextBox;
        private System.Windows.Forms.Button findTaskButton;
    }
}