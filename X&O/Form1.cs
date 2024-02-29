using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace X_O
{
    public partial class Form1 : Form
    {
        string XsauO = "X";
        bool isOver = false;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            Location = new Point(screen.Left + (screen.Width - w) / 2, screen.Top + (screen.Height - h) / 2);
            Size = new Size(w, h);
        }

        private void afisare_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Urmeaza jucatorul " + XsauO;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Urmeaza jucatorul " + XsauO;
        }

        private void swapTurn()
        {
            if (XsauO == "X")
                XsauO = "O";
            else if (XsauO == "O")
                XsauO = "X";
            else
                throw new Exception("De unde ai scos ma alta valoare?");
        }
        private void CheckWinCondition()
        {
            if(((button1.Text == button6.Text) && (button6.Text == button9.Text) && button1.Text != "") || // linia 1 
                ((button2.Text == button5.Text) && (button5.Text == button8.Text) && button2.Text!="") || // linia 2
                ((button3.Text == button4.Text) && (button4.Text == button7.Text) && button3.Text != "") || //linia 3
                ((button1.Text == button2.Text) && (button2.Text == button3.Text) && button2.Text != "") || // col 1
                ((button4.Text == button5.Text) && (button5.Text == button6.Text) && button4.Text != "") || // col 2
                ((button7.Text == button8.Text) && (button8.Text == button9.Text) && button9.Text != "") || // col 3
                ((button1.Text == button5.Text) && (button5.Text == button7.Text) && button1.Text != "") || // diag 1
                ((button3.Text == button5.Text) && (button5.Text == button9.Text) && button3.Text != "")) // diag 2
            {
                textBox1.Text = XsauO + " a castigat!";
                isOver = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "")
            {
                button1.Text = XsauO;
                CheckWinCondition();
                if (!isOver)
                {
                    swapTurn();
                    textBox1.Text = "Urmeaza: " + XsauO;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = XsauO;
                CheckWinCondition();
                if (!isOver)
                {
                    swapTurn();
                    textBox1.Text = "Urmeaza: " + XsauO;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = XsauO;
                CheckWinCondition();
                if (!isOver)
                {
                    swapTurn();
                    textBox1.Text = "Urmeaza: " + XsauO;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = XsauO;
                CheckWinCondition();
                if (!isOver)
                {
                    swapTurn();
                    textBox1.Text = "Urmeaza: " + XsauO;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = XsauO;
                CheckWinCondition();
                if (!isOver)
                {
                    swapTurn();
                    textBox1.Text = "Urmeaza: " + XsauO;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = XsauO;
                CheckWinCondition();
                if (!isOver)
                {
                    swapTurn();
                    textBox1.Text = "Urmeaza: " + XsauO;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = XsauO;
                CheckWinCondition();
                if (!isOver)
                {
                    swapTurn();
                    textBox1.Text = "Urmeaza: " + XsauO;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Text = XsauO;
                CheckWinCondition();
                if (!isOver)
                {
                    swapTurn();
                    textBox1.Text = "Urmeaza: " + XsauO;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                button9.Text = XsauO;
                CheckWinCondition();
                if (!isOver)
                {
                    swapTurn();
                    textBox1.Text = "Urmeaza: " + XsauO;
                }
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            XsauO = "X";
            textBox1.Text = "Ati resetat jocul. Urmeaza " + XsauO;
            isOver = false;
        }
    }
}
