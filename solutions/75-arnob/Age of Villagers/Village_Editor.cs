using System;
using Age_of_Villagers.Nation;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Age_of_Villagers.Nation_Factory_Creator;

namespace Age_of_Villagers
{
    public partial class Village_Editor_Window : Form
    {
        string village_name;
        string nType;
        string item;
        Village savepoints;

        List<Point> house_point { get; set; } = new List<Point>();
        List<Point> tree_point { get; set; } = new List<Point>();
        List<Point> water_point { get; set; } = new List<Point>();

        public void getPoints()
        {
            this.savepoints = new Village(village_name, house_point, tree_point, water_point);
        }

        public void setPoints(Village saveVillage)
        {
            village_name = saveVillage.village;
            foreach (Point pt in saveVillage.house_point)
            {
                house_point.Add(pt);
            }
            foreach (Point pt in saveVillage.tree_point)
            {
                tree_point.Add(pt);
            }
            foreach (Point pt in saveVillage.water_point)
            {
                water_point.Add(pt);
            }

        }

        
        NationFactory n = new NationFactory();
        INation Nation;

        public Village_Editor_Window()
        {
            InitializeComponent();
        }

        private void _Click(object sender, EventArgs e)
        {
            Graphics g = Menu_bar.CreateGraphics();
            //Font font = new Font("Calibri", 10, FontStyle.Regular);
            //Brush brush = new SolidBrush(System.Drawing.Color.Black);
            AbstractNationFactoryCreator abstractNationCreator = n.GetNation(nType);
            Nation = abstractNationCreator.CreateNation();

            foreach (Point pt in house_point)
            {
                Nation.GetHouse(g, pt);
            }

            foreach (Point pt in tree_point)
            {
                Nation.GetTree(g, pt);
            }

            foreach (Point pt in water_point)
            {
                Nation.GetWaterSource(g, pt);
            }
        }

        private void drawing_click(object sender, MouseEventArgs e)
        {
            if (item == "house")
            {
                house_point.Add(e.Location);
            }
            else if (item == "tree")
            {
                tree_point.Add(e.Location);
            }
            else if (item == "water")
            {
                water_point.Add(e.Location);
            }
            Menu_bar.Invalidate();
        }

        private void Nation_Type(object sender, EventArgs e)
        {
            nType = comboBox_NationList.Text;
            Menu_bar.BackColor = Nation.getTerrainColour();
            Menu_bar.Refresh();
        }


        private void New_Village_Click(object sender, EventArgs e)
        {
            house_point.Clear();
            tree_point.Clear();
            water_point.Clear();
            Menu_bar.Refresh();

        }

        private void Save_Village_Click(object sender, EventArgs e)
        {
            getPoints();
            Save_Village save = new Save_Village(savepoints);
            save.action();
        }

        private void Open_Village_Click(object sender, EventArgs e)
        {
            if (comboBox_NationList.Text == "")
            {
                MessageBox.Show("Select nation.");
            }
            else
            {
                Open_Village open = new Open_Village();
                open.action();
                savepoints = open.openVillage();
                setPoints(savepoints);
                Menu_bar.Refresh();
            }
        }

        private void House_Click(object sender, EventArgs e)
        {
            item = "house";
        }

        private void Tree_Clicked(object sender, EventArgs e)
        {
            item = "tree";
        }

        private void WaterSource_Clicked(object sender, EventArgs e)
        {
            item = "Water_source";
        }


        private void Village_Name_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void AgeOfVillagers_Click(object sender, EventArgs e)
        {

        }


    }
}
