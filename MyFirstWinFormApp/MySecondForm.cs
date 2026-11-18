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
    public partial class MySecondForm : Form
    {
        private bool flag = false;
        public MySecondForm()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                this.BackColor = Color.White;
                btnClickMe.BackColor = Color.Blue;
                flag = false;
            }
            else
            {
                this.BackColor = Color.Pink;
                btnClickMe.BackColor = Color.Purple;
                flag = true;
            }
        }
    }
}
