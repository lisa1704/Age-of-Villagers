using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ageofvillagers
{
    public partial class Ageofvillagers : Form
    {

        public Ageofvillagers()
        {

            InitializeComponent();

        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = panel2.CreateGraphics();
            Pen p = new Pen(Color.Black, 4);
            g.DrawLine(p,e.Location.X,e.Location.Y, e.Location.X+100, e.Location.Y);
            Console.WriteLine(e.Location.X);
            Console.WriteLine(e.Location.Y);
        }
    }
    
}
