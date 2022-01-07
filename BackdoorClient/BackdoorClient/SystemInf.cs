using System;
using System.Windows.Forms;
using System.Xml;

namespace BackdoorClient
{
    public partial class SystemInf : Form
    {
        public Form1 mainForm;

        public SystemInf(Form1 f)
        {
            mainForm = f;
            InitializeComponent();
        }

        private void SystemInf_Load(object sender, EventArgs e)
        {
            UpdateParameters();
        }

        private void updateBut_Click(object sender, EventArgs e)
        {
            UpdateParameters();
        }

        private void UpdateParameters()
        {
            var docContent = mainForm.SendCommandAndGetResponce("getsysInf $true");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(docContent);

            XmlNode root = doc.FirstChild;

            var textIP = "";
            var textTime = "";
            var textMname = "";
            var textUsName = "";
            var textBuildNum = "";
            var textSys = "";


            if (root.HasChildNodes)
            {
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    if (root.ChildNodes[i].Name == "ip")
                        textIP = root.ChildNodes[i].InnerText;
                    if (root.ChildNodes[i].Name == "time")
                        textTime = root.ChildNodes[i].InnerText;
                    if (root.ChildNodes[i].Name == "machineName")
                        textMname = root.ChildNodes[i].InnerText;
                    if (root.ChildNodes[i].Name == "usName")
                        textUsName = root.ChildNodes[i].InnerText;
                    if (root.ChildNodes[i].Name == "buildNum")
                        textBuildNum = root.ChildNodes[i].InnerText;
                    if (root.ChildNodes[i].Name == "sys")
                        textSys = root.ChildNodes[i].InnerText;
                }
            }
            ipAddrLabel.Text = "Ip аддрес: " + textIP;
            SystemTimeLabel.Text = "Системное время: " + textTime;
            SysNameLabel.Text = "";
            usNameLabel.Text = "Пользователь: " + textUsName;
            numBuildLabel.Text = "Номер билда: " + textBuildNum;
            SysNameLabel.Text = "Система: " + textSys;
        }
    }
}
