using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        Pen p;

        public Villagewindow()
        {
            InitializeComponent();
            g = drawingpanel.CreateGraphics();
            p = new Pen(Color.Black);
        }

        private void Villagewindow_Load(object sender, EventArgs e)
        {
            nationlist.Add(new Nationfactory1());
            nationlist.Add(new Nationfactory2());
            nationlist.Add(new Nationfactory3());
        }

        private void btnnewvillage_Click(object sender, EventArgs e)
        {
            var selector = new NewVillageSelectorwindow(nationlist, this);
            selector.Show();
        }


    }
    
}

