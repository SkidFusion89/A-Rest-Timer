using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamWriter ColourPicker = new StreamWriter("colours.txt");
            if (comboBox1.SelectedItem.ToString() == "Black")
            {
                ColourPicker.WriteLine("black");
                BackColor = Color.DimGray;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
            }
            else if (comboBox1.SelectedItem.ToString() == "Brown")
            {
                ColourPicker.WriteLine("brown");
                BackColor = Color.SaddleBrown;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
            }
            else if (comboBox1.SelectedItem.ToString() == "Dark Green")
            {
                ColourPicker.WriteLine("dgreen");
                BackColor = Color.DarkGreen;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
            }
            else if (comboBox1.SelectedItem.ToString() == "Light Green")
            {
                ColourPicker.WriteLine("lgreen");
                BackColor = Color.Lime;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
            else if (comboBox1.SelectedItem.ToString() == "Yellow")
            {
                ColourPicker.WriteLine("yellow");
                BackColor = Color.Yellow;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
            else if (comboBox1.SelectedItem.ToString() == "Peach")
            {
                ColourPicker.WriteLine("peach");
                BackColor = Color.PeachPuff;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;

            }
            else if (comboBox1.SelectedItem.ToString() == "Orange")
            {
                ColourPicker.WriteLine("orange");
                BackColor = Color.Orange;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
            else if (comboBox1.SelectedItem.ToString() == "Red")
            {
                ColourPicker.WriteLine("red");
                BackColor = Color.Red;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
            else if (comboBox1.SelectedItem.ToString() == "Pink")
            {
                ColourPicker.WriteLine("pink");
                BackColor = Color.LightPink;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
            else if (comboBox1.SelectedItem.ToString() == "Purple")
            {
                ColourPicker.WriteLine("purple");
                BackColor = Color.Purple;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
            }
            else if (comboBox1.SelectedItem.ToString() == "Light Blue")
            {
                ColourPicker.WriteLine("lblue");
                BackColor = Color.DeepSkyBlue;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
            else if (comboBox1.SelectedItem.ToString() == "Dark Blue")
            {
                ColourPicker.WriteLine("dblue");
                BackColor = Color.Blue;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
            }
            else if (comboBox1.SelectedItem.ToString() == "Cyan")
            {
                ColourPicker.WriteLine("cyan");
                BackColor = Color.Aqua;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
            else if (comboBox1.SelectedItem.ToString() == "Gold")
            {
                ColourPicker.WriteLine("gold");
                BackColor = Color.Gold;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
            else if (comboBox1.SelectedItem.ToString() == "Silver")
            {
                ColourPicker.WriteLine("silver");
                BackColor = Color.Silver;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
            else if (comboBox1.SelectedItem.ToString()=="Default Colour")
            {
                ColourPicker.WriteLine("default");
                BackColor = Color.WhiteSmoke;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
            ColourPicker.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (File.Exists("colours.txt"))
            {
                StreamReader FileReader = new StreamReader("colours.txt");
                string colour = FileReader.ReadLine();
                if (colour == "black")
                    if (colour == "black")
                    {
                        BackColor = Color.DimGray;
                        label1.ForeColor = Color.White;
                        label2.ForeColor = Color.White;
                    }
                if (colour == "brown")
                {
                    BackColor = Color.SaddleBrown;
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                }
                if (colour == "dgreen")
                {
                    BackColor = Color.DarkGreen;
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                }
                if (colour == "lgreen")
                {
                    BackColor = Color.Lime;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                }
                if (colour == "yellow")
                {
                    BackColor = Color.Yellow;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                }
                if (colour == "peach")
                {
                    BackColor = Color.PeachPuff;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                }
                if (colour == "orange")
                {
                    BackColor = Color.Orange;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                }
                if (colour == "red")
                {
                    BackColor = Color.Red;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                }
                if (colour == "pink")
                {
                    BackColor = Color.LightPink;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                }
                if (colour == "purple")
                {
                    BackColor = Color.Purple;
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                }
                if (colour == "lblue")
                {
                    BackColor = Color.DeepSkyBlue;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                }
                if (colour == "dblue")
                {
                    BackColor = Color.Blue;
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                }
                if (colour == "cyan")
                {
                    BackColor = Color.Aqua;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                }
                if (colour == "gold")
                {
                    BackColor = Color.Gold;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                }
                if (colour == "silver")
                {
                    BackColor = Color.Silver;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                }
                if (colour == "default")
                {
                    BackColor = Color.WhiteSmoke;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                }
                FileReader.Close();
            }
        }
    }
}
