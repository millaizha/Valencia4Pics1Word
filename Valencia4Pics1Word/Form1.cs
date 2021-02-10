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

        public void ButtonChosen(Button button)
        {
            button.Enabled = false;
            button.BackColor = Color.FromArgb(26, 30, 42);
        }

        public void LetterChoose(string letter, Button button)
        {
            if (Letter1.Text == "  ")
            {
                Letter1.Text = letter;
                ButtonChosen(button);
                Letter1.Cursor = System.Windows.Forms.Cursors.Hand;
            }
            else if (Letter2.Text == "  ")
            {
                Letter2.Text = letter;
                ButtonChosen(button);
            }
            else if (Letter3.Text == "  ")
            {
                Letter3.Text = letter;
                ButtonChosen(button);
            }
            else if (Letter4.Text == "  ")
            {
                Letter4.Text = letter;
                ButtonChosen(button);
            }
            else if (Letter5.Text == "  ")
            {
                Letter5.Text = letter;
                ButtonChosen(button);
            }
            else if (Letter6.Text == "  ")
            {
                Letter6.Text = letter;
                ButtonChosen(button);
            }

        }

        private void A_Click(object sender, EventArgs e)
        {
            LetterChoose("A", A);
        }

        private void I_Click(object sender, EventArgs e)
        {
            LetterChoose(" I", I);
        }

        private void P_Click(object sender, EventArgs e)
        {
            LetterChoose("P", P);
        }

        private void W_Click(object sender, EventArgs e)
        {
            LetterChoose("W", W);
        }

        private void T_Click(object sender, EventArgs e)
        {
            LetterChoose("T", T);
        }

        private void H_Click(object sender, EventArgs e)
        {
            LetterChoose("H", H);
        }

        private void C_Click(object sender, EventArgs e)
        {
            LetterChoose("C", C);
        }

        private void S_Click(object sender, EventArgs e)
        {
            LetterChoose("S", S);
        }

        private void L_Click(object sender, EventArgs e)
        {
            LetterChoose("L", L);
        }

        private void E_Click(object sender, EventArgs e)
        {
            LetterChoose("E", E);
        }

        private void Letter1_Click(object sender, EventArgs e)
        {
            if (Letter1.Text != "  ")
            {
                if (Letter1.Text == "A")
                {
                    Letter1.Text = "  ";
                    A.Enabled = true;
                    A.BackColor = Color.Gainsboro;
                    Letter1.Cursor = System.Windows.Forms.Cursors.Default;
                }
            }
        }
    }
}
