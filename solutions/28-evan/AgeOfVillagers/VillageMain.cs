using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class VillageMain : Form
    {
        Color getColor;
        string nation;
        string nameOfVillage;

        ConcreteNation TypeOfNation = new ConcreteNation();

        public VillageMain()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nation = comboBox1.Text;
            getColor = TypeOfNation.checkNation(nation).DrawTerrain();
            panel1.BackColor = getColor;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}