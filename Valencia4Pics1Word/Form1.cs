using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valencia4Pics1Word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void A_Click(object sender, EventArgs e)
        {
            if (Letter1.Text == "")
            {
                Letter1.Text = "A";
            }
        }
    }
}
