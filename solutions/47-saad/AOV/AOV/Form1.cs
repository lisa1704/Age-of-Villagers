using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOV
{
    public partial class AgeOfVillagers : Form
    {
        NationFactory typeOfNation = new NationFactory();
        string selectedNation;
        string itemSelected;
        public AgeOfVillagers()
        {
            InitializeComponent();
        }

        private void Nation_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedNation = Nation.Text;
            Canvas.BackColor = typeOfNation.SelectNation(selectedNation).GetColor();
        }

        private void Tree_CheckedChanged(object sender, EventArgs e)
        {
                itemSelected = "tree";
                Console.WriteLine(itemSelected);
        }

        private void House_CheckedChanged(object sender, EventArgs e)
        {
                itemSelected = "house";
                Console.WriteLine(itemSelected);
        }

        private void WaterSource_CheckedChanged(object sender, EventArgs e)
        {
                itemSelected = "water source";
                Console.WriteLine(itemSelected);
        }
    }
}
