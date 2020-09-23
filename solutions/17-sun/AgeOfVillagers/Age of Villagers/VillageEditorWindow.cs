using Age_of_Villagers.Models;
using Age_of_Villagers.Models.Manifests;
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
    public partial class VillageEditorWindow : Form
    {
       
        Point local;
        Graphics gfx;
        Boolean HouseSwitch;
        Boolean TreeSwitch;
        Boolean WaterSourceSwitch;

        INation Nation;
        Village EditorVillage;


        //
         
        
        //

        public VillageEditorWindow()
        {
            InitializeComponent();
            
        }




        /// Demo
        //BangladeshiFarmers BanglaVillage = new BangladeshiFarmers();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



       
  
        private void VillageEditorWindow_Load(object sender, EventArgs e)
        {

        }

        private void VillageNameBox_Text(object sender, EventArgs e)
        {
            EditorVillage = new Village(VillageNameBox.Text);
        }

        private void VillageEditorPanel_Click(object sender, MouseEventArgs e)
        {
            gfx = VillageEditorPanel.CreateGraphics();
            local.X = e.X;
            local.Y = e.Y;

            Pen p = new Pen(Color.Black);

            if (HouseSwitch)
            {
                
                Nation.Draw_House(local, gfx, p);




            }
            if (TreeSwitch)
            {

                Nation.Draw_Tree(local, gfx, p);
                

            }
            if (WaterSourceSwitch)
            {
                Nation.Draw_WaterSource(local, gfx, p);

            }
        }


        

        private void WaterSourceButton_Click(object sender, EventArgs e)
        {
            TreeSwitch = false;
            WaterSourceSwitch = true;
            HouseSwitch = false;
        }


        private void TreeButton_Click(object sender, EventArgs e)
        {
            TreeSwitch = true;
            WaterSourceSwitch = false;
            HouseSwitch = false;
        }

        private void HouseButton_Click(object sender, EventArgs e)
        {
            TreeSwitch = false;
            WaterSourceSwitch = false;
            HouseSwitch = true;

        }

        private void NewVillageButton_Click(object sender, EventArgs e)
        {
            
            VillageEditorPanel.Invalidate();
            

        }

        private void OpenVillageButton_Click(object sender, EventArgs e)
        {

        }


        private void SaveVillageButton_Click(object sender, EventArgs e)
        {

        }

        private void NationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)NationListBox.SelectedItem == "Bangladeshi Farmers")
            {
                Nation = new BangladeshiFarmers();
                VillageEditorPanel.BackColor = Color.Green; //BD

            }
            else if((string)NationListBox.SelectedItem == "Arab Bedouins")
            {
               Nation = new ArabBedouins();
                VillageEditorPanel.BackColor = Color.LightGoldenrodYellow; //Arabia
            }
            else if ((string)NationListBox.SelectedItem == "Egyptian Kings")
            {
                Nation = new EgyptianKings();
                VillageEditorPanel.BackColor = Color.Yellow; //Egypt
            }
            else if((string)NationListBox.SelectedItem == "Inuit Hunters")
            {
                Nation = new InuitHunters();
                VillageEditorPanel.BackColor = Color.White; //Iceland
            }
        }
    }
}
