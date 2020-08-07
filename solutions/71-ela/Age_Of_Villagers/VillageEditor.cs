using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Of_Villagers
{
    public partial class AgeOfVillagers : Form
    {
        Graphics g;
        int x, y, h, w;
        IShapes r = new Rectangle();
     
        Pen p;
        public AgeOfVillagers()
        {
            InitializeComponent();
            g = drawingSpace.CreateGraphics();
            p = new Pen(Color.Black);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void selectNation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void treeButton_CheckedChanged(object sender, EventArgs e)
        {
            

            

        }

        private void drawingSpace_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

        }

        private void drawingSpace_MouseUp(object sender, MouseEventArgs e)
        {
            h = e.X - x;
            w = e.Y - y;
           
            
        }

        private void buttonNewVillage_Click(object sender, EventArgs e)
        {
           
            g.Clear(Color.White);
        }

        private void drawingSpace_Paint(object sender, PaintEventArgs e)
        {

        }

        private void drawHouse(int X,int Y)
        {
           
            g.DrawLine(p, X - 25, Y + 35, X + 25, Y - 25);
            g.DrawLine(p, X + 25, Y - 25, X + 50, Y + 50);
            g.DrawLine(p, X + 50, Y + 50, X - 25, Y + 35);
            g.DrawLine(p, X + 25, Y - 25, X + 75, Y + 25);
            g.DrawLine(p, X + 75, Y + 25, X + 50, Y + 50);
        }

        private void drawingSpace_Click(object sender, EventArgs e)
        {

        }

        private void drawingSpace_MouseClick(object sender, MouseEventArgs e)
        {

            int X = e.Location.X;
            int y = e.Location.Y;
            if(houseButton.Checked)
            {
                r.Draw(g, X, y, 16, 16);
            }
            else if (treeButton.Checked)
            {
                IShapes t = new Triangle();
                t.Draw(g, X, y, 16, 16);
            }
         

        }
    }
}
