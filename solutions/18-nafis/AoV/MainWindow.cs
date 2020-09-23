using AoV.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AoV
{
    public partial class MainWindow : Form
    {
        Graphics g;
        IShape myShape;
        public MainWindow()
        {
            InitializeComponent();
            g = DrawingPanel.CreateGraphics();
        }

        bool canPaint = false;
        int? pointX = null;
        int? pointY = null;

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            canPaint = true;

        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            canPaint = false;
            pointX = null;
            pointY = null;
        }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(canPaint)
            {

                myShape = new Line(new Point(pointX ?? e.X, pointY ?? e.Y), new Point(e.X, e.Y));
                myShape.Draw(g);
                pointX = e.X;
                pointY = e.Y;

            }

        }
    }
}
