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
        //public static string setValueForText_House = "";
        //public static string setValueForText_Water = "";


        public VillageEditorWindow()
        {
            InitializeComponent();
        }

        
       


        private void label_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(radioButton_tree.Text,"MouseClick Event");
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
            graphics.DrawString(setValueForText_Tree, font, brush, new Point(x, y));
            //graphics.DrawString(setValueForText_House, font, brush, new Point(x, y));
            //graphics.DrawString(setValueForText_Water, font, brush, new Point(x, y));


            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "X", e.X);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Y", e.Y);
            messageBoxCS.AppendLine();
            messageBoxCS.AppendFormat("{0} = {1}", "Location", e.Location);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "MouseClick Event");

            

        }

        
        private void VillageEditorWindow_Load(object sender, EventArgs e)
        {
            label_village_name.Text = CreateNewVillageForm.SetValueForText1;
            label_nation_name.Text = CreateNewVillageForm.SetValueForText2;

        }

        private void radioButton_tree_Click(object sender, EventArgs e)
        {
            setValueForText_Tree = "Coconut Tree";
            
        }

        private void radioButton_house_Click(object sender, EventArgs e)
        {
            //setValueForText_House = "Duplex House";

        }

        private void radioButton_water_Click(object sender, EventArgs e)
        {
            //setValueForText_Water = "River Water";
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            CreateNewVillageForm new_villageform_object = new CreateNewVillageForm();
            new_villageform_object.Show();
        }
    }
}
