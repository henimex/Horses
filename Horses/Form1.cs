using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int h1lr, h2lr, h3lr, h4lr;
        //int r1, r2, r3, r4;

        private void timer2_Tick(object sender, EventArgs e)
        {
            //pictureBox5.Right = pictureBox5.Right + roadmove.Next(1, 2);
        }

        //int road = 9;

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int counter = Convert.ToInt32(label8.Text);
            counter++;
            label8.Text = counter.ToString();
            

            int h1wr = pictureBox1.Width;
            int h2wr = pictureBox2.Width;
            int h3wr = pictureBox3.Width;
            int h4wr = pictureBox4.Width;

            int fl = label5.Left;

            pictureBox1.Left = pictureBox1.Left + moverange.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + moverange.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + moverange.Next(5, 15);
            pictureBox4.Left = pictureBox4.Left + moverange.Next(5, 15);

            if (pictureBox1.Left > pictureBox2.Left+5 && pictureBox1.Left > pictureBox3.Left +5 && pictureBox1.Left > pictureBox4.Left +5)
            {
                label7.Text = "Brows Storm Striking from left wing, He is god damn' fast.";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5 && pictureBox2.Left > pictureBox4.Left + 5)
            {
                label7.Text = "Even sun is shining pink right now Little Pink doing bigger jobs than her name";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox4.Left + 5)
            {
                label7.Text = "Our farmer seems to get angry I can hear his gramble from here";
            }
            if (pictureBox4.Left > pictureBox1.Left + 5 && pictureBox4.Left > pictureBox2.Left + 5 && pictureBox4.Left > pictureBox3.Left + 5)
            {
                label7.Text = "Securiyt Security take care of this dog. Take it out fast.";
            }

            if (h1lr + pictureBox1.Left >= fl)
            {
                timer1.Enabled = false;
                label7.Text = "Horse 1 (Brown Storm)Has Won The Race";
            }
            if (h2lr+pictureBox2.Left >= fl)
            {
                timer1.Enabled = false;
                label7.Text = "Horse 2 (Little Pink)Has Won The Race";
            }
            if (h3lr + pictureBox3.Left >= fl)
            {
                timer1.Enabled = false;
                label7.Text = "Horse 3 (Angry Farmer)Has Won The Race";
            }
            if (h4lr + pictureBox4.Left >= fl)
            {
                timer1.Enabled = false;
                label7.Text = "Dog 1 (Mad Dog) Has Won The Race\nWhat!!!\nThere is a dog in the race area and that dog just won the race.\nIncradable";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            //timer2.Enabled = true;
        }

        Random moverange = new Random();
        Random roadmove = new Random();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            h1lr = pictureBox1.Left;
            h2lr = pictureBox2.Left;
            h3lr = pictureBox3.Left;
            h4lr = pictureBox4.Left;
            //r1 = pictureBox5.Right;
        }
    }
}
