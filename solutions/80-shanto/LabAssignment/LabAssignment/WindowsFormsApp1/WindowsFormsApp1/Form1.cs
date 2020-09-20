﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Pen myPen = new Pen(Color.Green,2);

        public Form1()
        {
            InitializeComponent();
            //this.Width = 600;
            //this.Height = 400;
         
        }
        private void button10_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Save Village");

            /*SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Files(*.txt)|*.txt|All Files (*.*)|*.*";
            if (save.ShowDialog()==DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                write.Write(Text);
                write.Dispose();                
            }

            else
            {
                throw new Exception();
            }*/

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("New Village");
            Refresh();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Open Village");
            /*OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Files(*.txt)|*.txt| All Files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(open.FileName));
                Text = read.ReadToEnd();
                read.Dispose();
            }
            */
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            string nation = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

            var nationManager = new NationManager(nation, new NationFactory(g));

            if (nation == "Bangladeshi Farmers")
            {
                panel1.BackColor = Color.White;
                BackColor = Color.Green;
            }
            
            else if (nation == "Egypt Kings")
            {
                panel1.BackColor = Color.White;
                BackColor = Color.Yellow;
            }

            else if (nation == "Inuit Hunters")
            {
                BackColor = Color.White;
            }

            else if (nation == "Arab Bedouin")
            {
                panel1.BackColor = Color.White;
                BackColor = Color.YellowGreen;

            }

            if (radioButton1.Checked)
            {
                nationManager.DrawHouse(e);
            }
            if (radioButton2.Checked)
            {
                nationManager.DrawTree(e);
            }
            if (radioButton3.Checked)
            {
                nationManager.DrawWaterSource(e);
            }

        }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             //x = e.X;
             //y = e.Y;
        }
    }
}
