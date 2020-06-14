using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int change;
        string time;
        int time1;
        bool istimerrunning = false;
        bool porr = false;

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (istimerrunning == false)
            {
                timer1.Start();
                button1.Text = "Stop Timer";
                progressBar1.Maximum = time1;
                progressBar1.Minimum = 0;
                istimerrunning = true;

            }
            else
            {
                timer1.Stop();
                button1.Text = "Start Timer";
                progressBar1.Value = 0;
                progressBar1.Maximum = time1;
                progressBar1.Minimum = 0;
                change = 0;
                istimerrunning = false;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            change = change + 1;
            progressBar1.Value = change;
            label5.Text = "Time Remaining " + (time1 - change).ToString() + " seconds" + ".  The Percentage that is completed " + (change*100 / time1).ToString() + " %.";
            if (change == time1)
            {
                timer1.Stop();
                WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
                wplayer.URL = "sound.mp3";
                wplayer.controls.play();
                MessageBox.Show("The timer has finished");
                wplayer.controls.stop();
                istimerrunning = false;
                change = 0;
                button1.Text = "Start Timer";
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            time = textBox1.Text;
            time1 = int.Parse(time);
            time1 = time1 * 60;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (porr == false)
            {
                timer1.Stop();
                button2.Text = "Resume Timer";
                porr = true;

            }
            else
            {
                timer1.Start();
                button2.Text = "Pause Timer";
                porr = false;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            StreamReader FileReader = new StreamReader("colours.txt");
            string colour = FileReader.ReadLine();
            if (colour == "black")
            {
                BackColor = Color.DimGray;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
            }
            if (colour == "brown")
            {
                BackColor = Color.SaddleBrown;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
            }
            if(colour == "dgreen")
            {
                BackColor = Color.DarkGreen;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
            }
            if(colour == "lgreen")
            {
                BackColor = Color.Lime;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
            if(colour == "yellow")
            {
                BackColor = Color.Yellow;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
            if (colour == "peach")
            {
                BackColor = Color.PeachPuff;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }            
            if(colour == "orange")
            {
                BackColor = Color.Orange;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
            if(colour == "red")
            {
                BackColor = Color.Red;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
            if(colour == "pink")
            {
                BackColor = Color.LightPink;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
            if(colour == "purple")
            {
                BackColor = Color.Purple;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
            }
            if(colour == "lblue")
            {
                BackColor = Color.DeepSkyBlue;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
            if(colour == "dblue")
            {
                BackColor = Color.Blue;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
            }
            if (colour == "cyan")
            {
                BackColor = Color.Aqua;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
            if (colour == "gold")
            {
                BackColor = Color.Gold;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
            if (colour == "silver")
            {
                BackColor = Color.Silver;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
            if (colour == "default")
            {
                BackColor = Color.WhiteSmoke;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
            FileReader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("colours.txt"))
            {
                StreamReader FileReader = new StreamReader("colours.txt");
                string colour = FileReader.ReadLine();
                if (colour == "black")
                {
                    BackColor = Color.DimGray;
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                }
                if (colour == "brown")
                {
                    BackColor = Color.SaddleBrown;
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                }
                if (colour == "dgreen")
                {
                    BackColor = Color.DarkGreen;
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                }
                if (colour == "lgreen")
                {
                    BackColor = Color.Lime;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                }
                if (colour == "yellow")
                {
                    BackColor = Color.Yellow;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                }
                if (colour == "peach")
                {
                    BackColor = Color.PeachPuff;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                }
                if (colour == "orange")
                {
                    BackColor = Color.Orange;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                }
                if (colour == "red")
                {
                    BackColor = Color.Red;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                }
                if (colour == "pink")
                {
                    BackColor = Color.LightPink;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                }
                if (colour == "purple")
                {
                    BackColor = Color.Purple;
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                }
                if (colour == "lblue")
                {
                    BackColor = Color.DeepSkyBlue;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                }
                if (colour == "dblue")
                {
                    BackColor = Color.Blue;
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                }
                if (colour == "cyan")
                {
                    BackColor = Color.Aqua;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                }
                if (colour == "gold")
                {
                    BackColor = Color.Gold;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                }
                if (colour == "silver")
                {
                    BackColor = Color.Silver;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                }
                if (colour == "default")
                {
                    BackColor = Color.WhiteSmoke;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                }
                FileReader.Close();

            }

        }
           
    }
}
