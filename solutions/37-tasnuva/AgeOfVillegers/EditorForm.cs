using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace AgeOfVillegers
{
    
    public partial class EditorForm : Form
    {
        string type ;
        string rdbutton ;
        string VillageName;
        string name;
        string nation;
        string text;
        private string name;
        INation ination ;
        village village ;
        Factory_Nation factory_nation  = new Factory_Nation();
        
        public void get_state()
        {
           this.village = new village(villagename.Text, H_points, T_points, W_points);
        }
        public EditorForm()
        {
            InitializeComponent();
        }
        private List<Point> W_points { get; set; } = new List<Point>();
        private List<Point> T_points { get; set; } = new List<Point>();
        private List<Point> H_points { get; set; } = new List<Point>();
        public void set_state(village village)
        {
            villagename.Text = village.name;
            foreach(Point pt in village.house_point)
            {
                H_points.Add(pt);
            }
            foreach(Point pt in village.tree_point)
            {
                T_points.Add(pt);
            }
            foreach(Point pt in village.waterresource_point)
            {
                W_points.Add(pt);
            }
        }

        
        

       

        private void save_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VillageNameBox.Text + " Village saved");
        }

        

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nation = comboBox1.Text;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }



        private void EditorForm_Load(object sender, EventArgs e)
        {

        }

        private void VillageNameBox_TextChanged(object sender, EventArgs e)
        {
            name = VillageNameBox.Text;
        }
        public void setVillageName(string name)
        {
            VillageNameBox.Text = name;
            string VillageName = name;
        }
        public void radioButton_Click()
        {
            if (House_btn.Checked)
            {
                rdButton = House_btn.Text;
            }
            else if (Tree_btn.Checked)
            {
                rdButton = Tree_btn.Text;
            }
            else if (Water_btn.Checked)
            {
                rdButton = Water_btn.Text;
            }
            else{
                rdButton = "";
            }


        }

        private void Tree_btn_CheckedChanged(object sender, EventArgs e)
        {
            text = "Tree";
        }

        private void House_btn_CheckedChanged(object sender, EventArgs e)
        {
            text = "House";
            
        }

        private void Water_btn_CheckedChanged_1(object sender, EventArgs e)
        {
            text = "Water Source";
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            VillageNameBox.Clear();
            H_points.Clear();
            T_points.Clear();
            W_points.Clear();
            drawpanel.Refresh();
            
        }

        private void Open_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
