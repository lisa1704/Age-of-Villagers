using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class VillageEditorWindow : Form
    {
        public int x,y;
        public string vname,item,checked_nation;
        public Graphics gr;
        public INation _nation;
        public NationFactory nationfactory;

        public List<Point> PointsOfHouse { get; set; } = new List<Point>();
        public List<Point> PointsOfTree { get; set; } = new List<Point>();
        public List<Point> PointsOfWatersource { get; set; } = new List<Point>();

        public VillageEditorWindow()
        {
            InitializeComponent();
            gr = drawingpanel.CreateGraphics();
            
        }
        private void VillageWindow_Load(object sender, EventArgs e)
        {

        }

        public void drawingpanel_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.X;
            Point point = new Point(x, y);
            Pen pen = new Pen(Color.Blue);
            NationFactory NaFact = new NationFactory(nation.Text);

            if(item == "Tree")
            {
                NaFact.GetNation(checked_nation).DrawTree(point).DrawShapes(gr, pen);

            }
            else if (item == "House")
            {
                NaFact.GetNation(checked_nation).DrawHouse(point).DrawShapes(gr, pen);

            }
            else if (item == "Water Source")
            {
                NaFact.GetNation(checked_nation).DrawWaterSource(point).DrawShapes(gr, pen);

            }

        }

        public void TreeRadioMouseClicked(object sender, MouseEventArgs e)
        {
            item = "Tree";

        }

        public void HouseRadioMouseClicked(object sender, MouseEventArgs e)
        {
            item = "House";

        }

        public void WaterSourceRadioMouseClicked(object sender, MouseEventArgs e)
        {
            item = "River";

        }


        private void titlelabel_Click(object sender, EventArgs e)
        {

        }



        public void nation_SelectedIndexChanged(object sender, EventArgs e)
        {
            checked_nation = nation.Items[nation.SelectedIndex].ToString();
            _nation = nationfactory.GetNation(checked_nation);
            _nation.SetVillagename(villagename.Text);

        }
        private void villagename_TextChanged(object sender, EventArgs e)
        {
            _nation.SetVillagename(villagename.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void savevillage_Click(object sender, EventArgs e)
        {
           
        }

        public void newvillage_Click(object sender, EventArgs e)
        {
            //drawingpanel.Invalidate();

        }
        public void openvillage_Click(object sender, EventArgs e)
        {
            //drawingpanel.Invalidate();
        }


    }
}
