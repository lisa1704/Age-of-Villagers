using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawVillage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            Brush myBrush = new SolidBrush(Color.Blue);

            //g.DrawRectangle(myPen, 2, 2, 100, 200);
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            this.Width = 600;
            this.Width = 400;
        }
       
    }
}
