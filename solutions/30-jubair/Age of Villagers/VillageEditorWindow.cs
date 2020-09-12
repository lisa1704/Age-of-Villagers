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
        
       

        public VillageEditorWindow()
        {
            InitializeComponent();
        }

        string component;
       


        private void label_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(radioButton_tree.Text,"MouseClick Event");
        }

        

        private void drawing_space_Paint(object sender, PaintEventArgs e)
        {

        }

        private void drawing_space_MouseClick(object sender, MouseEventArgs e)
        {
            //int x = e.X;
            //int y = e.Y;
            //MessageBox.Show(" X = " + x + "; Y = " + y);

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
            label_village_name.Text = NewVillageForm.SetValueForText1;
            label_nation_name.Text = NewVillageForm.SetValueForText2;

        }

        private void radioButton_tree_Click(object sender, EventArgs e)
        {
            component = "Coconut Tree";
            //MessageBox.Show(radioButton_tree.Text, "MouseClick Event");
        }

        private void radioButton_house_Click(object sender, EventArgs e)
        {
            component = "Duplex";
            //MessageBox.Show(radioButton_tree.Text, "MouseClick Event");

        }

        private void radioButton_water_Click(object sender, EventArgs e)
        {
            component = "Fountain";
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            NewVillageForm new_vill = new NewVillageForm();
            new_vill.Show();
        }
    }
}
