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
        
        public int x;
        public int y;
        Graphics graphics;
        Pen pen;
        private Nations nationsform;

        public string nationtype;
        


        public VillageForm()
        {
            InitializeComponent();
            graphics = drawingBoard.CreateGraphics();
            pen = new Pen(Color.Black);
            
        }
        

        private void drawingBoard_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            Point point = new Point(x, y);
            
            
            Nations nations = new Nations(Nation.Text);

            if(radioButton1.Checked == true)
            {
                
                nations.GetNation(point).DrawTree(point).draw(pen, graphics);
                
            }

            if(radioButton3.Checked == true)
            {

                nations.GetNation(point).DrawHouse(point).draw(pen, graphics);
                /*arabBeduin.DrawHouse(p, drawingBoard);
                
                bdfarmer.DrawHouse(p, drawingBoard);
                egKing.DrawHouse(p, drawingBoard);*/

            }

            if(radioButton2.Checked == true)
            {
                nations.GetNation(point).DrawWaterSource(point).draw(pen, graphics);
                //bdfarmer.DrawWaterSource(p, drawingBoard);
            }

          
            
        }
        private void drawingBoard_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = drawingBoard.CreateGraphics();
            Pen pen = new Pen(Color.Black);
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
            if (nationtype == "Bangladeshi Farmers")
            {
                drawingBoard.BackColor = Color.Green;
            }
            else if (nationtype == "Arab Beduins")
            {
                drawingBoard.BackColor = Color.Transparent;
            }
            else if (nationtype == "Egyptian King")
            {
                drawingBoard.BackColor = Color.Yellow;
            }
            else if (nationtype == "Iniut Hunter")
            {
                drawingBoard.BackColor = Color.White;
            }

        }
    }
}
