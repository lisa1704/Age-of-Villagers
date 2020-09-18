using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving=false;
        Pen pen;
        private string _villagename, _nationame;
       private NationManager _nationmanager;
        public Form1()
        {
            InitializeComponent();

            g = DrawPanel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 2);

        }


        private void NewVillagebtn_Click(object sender, EventArgs e)
        {
            Form vlgname = new VillageNameInput(this,DrawPanel);
            DrawPanel.Invalidate();
            vlgname.Show();

        }


        private void SaveVillagebtn_Click(object sender, EventArgs e)
        {
            string village_name = VillageName.Text;
            MessageBox.Show(village_name);
           
        }

        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            Point _location = new Point(x, y);

            NationManager manager = new NationManager(NationName.Text);
             

            if (Houseradiobtn.Checked)
            {
                manager.getNation().GetHouse(_location).draw(g,pen);
                
            }
            else if (Treeradiobtn.Checked)
            {
                manager.getNation().GetTrees(_location).draw(g,pen);
            }
            else if (WaterRadiobtn.Checked)
            {
                manager.getNation().GetWaterSources(_location).draw(g, pen);
            } 

            else
            {
                MessageBox.Show("Please Select What You Want To Draw");
            }


        }

       

        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }
    }
}
