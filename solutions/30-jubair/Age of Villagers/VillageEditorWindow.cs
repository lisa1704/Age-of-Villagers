using Age_of_Villagers.House;
using Age_of_Villagers.Nation;
using Age_of_Villagers.NationFactory;
using Age_of_Villagers.Village_Saving;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Age_of_Villagers
{
    public partial class VillageEditorWindow : Form
    {


        int x, y;
        Graphics graphics;
        string nation_type = "";

        NationFactoryApplication nationFactory = new NationFactoryApplication();
        INation iNation;
        VillageEdit newVillageEdit;
        VillageSave villageSave;
        VillageOpen villageOpen;
        
        public VillageEditorWindow()
        {
            InitializeComponent();
            newVillageEdit = new VillageEdit(CreateNewVillageForm.village_naaam);
            villageSave = new VillageSave(newVillageEdit);
            villageOpen = new VillageOpen(newVillageEdit);
        }

        private void VillageEditorWindow_Load(object sender, EventArgs e)
        {
            
            village_nameButton.Text = CreateNewVillageForm.village_naaam;
        }

        
        private void drawing_space_MouseClick(object sender, MouseEventArgs e)
        {
             x = e.X;
             y = e.Y;
            graphics = drawing_space.CreateGraphics();
            Font font = new Font("Calibri", 10, FontStyle.Regular);
            Brush brush = new SolidBrush(System.Drawing.Color.Black);
            AbstractNationCreator abstractNationCreator = nationFactory.GetNation(nation_type);
            iNation = abstractNationCreator.CreateNation();
            checkRadioButton(font, brush, e);

        }

        private void checkRadioButton(Font font, Brush brush,MouseEventArgs e)
        {
            if (radioButton_tree.Checked)
            {
                iNation.GetTree(graphics, e.Location);
                newVillageEdit.AddTree(graphics,e.Location,iNation);
            }
            else if (radioButton_house.Checked)
            { 
                iNation.GetHouse(graphics, e.Location);
                newVillageEdit.AddHouse(graphics, e.Location, iNation);
            }
            else if (radioButton_water.Checked)
            {  
                iNation.GetWaterResource(graphics, e.Location);
                newVillageEdit.AddWaterResource(graphics, e.Location, iNation);
            }
        }


        private void nationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            nation_type = nationList.Text;
            AbstractNationCreator abstractNationCreator = nationFactory.GetNation(nation_type);
            iNation = abstractNationCreator.CreateNation();
            drawing_space.BackColor = iNation.getTerrainColor(); 

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            
            this.villageSave.SaveVillage(newVillageEdit);
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select Nation First. If Nation is selected then Click on the drawing panel to Initialize Drawing", "Condition for Opening a saved AOV file");
            AbstractNationCreator abstractNationCreator = nationFactory.GetNation(nation_type);
            iNation = abstractNationCreator.CreateNation();
            newVillageEdit = villageOpen.ReformVillage();
            village_nameButton.Text = newVillageEdit.GetVillageName();
            Refresh();
            newVillageEdit.ReDrawVillage(graphics, iNation);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press 'New Village' Button to Enter Village Name ");
        }

        private void button_new_Click(object sender, EventArgs e)  // Will Send to the Create New Village Form and act accordingly
        {
            CreateNewVillageForm new_villageform_object = new CreateNewVillageForm();  
            new_villageform_object.Show();
            drawing_space.Invalidate(); 
            this.Hide();
        }
    }
}
