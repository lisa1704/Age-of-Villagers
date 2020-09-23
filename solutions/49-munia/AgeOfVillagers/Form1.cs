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
      //  int x;
      //  int y;
        Point point;
        public Form1()
        {
            InitializeComponent();
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
          //  x = p.X;
          // y = p.Y;
            canvas.Invalidate();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = canvas.CreateGraphics();
            BangladeshiFarmers v = new BangladeshiFarmers();
            canvas.BackColor = v.terrainColor();
            if (tree.Checked == true)
                v.DrawTree(g,point);
            else if (House.Checked == true)
                v.DrawHouse(g);
            else if (Water.Checked == true)
                v.drawWater(g);           

        }

        private void newVillage_MouseClick(object sender, MouseEventArgs e)
        {
            canvas.Invalidate();
        }

    }
}
