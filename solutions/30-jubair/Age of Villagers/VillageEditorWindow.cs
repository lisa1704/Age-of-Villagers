using Age_of_Villagers.House;
using Age_of_Villagers.Nation;
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


        int x, y;
        Graphics graphics;
        public static string setValueForText_Tree = "";
        public static string setValueForText_House = "";
        public static string setValueForText_Water = "";


        public VillageEditorWindow()
        {
            InitializeComponent();
        }

        
       


        private void label_Click(object sender, EventArgs e)
        {
            
        }

        

        private void drawing_space_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void drawing_space_MouseClick(object sender, MouseEventArgs e)
        {
             x = e.X;
             y = e.Y;


            graphics = drawing_space.CreateGraphics();
            Font font = new Font("Calibri", 10, FontStyle.Regular);
            Brush brush = new SolidBrush(System.Drawing.Color.Black);


            checkRadioButton(font,brush); // Set Radio Button and act accordingly


            //BangladeshiFarmer bd = new BangladeshiFarmer("Bangladeshi Farmer");
            //bd.GetHouse(graphics,e.Location);


            //EgyptianKings eg = new EgyptianKings("Egyptian Kings");
            //eg.GetHouse(graphics, e.Location);

            //ArabBedouin arab = new ArabBedouin("Arab Bedouin");
            //arab.GetHouse(graphics, e.Location);

            ArabBedouin arab = new ArabBedouin("Arab Bedouin");
            arab.GetTree(graphics, e.Location);

            //BangladeshiFarmer bd = new BangladeshiFarmer("Bangladeshi Farmer");
            //bd.GetTree(graphics,e.Location);

            //BangladeshiFarmer bd = new BangladeshiFarmer("Bangladeshi Farmer");
            //bd.GetWaterResource(graphics,e.Location);





            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "X", e.X);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Y", e.Y);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Location", e.Location);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MouseClick Event");

            

        }

        private void checkRadioButton(Font font, Brush brush)
        {
            if (radioButton_tree.Checked)
            {
                graphics.DrawString(setValueForText_Tree, font, brush, new Point(x, y));  // Tree string drawn on drawing panel for setting tree button
            }
            else if (radioButton_house.Checked)
            {
                graphics.DrawString(setValueForText_House, font, brush, new Point(x, y));  // House string drawn on drawing panel for setting House button
            }
            else if (radioButton_water.Checked)
            {
                graphics.DrawString(setValueForText_Water, font, brush, new Point(x, y));  // Water Source string drawn on drawing panel for setting Water button
            }
        }


        private void VillageEditorWindow_Load(object sender, EventArgs e)
        {
            label_village_name.Text = CreateNewVillageForm.SetValueForText1;   // Village Name passing from CreateNewVillageForm to VillageEditorWindow Form
            label_nation_name.Text = CreateNewVillageForm.SetValueForText2;    // Nation Name passing from CreateNewVillageForm to VillageEditorWindow Form

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

        private void button_new_Click(object sender, EventArgs e)  // Will Send to the Create New Village Form and act accordingly
        {
            CreateNewVillageForm new_villageform_object = new CreateNewVillageForm();  
            new_villageform_object.Show();
            drawing_space.Invalidate();  // Clearing the Drawing Space when a new village is created
        }
    }
}
