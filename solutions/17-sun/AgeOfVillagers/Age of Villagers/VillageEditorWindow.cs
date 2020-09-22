using Age_of_Villagers.Models.Manifests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public partial class VillageEditorWindow : Form
    {
        int xAxis;
        int yAxis;
        Point local;
        Boolean HouseSwitch;
        Boolean TreeSwitch;
        Boolean WaterSourceSwitch;

        public VillageEditorWindow()
        {
            InitializeComponent();
        }




        /// Demo
        //BangladeshiFarmers BanglaVillage = new BangladeshiFarmers();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



       
        private void VillageEditorPanel_Click(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            local = p;
            xAxis = p.X;
            yAxis = p.Y;
            VillageEditorPanel.Invalidate();
        }
        private void VillageEditorWindow_Load(object sender, EventArgs e)
        {

        }

        private void VillageEditorPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = VillageEditorPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);

            if (HouseSwitch)
            {

                House hut = new House(local);
                hut.Draw(gfx, p);
               

            }
            if (TreeSwitch)
            {
                
                gfx.DrawRectangle(p, xAxis, yAxis, 16, 24);
                

            }
            if (WaterSourceSwitch)
            {
                SolidBrush sb = new SolidBrush(Color.Blue);
                gfx.DrawEllipse(p, xAxis - 50, yAxis - 50, 100, 100);
                gfx.FillEllipse(sb, xAxis - 50, yAxis - 50, 100, 100);

            }
        }


        private void VillageTitle_Click(object sender, EventArgs e)
        {

        }

        private void NationTitle_Click(object sender, EventArgs e)
        {

        }

        private void WaterSourceButton_Click(object sender, EventArgs e)
        {
            TreeSwitch = false;
            WaterSourceSwitch = true;
            HouseSwitch = false;
        }


        private void TreeButton_Click(object sender, EventArgs e)
        {
            TreeSwitch = true;
            WaterSourceSwitch = false;
            HouseSwitch = false;
        }

        private void HouseButton_Click(object sender, EventArgs e)
        {
            TreeSwitch = false;
            WaterSourceSwitch = false;
            HouseSwitch = true;

        }

        private void NewVillageButton_Click(object sender, EventArgs e)
        {

        }

        private void OpenVillageButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveVillageButton_Click(object sender, EventArgs e)
        {

        }
    }
}
