using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    
    public partial class DrawingWindow : Form
    {
        private String item;
        public static string VillageName;
        private String Nation;
        int x;
        int y;

        public DrawingWindow()
        {
            InitializeComponent();
        }
        private void DrawingWindow_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.VillageName;
        }

        private void TreeButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HouseButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WaterButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SaveVillage_Click(object sender, EventArgs e)
        {

        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);

        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {

        }

 

        private void Drawingpanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point P = new Point(e.X, e.Y);
            x = P.X;
            y = P.Y;
            //Drawingpanel.Invalidate();
            Graphics g = Drawingpanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            if (radioButton1.Checked == true)
            {

                g.DrawLine(p, x - 10, y - 20, x - 100, y - 100);
            }
            if (radioButton2.Checked == true)
            {

                g.DrawRectangle(p, x - 50, y - 50, 100, 100);
            }
            if (radioButton3.Checked == true)
            {

                g.DrawEllipse(p, x - 50, y - 50, 100, 100);
            }
        }

      
    }
}
