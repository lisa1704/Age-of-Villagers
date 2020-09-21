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
    public partial class Village_Editor_Window : Form
    {

        Village savepoints;

        List<Point> house_point { get; set; } = new List<Point>();
        List<Point> tree_point { get; set; } = new List<Point>();
        List<Point> water_point { get; set; } = new List<Point>();
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

        }

        private void Save_Village_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Open_Village_Click(object sender, EventArgs e)
        {

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
