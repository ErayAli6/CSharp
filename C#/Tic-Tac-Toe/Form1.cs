using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {

            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (count % 2 == 0)
            {
                b.Text = "X";

            }
            else
            {
                b.Text = "O";

            }
            count++;
            b.Enabled = false;
            Winner();
        }

        private void Winner()
        {
            bool win = false;
            //horizontal
            if (b1.Text == b2.Text && b2.Text == b3.Text && !b1.Enabled) win = true;
            if (b4.Text == b5.Text && b5.Text == b6.Text && !b4.Enabled) win = true;
            if (b7.Text == b8.Text && b8.Text == b9.Text && !b7.Enabled) win = true;

            //vertical
            if (b1.Text == b4.Text && b4.Text == b7.Text && !b1.Enabled) win = true;
            if (b2.Text == b5.Text && b5.Text == b8.Text && !b2.Enabled) win = true;
            if (b3.Text == b6.Text && b6.Text == b9.Text && !b3.Enabled) win = true;

            //diagonal
            if (b1.Text == b5.Text && b5.Text == b9.Text && !b1.Enabled) win = true;
            if (b3.Text == b5.Text && b5.Text == b7.Text && !b3.Enabled) win = true;

            if(win)
            {
                if((count-1) % 2 == 0)
                {
                    MessageBox.Show("X player has WON!!!");
                    Close();
                }
                else
                {
                    MessageBox.Show("O player has WON!!!");
                    Close();
                }
            }
            if(count == 9)
            {
                MessageBox.Show("DRAW!!!");
                Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
