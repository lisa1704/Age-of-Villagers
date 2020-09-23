using Age_of_villagers.Components;
using Age_of_villagers.Nation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_villagers
{
    public partial class villagename_box : Form
    {
        int X, Y;
        string text = "";
        string name = "";
        public Graphics g;
        public Pen p;
        string ItemText = "";
        string NameofVillage = "";
        string typeofNation = "";
        public List<Point> HousePoints { get; set; } = new List<Point>();
        public List<Point> TreePoints { get; set; } = new List<Point>();
        public List<Point> WaterSourcePoints { get; set; } = new List<Point>();
        public object VillageName { get; private set; }
        public object VillageNametextBox { get; private set; }
        public object DrawPanel { get; private set; }
        public object NationList { get; private set; }

      

        VillageComponent VillageItem;
        public villagename_box()
        {
            InitializeComponent();
            g = Drawingpanel.CreateGraphics();
            p = new Pen(Color.Black);
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void Drawingpanel_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void Savevillage_Click(object sender, EventArgs e)
        {
            GetVillageSave();

            VillageSave vs = new VillageSave(VillageItem);
            vs.execute();
            MessageBox.Show(text + " Village Saved");
        }

        private void GetVillageSave()
        {
           
        }

        private void Newvillage_Click(object sender, EventArgs e)
        {
       
            HousePoints.Clear();
            TreePoints.Clear();
            WaterSourcePoints.Clear();
        

        }

        private void Openvillage_Click(object sender, EventArgs e)
        {

        }

        private void Drawinpanel_mouse(object sender, MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;
            if (Tree.Checked)
            {
                g.DrawLine(p, X, y, X + 25, y + 25);
            }
            else if (House.Checked)
            {
                drawHouse(x, y);
            }
            else if (Water_source.Checked)
            {
                g.DrawLine(p, X, y, X + 25, y + 25);
            }
        }

        private void Age_of_villagers_Click(object sender, EventArgs e)
        {

        }

        private void Village_Name_Click(object sender, EventArgs e)
        {

        }

        private void villagename_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nation_name_Click(object sender, EventArgs e)
        {

        }

        private void Nation_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tree_CheckedChanged(object sender, EventArgs e)
        {
            ItemText = "Tree";
        }

        private void House_CheckedChanged(object sender, EventArgs e)
        {
            ItemText = "House";
        }

        private void Water_source_CheckedChanged(object sender, EventArgs e)
        {
            ItemText = "Water Source";
        }
    }
}
