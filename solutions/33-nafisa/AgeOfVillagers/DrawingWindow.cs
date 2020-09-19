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
        //Nations nation;
        
        public DrawingWindow()
        {
            InitializeComponent();
            
        }
        private void DrawingWindow_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.VillageName;
            label3.Text = Form1.NationName;
            Nations nation = new Nations(Form1.NationName, Drawingpanel);
            nation.getNation().PaintTerrain(Drawingpanel);
            
             if (Form1.NationName == "Arab Beduins")
            {
                
                radioButton3.Visible = false;
            }
            
            if (Form1.NationName == "Inuit Hunters")
            {
                radioButton3.Visible = false;
                radioButton1.Visible = false;
            }
            

        }

        private void SaveVillage_Click(object sender, EventArgs e)
        {
            
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            Refresh();

        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {

        }
        private void Drawingpanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point P = new Point(e.X, e.Y);
           
            Nations nation = new Nations(Form1.NationName, Drawingpanel);

            //Drawingpanel.Invalidate();

            if (radioButton2.Checked == true)
            {
                nation.getNation().DrawHouse(P, Drawingpanel);

            }
            if (radioButton1.Checked == true)
            {

                nation.getNation().DrawTree(P, Drawingpanel);
                
            }
            if (radioButton3.Checked == true)
            {

                nation.getNation().DrawWaterSource(P, Drawingpanel);
            }
        }

        
    }
}
