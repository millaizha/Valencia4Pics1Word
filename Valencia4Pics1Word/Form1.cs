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

        public void LetterChoose(string letter)
        {
            if (Letter1.Text == "  ")
            {
                Letter1.Text = letter;
            }
            else if (Letter2.Text == "  ")
            {
                Letter2.Text = letter;
            }
            else if (Letter3.Text == "  ")
            {
                Letter3.Text = letter;
            }
            else if (Letter4.Text == "  ")
            {
                Letter4.Text = letter;
            }
            else if (Letter5.Text == "  ")
            {
                Letter5.Text = letter;
            }
            else if (Letter6.Text == "  ")
            {
                Letter6.Text = letter;
            }

        }

        private void A_Click(object sender, EventArgs e)
        {
            LetterChoose("A");
        }

        private void I_Click(object sender, EventArgs e)
        {
            LetterChoose(" I");
        }

        private void P_Click(object sender, EventArgs e)
        {
            LetterChoose("P");
        }

        private void W_Click(object sender, EventArgs e)
        {
            LetterChoose("W");
        }

        private void T_Click(object sender, EventArgs e)
        {
            LetterChoose("T");
        }

        private void H_Click(object sender, EventArgs e)
        {
            LetterChoose("H");
        }

        private void C_Click(object sender, EventArgs e)
        {
            LetterChoose("C");
        }

        private void S_Click(object sender, EventArgs e)
        {
            LetterChoose("S");
        }

        private void L_Click(object sender, EventArgs e)
        {
            LetterChoose("L");
        }

        private void E_Click(object sender, EventArgs e)
        {
            LetterChoose("E");
        }
    }
}
