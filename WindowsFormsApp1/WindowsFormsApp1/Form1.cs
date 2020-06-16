using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int n = 0;
        int[] answer;

        public Form1()
        {
            InitializeComponent();
            answer = new int[12];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n++;
            if (n > 11) n = 11;
            show(n);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var bmp = new Bitmap(WindowsFormsApp1.Properties.Resources.c1);
            pictureBox2.BackgroundImage = bmp;
        }
        public void show(int n)
        {
            switch (answer[n])
            {
                case 0:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    break;
                case 1:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    break;

                case 2:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    break;
                case 3: 
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
            break;
                case 4:
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    break;
                case 5:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    break;
                case 6:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    break;
                case 7:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    break;
                case 8:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    break;
                case 9:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    break;
                case 10:
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = true;
                    break;
                case 11:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    break;
                case 12:
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    radioButton3.Checked = false;
                    break;
            }
            switch (n)
            {
                case 0:
                        pictureBox2.BackgroundImage = new Bitmap(WindowsFormsApp1.Properties.Resources.c1);
                    break;
                case 1:
                    pictureBox2.BackgroundImage = new Bitmap(WindowsFormsApp1.Properties.Resources.c2);
                    break;
                case 2:
                    pictureBox2.BackgroundImage = new Bitmap(WindowsFormsApp1.Properties.Resources.c3);
                    break;
                case 3:
                    pictureBox2.BackgroundImage = new Bitmap(WindowsFormsApp1.Properties.Resources.c4);
                    break;
                case 4:
                    pictureBox2.BackgroundImage = new Bitmap(WindowsFormsApp1.Properties.Resources.c5);
                    break;
                case 5:
                    pictureBox2.BackgroundImage = new Bitmap(WindowsFormsApp1.Properties.Resources.c6);
                    break;
                case 6:
                    pictureBox2.BackgroundImage = new Bitmap(WindowsFormsApp1.Properties.Resources.c7);
                    break;
                case 7:
                    pictureBox2.BackgroundImage = new Bitmap(WindowsFormsApp1.Properties.Resources.c8);
                    break;
                case 8:
                    pictureBox2.BackgroundImage = new Bitmap(WindowsFormsApp1.Properties.Resources.c9);
                    break;
                case 9:
                    pictureBox2.BackgroundImage = new Bitmap(WindowsFormsApp1.Properties.Resources.c_10);
                    break;
                case 10:
                    pictureBox2.BackgroundImage = new Bitmap(WindowsFormsApp1.Properties.Resources.c_11);
                    break;
                case 11:
                    pictureBox2.BackgroundImage = new Bitmap(WindowsFormsApp1.Properties.Resources.c_12);
                    break;
            }
            
        }
     private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            answer[n] = 3;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int correct = 0;
            if (answer[0] == 1)
                correct++;
            if (answer[1] == 1)
                correct++;
            if (answer[2] == 1)
                correct++;
            if (answer[3] == 1)
                correct++;
            if (answer[4] == 2)
                correct++;
            if (answer[5] == 3)
                correct++;
            if (answer[6] == 2)
                correct++;
            if (answer[7] == 3)
                correct++;
            if (answer[8] == 3)
                correct++;
            if (answer[9] == 3)
                correct++;
            if (answer[10] == 2)
                correct++;
            if (answer[11] == 2)
                correct++;
            String msg = "Вы не прошли тест";
            int prcnt = correct * 100 / 12;
            if (prcnt >= 50) msg = "Оценка 3";
            if (prcnt >= 75) msg = "Оценка 4";
            if (prcnt >= 90) msg = "Оценка 5";
            MessageBox.Show("Вы прошли тест на " + prcnt + " процентов. " + msg);
        }
    }
}
