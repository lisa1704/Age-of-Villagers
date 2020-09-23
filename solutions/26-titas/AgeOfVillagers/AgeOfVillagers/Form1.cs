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
    public partial class Form1 : Form
    {
        BdFarmers bdFarmers = new BdFarmers();
        ArabBedouin arabBedouin = new ArabBedouin();
        EgyptianKings egyptianKings = new EgyptianKings();
        InuitHunters inuitHunters = new InuitHunters();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void villageName_Click(object sender, EventArgs e)
        {

        }

        private void nation_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonTree_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonHouse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonWaterSource_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {

        }

        private void mouseClick_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            
            
            
        }

        private void mouse_click(object sender, MouseEventArgs e)
        {
            int x, y;
            //String nationName;
            x = e.X;
            y = e.Y;
            Graphics g = panel1.CreateGraphics();
            //nationName = comboBoxNationName.Text;
            Pen p = new Pen(new SolidBrush(Color.Black), 2);
            NationNameFactory nationName1 = new NationNameFactory(this);
            
            INation nation = nationName1.NationNameFactoryMethod();

            if (radioButtonHouse.Checked)
                {
                    nation.paint_house(e, g, p);
                }
                else if (radioButtonTree.Checked)
                {
                    nation.paint_tree(e, g, p);
                }
                else if (radioButtonWaterSource.Checked)
                {
                    nation.paint_waterSource(e, g, p);
                }
            
            /*else if (nationName == "Egyptian Kings")
            {
                if (radioButtonHouse.Checked)
                {
                    egyptianKings.paint_house(e, g, p);
                }
                else if (radioButtonTree.Checked)
                {
                    egyptianKings.paint_tree(e, g, p);
                }
                else if (radioButtonWaterSource.Checked)
                {
                    egyptianKings.paint_waterSource(e, g, p);
                }
            }
            else if (nationName == "Arab Bedouin")
            {
                
                if (radioButtonHouse.Checked)
                {
                    arabBedouin.paint_house(e, g, p);
                }
                else if (radioButtonTree.Checked)
                {
                    arabBedouin.paint_tree(e, g, p);
                }
                else if (radioButtonWaterSource.Checked)
                {
                    //arabBedouin.paint_waterSource(e, g, p);
                }
            }
            else if (nationName == "Inuit Hunters")
            {
                if (radioButtonHouse.Checked)
                {
                    inuitHunters.paint_house(e, g, p);
                }
                else if (radioButtonTree.Checked)
                {
                    //inuitHunters.paint_tree(e, g, p);
                }
                else if (radioButtonWaterSource.Checked)
                {
                    //inuitHunters.paint_waterSource(e, g, p);
                }
            }*/
        }

        private void comboBoxNationName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNationName.Text == "Bangladeshi Farmers")
                panel1.BackColor = Color.Green;
            else if (comboBoxNationName.Text == "Arab Bedouin")
                panel1.BackColor = Color.LightYellow;
            else if (comboBoxNationName.Text=="Egyptian Kings")
                panel1.BackColor = Color.Yellow;
            else if (comboBoxNationName.Text=="Inuit Hunters")
                panel1.BackColor = Color.White;

        }
    }
}
