﻿using Age_of_Villagers.House;
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

namespace Age_of_Villagers
{
    public partial class VillageEditorWindow : Form
    {


        int x, y;
        Graphics graphics;
        public static string setValueForText_Tree = "";
        public static string setValueForText_House = "";
        public static string setValueForText_Water = "";

        string nation_type = "";



        NationFactoryApplication nationFactory = new NationFactoryApplication();
        INation iNation;
        VillageState newVillage;
        VillageSave villageSave;
        


        //VillageEditorWindow villageWindow = new VillageEditorWindow();



        public VillageEditorWindow()
        {
            InitializeComponent();
            newVillage = new VillageState();
            villageSave = new VillageSave(newVillage);

        }

        
       


        private void label_Click(object sender, EventArgs e)
        {
            
        }

        

        private void drawing_space_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = drawing_space.CreateGraphics();
            Pen pen = new Pen(Color.Black);

            

        }

        

        private void drawing_space_MouseClick(object sender, MouseEventArgs e)
        {
             x = e.X;
             y = e.Y;


            graphics = drawing_space.CreateGraphics();
            Font font = new Font("Calibri", 10, FontStyle.Regular);
            Brush brush = new SolidBrush(System.Drawing.Color.Black);

            //nationFactory.GetNation(nation_type);

            AbstractNationCreator abstractNationCreator = nationFactory.GetNation(nation_type);

            iNation = abstractNationCreator.CreateNation();

            drawing_space.BackColor = iNation.getTerrainColor();

            checkRadioButton(font, brush, e);


            /*foreach (Point pt in HouseLists)
            {

                //iNation.GetHouse(graphics, pt);
                HouseLists.Add(pt);

            }
            foreach (Point pt in TreeLists)
            {
                //iNation.GetTree(graphics, pt);
                TreeLists.Add(pt);
            }

            foreach (Point pt in WaterLists)
            {
                //iNation.GetWaterResource(graphics, pt);
                WaterLists.Add(pt);
            }*/



            






            /* Set Radio Button and act accordingly


            BangladeshiFarmer bd = new BangladeshiFarmer("Bangladeshi Farmer");
            bd.GetHouse(graphics,e.Location);

            BangladeshiFarmer bd = new BangladeshiFarmer("Bangladeshi Farmer");
            bd.GetTree(graphics,e.Location);

            //BangladeshiFarmer bd = new BangladeshiFarmer("Bangladeshi Farmer");
            //bd.GetWaterResource(graphics,e.Location);



            //EgyptianKings eg = new EgyptianKings("Egyptian Kings");
            //eg.GetHouse(graphics, e.Location);

            //EgyptianKings eg = new EgyptianKings("Egyptian Kings");
            //eg.GetTree(graphics, e.Location);

            //EgyptianKings eg = new EgyptianKings("Egyptian Kings");
            //eg.GetWaterResource(graphics, e.Location);

            //ArabBedouin arab = new ArabBedouin("Arab Bedouin");
            //arab.GetHouse(graphics, e.Location);

            //ArabBedouin arab = new ArabBedouin("Arab Bedouin");
            //arab.GetTree(graphics, e.Location);

            //ArabBedouin arab = new ArabBedouin("Arab Bedouin");
            //arab.GetWaterResource(graphics, e.Location);

            //InuitHunter inuit = new InuitHunter("Inuit Hunter");
            //inuit.GetHouse(graphics, e.Location);





            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "X", e.X);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Y", e.Y);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Location", e.Location);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MouseClick Event");*/



        }

        private void checkRadioButton(Font font, Brush brush,MouseEventArgs e)
        {
            if (radioButton_tree.Checked)
            {
                iNation.GetTree(graphics, e.Location);
                newVillage.AddTree(graphics,e.Location,iNation);

            }
            else if (radioButton_house.Checked)
            { 
                iNation.GetHouse(graphics, e.Location);
                newVillage.AddHouse(graphics, e.Location, iNation);
            }
            else if (radioButton_water.Checked)
            {  
                iNation.GetWaterResource(graphics, e.Location);
                newVillage.AddWaterResource(graphics, e.Location, iNation);
            }
        }


        private void VillageEditorWindow_Load(object sender, EventArgs e)
        {
            label_village_name.Text = CreateNewVillageForm.SetValueForText1;   // Village Name passing from CreateNewVillageForm to VillageEditorWindow Form
             

        }

        private void radioButton_tree_Click(object sender, EventArgs e)
        {
            setValueForText_Tree = "Coconut Tree";
           
            
        }

        private void radioButton_house_Click(object sender, EventArgs e)
        {
            setValueForText_House = "Duplex House";

        }

        private void radioButton_water_Click(object sender, EventArgs e)
        {
            setValueForText_Water = "River Water";
        }

        private void nationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            nation_type = nationList.Text;
            //drawing_space.BackColor = iNation.getTerrainColor();
            //newVillage.repaint(graphics,iNation);

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            VillageState villageSave = new VillageState();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".aov|*.aov";
            sfd.Title = "Save AOV File";
            
            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //string path = sfd.FileName;
            //BinaryWriter bw = new BinaryWriter(File.Create(path));
            //bw.Dispose();

            //Serialize.
            XmlSerializer xml_serializer =
                new XmlSerializer(villageSave.GetType());
            using (StreamWriter stream_writer =
                new StreamWriter(sfd.FileName))
            {

                xml_serializer.Serialize(stream_writer, villageSave);
                //System.IO.File.WriteAllText(path, xml_serializer);
                stream_writer.Close();
            }


            //JsonSerializer.Serialize(villageSave);
            //string jsonString = JsonSerializer.Serialize(villageSave);
            //File.WriteAllText(path, jsonString);


            // }

            this.villageSave.saveState(newVillage);
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            /* OpenFileDialog ofd = new OpenFileDialog();
             ofd.Filter = ".aov|*.aov";
             ofd.Title = "Save AOV File";
             if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             {

                 try
                 {
                     XmlSerializer xml_serializer =
                         new XmlSerializer(villageSave.GetType());
                     using (FileStream file_stream =
                         new FileStream(ofd.FileName, FileMode.Open))
                     {
                         VillageSave new_villageSave =
                             (VillageSave)xml_serializer.Deserialize(file_stream);
                         villageSave = new_villageSave;
                        //villageWindow.Refresh();
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }


             

          */

        }

        private void button_new_Click(object sender, EventArgs e)  // Will Send to the Create New Village Form and act accordingly
        {
            CreateNewVillageForm new_villageform_object = new CreateNewVillageForm();  
            new_villageform_object.Show();
            drawing_space.Invalidate();  // Clearing the Drawing Space when a new village is created
    
        }
    }
}
