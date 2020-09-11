using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AgeOfVillagers
{
    public partial class Villagewindow : Form
    {
        List<INationFactory> nationlist = new List<INationFactory>();
        public Village village = null;
        public Graphics g;
        public Pen p;

        public Villagewindow()
        {
            InitializeComponent();
            g = drawingpanel.CreateGraphics();
            p = new Pen(Color.Black);
        }

        private void Villagewindow_Load(object sender, EventArgs e)
        {
            nationlist.Add(new BangladeshiNationfactory());
            nationlist.Add(new Nationfactory1());
            nationlist.Add(new Nationfactory2());
            nationlist.Add(new Nationfactory3());
        }

        private void btnnewvillage_Click(object sender, EventArgs e)
        {
            var selector = new NewVillageSelectorwindow(nationlist, this);
            selector.Show();
        }

        private void btnopenvillage_Click(object sender, EventArgs e)
        {
            var openwindow = new OpenVillageWindow(nationlist, this);
            openwindow.Show();
        }

        private void btnsavevillage_Click(object sender, EventArgs e)
        {
            if (village != null)
            {
                var savewindow = new VillageSaveWindow(this);
                savewindow.Show();
            }
            
        }

        private void drawingpanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (village != null)
            {
                Point point = new Point(e.X,e.Y);
                if (rbtntree.Checked)
                {
                    village.DrawTree(g, p, point);
                    //g.DrawLine(p, point, new Point(e.X, e.Y-50));
                }
                else if (rbtnhouse.Checked)
                {
                    village.DrawHouse(g, p, point);
                    //g.DrawLine(p, point, new Point(e.X + 50, e.Y - 50));
                }
                else if(rbtnwatersource.Checked)
                {
                    village.DrawWaterResource(g, p, point);
                    //g.DrawLine(p, point, new Point(e.X + 50, e.Y));
                }
            }
            
        }
    }
    
}

