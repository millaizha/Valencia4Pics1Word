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
        
        public void LetterLabel(Label label, string letter, Button button)
        {
            label.Text = letter;
            ButtonChosen(button);
            label.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        public void LetterChoose(string letter, Button button)
        {
            if (Letter1.Text == "  ")
            {
                LetterLabel(Letter1, letter, button);
            }
            else if (Letter2.Text == "  ")
            {
                LetterLabel(Letter2, letter, button);
            }
            else if (Letter3.Text == "  ")
            {
                LetterLabel(Letter3, letter, button);
            }
            else if (Letter4.Text == "  ")
            {
                LetterLabel(Letter4, letter, button);
            }
            else if (Letter5.Text == "  ")
            {
                LetterLabel(Letter5, letter, button);
            }
            else if (Letter6.Text == "  ")
            {
                LetterLabel(Letter6, letter, button);
            }

        }

        public void DefaultLetter(Label label, Button button)
        {
           label.Text = "  ";
            button.Enabled = true;
            button.BackColor = Color.Gainsboro;
            label.Cursor = System.Windows.Forms.Cursors.Default;
        }

        public void LetterIdentify(Label label)
        {
            if (label.Text != "  ")
            {
                if (label.Text == "A")
                {
                    DefaultLetter(label, A);
                }
                else if (label.Text == " I")
                {
                    DefaultLetter(label, I);
                }
                else if (label.Text == "P")
                {
                    DefaultLetter(label, P);
                }
                else if (label.Text == "W")
                {
                    DefaultLetter(label, W);
                }
                else if (label.Text == "T")
                {
                    DefaultLetter(label, T);
                }
                else if (label.Text == "H")
                {
                    DefaultLetter(label, H);
                }
                else if (label.Text == "C")
                {
                    DefaultLetter(label, C);
                }
                else if (label.Text == "S")
                {
                    DefaultLetter(label, S);
                }
                else if (label.Text == "L")
                {
                    DefaultLetter(label, L);
                }
                else if (label.Text == "E")
                {
                    DefaultLetter(label, E);
                }
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
            LetterIdentify(Letter1);
        }

        private void Letter2_Click(object sender, EventArgs e)
        {
            LetterIdentify(Letter2);
        }

        private void Letter3_Click(object sender, EventArgs e)
        {
            LetterIdentify(Letter3);
        }

        private void Letter4_Click(object sender, EventArgs e)
        {
            LetterIdentify(Letter4);
        }

        private void Letter5_Click(object sender, EventArgs e)
        {
            LetterIdentify(Letter5);
        }

        private void Letter6_Click(object sender, EventArgs e)
        {
            LetterIdentify(Letter6);
        }
    }
}
