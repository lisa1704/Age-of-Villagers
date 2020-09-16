using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisioForge.Shared.MediaFoundation.OPM;

namespace AgeOfVillagers
{   
    public partial class CreateVillageWindow : Form
    {
        protected NationAbstract nation;
        Graphics newg ;
        Village myvillage = new Village();
        SaveVillage myvillageSaver;
        public CreateVillageWindow()
        {
            InitializeComponent();
            newg = drawing_panel.CreateGraphics();
            myvillageSaver = new SaveVillage(myvillage);
        }

        private void save_village_Click(object sender, EventArgs e)
        {
            myvillageSaver.saveState(myvillage);

        }

        private void new_village_Click(object sender, EventArgs e)
        {
            drawing_panel.Refresh();
        }

        private void open_village_Click(object sender, EventArgs e)
        {
            myvillage =  myvillageSaver.OpenState();
            myvillage.paintAgain(nation);
        }

        private void village_name_TextChanged(object sender, EventArgs e)
        {
            
            myvillage.Name = village_name.Text;
        }

        private void CreateVillageWindow_Load(object sender, EventArgs e)
        {

        }
        private void tree_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void house_checkedchanged(object sender, EventArgs e)
        {
           
        }

        private void water_resource_checkedchanged(object sender, EventArgs e)
        {
            
        }

        private void select_nation_selectedindexchanged(object sender, EventArgs e)
        {

        }


        private void drawing_panel_MouseClick(object sender, MouseEventArgs e)
        {
            if(tree.Checked == true)
            {
                nation.drawTree(e.X, e.Y);
                myvillage.addTree(e.X,e.Y);
            }
            else if(house.Checked == true)
            {
                nation.drawHouse(e.X, e.Y);
                myvillage.addHouse(e.X, e.Y);
            }
            else if(water_resource.Checked == true)
            {
                nation.drawWaterSource(e.X, e.Y);
                myvillage.addWater_Resource(e.X, e.Y);
            }

        }

        private void selectNation_TextChanged(object sender, EventArgs e)
        {
            if( select_nation.Text == "Egyptian Kings")
            {
                nation = new EgyptianKings(newg, drawing_panel);   
            }
            else if(select_nation.Text == "Bangladeshi Farmers")
            {
                nation = new BangladeshiFarmers(newg, drawing_panel);
            }
            else if(select_nation.Text == "Arab Bedouin")
            {
                nation = new ArabBedouin(newg, drawing_panel);    
            }
            else if(select_nation.Text == "Inuit Hunters")
            {
                nation = new InuitHunters(newg, drawing_panel);  
            }
        }
    }
}
