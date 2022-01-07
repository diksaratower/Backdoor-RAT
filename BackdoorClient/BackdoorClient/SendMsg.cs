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
    public partial class SendMsg : Form
    {
        private Form1 mainForm;

        public SendMsg(Form1 form)
        {
            mainForm = form;
            InitializeComponent();
        }

        private void SendMsg_Load(object sender, EventArgs e)
        {
            if (!mainForm.TestConnect())
            {
               
                this.Close();
                return;
            }
            var a = choseButtons.Text;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if(!VerificationMatches(choseButtons) || !VerificationMatches(choseIcon))
            {
                MessageBox.Show("Выбирите из придложанных вариантов!", "Разработчик проги", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(Encoding.UTF8.GetBytes(mesageText.Text).Length >= 9000)
            {
                MessageBox.Show("Слишком дохера букав в сообщении", "Разработчик проги", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var msg = "msg $";//"msg $" + mesageText.Text + " &" + Subject.Text;
            if (Subject.Text == "" || mesageText.Text == "") return;
            msg += "<message>";
            msg += "<text>" + mesageText.Text + "</text>";
            msg += "<subject>" + Subject.Text + "</subject>";
            msg += "<but>" + GetNumberMatchInComboBox(choseButtons, choseButtons.Text) + "</but>";
            msg += "<ico>" + GetNumberMatchInComboBox(choseIcon, choseIcon.Text) + "</ico>";
            msg += "</message>";

            //var msg = "msg _msg" + mesageText.Text + " _sub" + Subject.Text + " _but" + choseButtons.Text + " _ico" + choseIcon.Text;
            mainForm.SendCommandAndGetResponce(msg);
        }

        private int GetNumberMatchInComboBox(ComboBox comboBox, string s)
        {
            if (!VerificationMatches(comboBox)) return 0;
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                if(s == comboBox.Items[i].ToString())
                {
                    return i;
                }
            }
            return 0;
        }

        private bool VerificationMatches(ComboBox comboBox)
        {
            int matches = 0;
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                if (comboBox.Text == comboBox.GetItemText(comboBox.Items[i]))
                {
                    matches++;
                }
            }
            if (matches <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
