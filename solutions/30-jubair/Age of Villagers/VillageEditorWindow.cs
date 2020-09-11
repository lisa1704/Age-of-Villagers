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

 
        private void label_Click(object sender, EventArgs e)
        {
            
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

        
    }
}
