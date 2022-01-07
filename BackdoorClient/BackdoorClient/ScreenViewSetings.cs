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
    public partial class ScreenViewSetings : Form
    {
        Form1 mainForm;

        public ScreenViewSetings(Form1 f)
        {
            mainForm = f;
            InitializeComponent();
        }

        private void ScreenViewSetings_Load(object sender, EventArgs e)
        {
            if (!mainForm.TestConnect())
            {
              
                this.Close();
                return;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            ScreenViewStream screenViewStream = new ScreenViewStream(mainForm);
            screenViewStream.Show();
        }
    }
}
