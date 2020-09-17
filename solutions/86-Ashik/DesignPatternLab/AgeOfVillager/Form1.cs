using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillager
{
    public partial class Form1 : Form
    {
        int x, y,h,w;
        Pen myPen = new Pen(Color.Black);
        Brush myBrush = new SolidBrush(Color.Blue);
        //EgyptianKingsTree et = new EgyptianKingsTree();

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
            x = e.X;
            y = e.Y;
            h = 50;
            w = 75;
            Graphics g = this.CreateGraphics();
            Rectangle rect = new Rectangle(x, y, h, w);
            if (radioButton1.Checked)
            {
                EgyptianKingsTree et = new EgyptianKingsTree(g);
                et.draw(e);
            }
            else if (radioButton2.Checked)
            {
                EgyptianKingsHouse eh = new EgyptianKingsHouse(g);
                eh.draw(e);
            }
            else if (radioButton3.Checked)
            {
                EgyptianKingsWaterSource ews = new EgyptianKingsWaterSource(g);
                ews.draw(e);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
