using Age_of_Villagers.House;
using Age_of_Villagers.Nation;
using Age_of_Villagers.NationFactory;
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

        string nation_type = "";

        List<Point> HouseLists = new List<Point>();
        List<Point> TreeLists = new List<Point>();
        List<Point> WaterLists = new List<Point>();


        NationFactoryApplication nationFactory = new NationFactoryApplication();

        INation iNation;



        public VillageEditorWindow()
        {
            InitializeComponent();
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


            checkRadioButton(font, brush, e);

            foreach (Point pt in HouseLists)
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
            }


            
            
            
            
            
            
            
            // Set Radio Button and act accordingly


            //BangladeshiFarmer bd = new BangladeshiFarmer("Bangladeshi Farmer");
            //bd.GetHouse(graphics,e.Location);

            //BangladeshiFarmer bd = new BangladeshiFarmer("Bangladeshi Farmer");
            //bd.GetTree(graphics,e.Location);

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





            /*System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
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
            }
            else if (radioButton_house.Checked)
            { 
                iNation.GetHouse(graphics, e.Location);
            }
            else if (radioButton_water.Checked)
            {  
                iNation.GetWaterResource(graphics, e.Location);
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

        private void nationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            nation_type = nationList.Text;
            //drawing_space.BackColor = nationFactory.GetNation(nation_type).BackGroundColor();
        }

        private void button_new_Click(object sender, EventArgs e)  // Will Send to the Create New Village Form and act accordingly
        {
            CreateNewVillageForm new_villageform_object = new CreateNewVillageForm();  
            new_villageform_object.Show();
            drawing_space.Invalidate();  // Clearing the Drawing Space when a new village is created
    
        }
    }
}
