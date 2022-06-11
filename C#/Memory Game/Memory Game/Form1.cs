using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class Form1 : Form
    {
        PictureBox firstBox;
        PictureBox secondBox;
        int firstIndex, secondIndex, count, found;

        Image[] images =
        {
            Properties.Resources._1,
            Properties.Resources._2,
            Properties.Resources._3,
            Properties.Resources._4,
            Properties.Resources._5,
            Properties.Resources._6,
            Properties.Resources._7,
            Properties.Resources._8,
        };

        int[] index = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 };
        private void RandomPicture()
        {
            Random rnd = new Random();
            for (int i = 0; i < 16; i++)
            {
                int num = rnd.Next(16);
                int temp = index[i];
                index[i] = index[num];
                index[num] = temp;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RandomPicture();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            int boxNum = int.Parse(box.Name.Substring(10));
            int indexNum = index[boxNum - 1];
            box.Image = images[indexNum];
            box.Refresh();

            if (firstBox == null)
            {
                firstBox = box;
                firstIndex = indexNum;
                count++;
            }
            else if(box!=firstBox)
            {
                secondBox = box;
                secondIndex = indexNum;
                box.Enabled = !Enabled;
                firstBox.Image = null;
                secondBox.Image = null;
                System.Threading.Thread.Sleep(500);
                if (firstIndex == secondIndex)
                {
                    found++;
                    firstBox.Visible = false;
                    secondBox.Visible = false;

                    if (found == 8)
                    {
                        MessageBox.Show("Поздравления! Брой опити: " + count);
                        Close();
                    }
                }
                firstBox = null;
                secondBox = null;
                box.Enabled = Enabled;
            }

        }
    }
}
