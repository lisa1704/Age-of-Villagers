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
        public static string VillageName;
        private HouseShape house;

        
        public DrawingWindow()
        {
            InitializeComponent();
            
        }
        private void DrawingWindow_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.VillageName;
            label3.Text = Form1.NationName;

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
            Graphics g = this.Drawingpanel.CreateGraphics();
            g.Clear(Color.White);

        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {

        }
        private void Drawingpanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point P = new Point(e.X, e.Y);
            HouseShape house = new HouseShape(Drawingpanel);
            TreeShape tree = new TreeShape(Drawingpanel);
            WaterSourceShape wsource = new WaterSourceShape(Drawingpanel);

            //Drawingpanel.Invalidate();

            if (radioButton2.Checked == true)
            {
                house.Draw(P, Drawingpanel);

            }
            if (radioButton1.Checked == true)
            {

                tree.Draw(P, Drawingpanel);
                
            }
            if (radioButton3.Checked == true)
            {

                wsource.Draw(P, Drawingpanel);
            }
        }

        
    }
}
