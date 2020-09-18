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
            var nationManager = new NationManager(myNation, new NationFactory(g));

            //tree
            if (radioButton1.Checked)
            {
                nationManager.DrawTree(e);
            }
            //house
            else if (radioButton2.Checked)
            {
                nationManager.DrawHouse(e);
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
