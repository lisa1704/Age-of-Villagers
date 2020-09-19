using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class VillageWindow : Form
    {
        List<INation> nationlist = new List<INation>();
        INation nation = null;
        Village village = null;
        Graphics g;
        public Pen p; 
        string villageName = null;
        string selectedItem = null;

        public VillageWindow()
        {
            InitializeComponent();
        }

        private void VillageWindow_Load(object sender, EventArgs e)
        {
            nation = null;
            villageName = null;
            selectedItem = null;
            g = drawing_space.CreateGraphics();
            p = new Pen(Color.Black);

            nationlist.Add(new BangladeshiFarmers());
            nationlist.Add(new ArabBedouin());
            nationlist.Add(new EgyptianKings());    
            nationlist.Add(new InuitHunters());

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nationlist;
            NationlistBox.DataSource = nationlist;
            NationlistBox.DisplayMember = "nationName";
        }

        private void drawing_space_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void drawing_space_MouseClick(object sender, MouseEventArgs e)
        {
            if (village != null)
            {
                Point point = new Point(e.X, e.Y);
                if (tree_btn.Checked)
                {
                    village.DrawTree(g, p, point);
                }
                else if (House_btn.Checked)
                {
                    village.DrawHouse(g, p, point);
                }
                else if (water_btn.Checked)
                {
                    village.DrawWaterResource(g, p, point);
                }
            }
        }

        private void Village_name_textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            villageName = objTextBox.Text;
            if (villageName.Length == 0){
                villageName = null;
            }             
        }

        private void NationlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nation = (INation)NationlistBox.SelectedItem;
            if(village!= null)
            {
                village.changeVillageNation(nation);
                village.initiate(g, p);
            }
        }

        private void House_btn_CheckedChanged(object sender, EventArgs e)
        {
            selectedItem = House_btn.Text;     
        }

        private void tree_btn_CheckedChanged(object sender, EventArgs e)
        {
            selectedItem = tree_btn.Text;
        }

        private void water_btn_CheckedChanged(object sender, EventArgs e)
        {
            selectedItem = water_btn.Text;
        }

        private void new_village_btn_Click(object sender, EventArgs e)
        {
            if (villageName != null && nation != null)
            {
                village = new Village(villageName, nation);
                village.initiate(g, p);
            }
        }

        private void save_village_btn_Click(object sender, EventArgs e)
        {

        }

        private void open_village_btn_Click(object sender, EventArgs e)
        {

        }

    }
}
