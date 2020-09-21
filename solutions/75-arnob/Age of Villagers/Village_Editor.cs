using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public partial class Village_Editor_Window : Form
    {
        string village_name;
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
        public Village_Editor_Window()
        {
            InitializeComponent();
        }

        private void Menu_Bar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void drawing_space_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nation_Type(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));
                write.Write(Village.Text);
                write.Dispose();
            }
        }

        private void Open_Village_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(open.FileName));

                Village.Text = read.ReadToEnd();
                read.Dispose();


            }
        }

        private void House_Click(object sender, EventArgs e)
        {

        }

        private void Tree_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void WaterSource_Clicked(object sender, EventArgs e)
        {

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
