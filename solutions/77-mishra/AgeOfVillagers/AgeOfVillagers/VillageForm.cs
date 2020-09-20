using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class VillageForm : Form
    {
        private int x;
        private int y;

        public string nationtype;
        //Nations nations = new Nations(nationtype);
        private Point p;

        /*public INation arabBeduin = new ArabBeduin();
        public INation bdfarmer = new BdFarmer();
        public INation egKing = new EgyptianKing();*/


        public VillageForm()
        {
            InitializeComponent();
            
        }
        

        private void drawingBoard_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            x = p.X;
            y = p.Y;

            Nations nations = new Nations(nationtype);

            if(radioButton1.Checked == true)
            {
                nations.GetNation().DrawTree(p, drawingBoard);

                /*arabBeduin.DrawTree(p, drawingBoard);
                bdfarmer.DrawTree(p, drawingBoard);
                egKing.DrawTree(p, drawingBoard);*/
                
                
            }

            if(radioButton3.Checked == true)
            {

                nations.GetNation().DrawHouse(p, drawingBoard);
                /*arabBeduin.DrawHouse(p, drawingBoard);
                
                bdfarmer.DrawHouse(p, drawingBoard);
                egKing.DrawHouse(p, drawingBoard);*/

            }

            if(radioButton2.Checked == true)
            {
                nations.GetNation().DrawWaterSource(p, drawingBoard);
                //bdfarmer.DrawWaterSource(p, drawingBoard);
            }

          
            
        }
        private void drawingBoard_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = drawingBoard.CreateGraphics();
            Pen p = new Pen(Color.Black);
        }
        private void header_Click(object sender, EventArgs e)
        {

        }

        private void villageName_Click(object sender, EventArgs e)
        {

        }
        
        private void new_button_Click(object sender, EventArgs e)
        {
            drawingBoard.Invalidate();
        }
        private void save_Click(object sender, EventArgs e)
        {

        }

        private void open_button_Click(object sender, EventArgs e)
        {

        }
        private void tree_changed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void house_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void water_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Nation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nations nations = new Nations(nationtype);
            nationtype = Nation.Text;
            //drawingBoard.BackColor = nations.GetNation().PaintTerrain(p, drawingBoard);
            
        }
    }
}
