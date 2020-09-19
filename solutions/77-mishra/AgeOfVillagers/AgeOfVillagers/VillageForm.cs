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
    public partial class VillageForm : Form
    {
        private int x;
        private int y;

        //public IShape arabtree;

        //public IShape arabhouse;

        public INation arabBeduin;

        //public IShape arabhouse;
        public VillageForm()
        {
            InitializeComponent();
        }

        private void drawingBoard_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            x = p.X;
            y = p.Y;

            if(radioButton1.Checked == true)
            {
                //arabtree.draw(p, drawingBoard);
                arabBeduin.DrawTree(p, drawingBoard);
                
            }

            if(radioButton3.Checked == true)
            {
                //arabhouse.draw(p, drawingBoard);
                arabBeduin.DrawHouse(p, drawingBoard);
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

        }
    }
}
