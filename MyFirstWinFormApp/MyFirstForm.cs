using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormApp
{
    public partial class MyFirstForm : Form
    {

        public MyFirstForm()
        {
            InitializeComponent();
        }




        private void BtnStop_Click(object sender, EventArgs e)
        {
            
            tmrMyTimer.Stop();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            tmrMyTimer.Interval = 1000;
            tmrMyTimer.Start();
        }

        private void tmrMyTimer_Tick(object sender, EventArgs e)
        {
            lblMyLabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }

    }
}
