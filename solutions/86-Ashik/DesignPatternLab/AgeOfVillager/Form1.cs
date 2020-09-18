using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillager
{
    public partial class Form1 : Form
    {
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            string myNation = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            //tree
            if (radioButton1.Checked)
            {
                NationManager nm = new NationManager(myNation, g);
                nm.Draw(e);
            }
            //house
            else if (radioButton2.Checked)
            {
                //EgyptianKingsHouse eh = new EgyptianKingsHouse(g);
                //BDFarmersHouse bdh = new BDFarmersHouse(g);
                //bdh.draw(e);
                //ArabBedouinsHouse abh = new ArabBedouinsHouse(g);
                //abh.draw(e);
                InuitHuntersHouse ihh = new InuitHuntersHouse(g);
                ihh.draw(e);
            }
            //water source
            else if (radioButton3.Checked)
            {
                //EgyptianKingsWaterSource ews = new EgyptianKingsWaterSource(g);
                //ews.draw(e);
                BDFarmersWaterSource bdwh = new BDFarmersWaterSource(g);
                bdwh.draw(e);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
