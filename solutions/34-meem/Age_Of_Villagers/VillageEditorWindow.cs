using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Of_Villagers
{
    public partial class VillageEditorWindow : Form
    {
        string name;
        string nation;
        string rdButton;
        Village village;
        INation ination;
        







        public VillageEditorWindow()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void setVillageName(string Name)
        {
            villNameBox.Text = Name;
            string villageName = Name;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void setNation()
        {
            
            NationPropertyFactory nationProperty = new NationPropertyFactory();
            ination = nationProperty.getNation(nation);
            ination.setRadiobutton(this);
            ination.setTerrain(this);
        }







        public void radioButton_Click()
        {
            if (rdButtonHouse.Checked)
            {
                rdButton = rdButtonHouse.Text;
            }
            else if (rdButtonTree.Checked)
            {
                rdButton = rdButtonTree.Text;
            }
            else if (rdButtonWaterSrc.Checked)
            {
                rdButton = rdButtonWaterSrc.Text;
            }


        }




        private void saveVill_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics graphics = Panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            

            radioButton_Click();
            ItemFactory itemFactory = NationFactory.getNation(nation);
            IVillageItem item = itemFactory.getItem(rdButton);
            item.Draw(e.Location, graphics, pen);




        }

        

        private void newVill_Click(object sender, EventArgs e)
        {
            Panel1.Refresh();
        }
        
        private void rdButtonHouse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nationCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            nation = nationCombo.Text;
            setNation();


        }

        private void saveVill_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
