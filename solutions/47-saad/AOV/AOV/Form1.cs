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
        public AgeOfVillagers()
        {
            InitializeComponent();
        }

        private void Nation_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedNation = Nation.Text;
            Canvas.BackColor = typeOfNation.SelectNation(selectedNation).GetColor();
        }
    }
}
