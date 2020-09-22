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
        int x;
        int y;

        public Form1()
        {
            InitializeComponent();
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            x = p.X;
            y = p.Y;
            canvas.Invalidate();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = canvas.CreateGraphics();
            BangladeshiFarmers v = new BangladeshiFarmers();
            canvas.BackColor = v.terrainColor();
            if (tree.Checked == true)
                v.DrawTree(g);
            else if (House.Checked == true)
                v.DrawHouse(g);
            else if (Water.Checked == true)
                v.drawWater(g);           

        }

    }
}
