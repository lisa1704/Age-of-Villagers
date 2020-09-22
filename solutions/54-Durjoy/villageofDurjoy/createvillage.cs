using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace villageofDurjoy
{
    public partial class createvillage : Form
    {
        int X, Y;
        string text = "";
        string name = "";
        public Graphics g;
        public Pen p;
        public createvillage()
        {
            InitializeComponent();
            g = flowLayoutPanel1.CreateGraphics();
            p = new Pen(Color.Black);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Housebutton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void treeButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Watersourcebutton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Newbutton_Click(object sender, EventArgs e)
        {

        }

        private void openbutton_Click(object sender, EventArgs e)
        {

        }
        private void savebutton_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void drawHouse(int X, int Y)
        {

            g.DrawLine(p, X - 25, Y + 35, X + 25, Y - 25);
            g.DrawLine(p, X + 25, Y - 25, X + 50, Y + 50);
            g.DrawLine(p, X + 50, Y + 50, X - 25, Y + 35);
            g.DrawLine(p, X + 25, Y - 25, X + 75, Y + 25);
            g.DrawLine(p, X + 75, Y + 25, X + 50, Y + 50);
        }
       
        private void flowLayoutPanel1MouseClick(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            Graphics g = flowLayoutPanel1.CreateGraphics();
            g.DrawString(text, new Font("Arial", 12), new SolidBrush(ForeColor), e.X, e.Y);
            if (treeButton.Checked)
            {

            }
            else if (Housebutton.Checked)
            {

            }
            else if (Watersourcebutton.Checked)
            {

            }

        }





    }
}

