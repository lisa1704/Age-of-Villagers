using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public partial class Village : Form
    {
        private int x;
        private int y;
        string s;
        string vName;

        List<Point> tree_point = new List<Point>();
        List<Point> house_point = new List<Point>();
        List<Point> watersource_point = new List<Point>();

        public Village()
        {
            InitializeComponent();
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = drawingPanel.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            foreach (Point point in house_point)
            {
                graphics.DrawLine(pen, point.X, point.Y, 100, 100);
            }
            foreach (Point point in watersource_point)
            {
                graphics.DrawLine(pen, point.X, point.Y, 100, 100);
            }

    }
}
