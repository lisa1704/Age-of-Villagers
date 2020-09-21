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
        Graphics g;
        Pen pen = new Pen(Color.Black);
        public string selected_nation = "";
        public string selected_component = "";
        Village vill = new Village();
        
        //abstract factory implement
        AbstractNation nation;
        NationFactory nf;


        public VillageWindow()
        {
            InitializeComponent();
            g = DrawingPanel.CreateGraphics();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e) { }
        private void SidePanel_Paint(object sender, PaintEventArgs e) { }

        private void rbtn_house_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_house.Checked == true)
            {
                selected_component = "house";
            }
        }

        private void rbtn_tree_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_tree.Checked == true)
            {
                selected_component = "tree";
            }
        }

        private void rbtn_waterSource_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_waterSource.Checked == true)
            {
                selected_component = "water_source";
            }
        }
        private void btn_saveVillage_Click(object sender, EventArgs e)
        {
            SaveVillageForm svf = new SaveVillageForm();
            svf.Show();
        }

        public void SaveState(string selected_nation, string selected_component, Point p)
        {
            vill.nation = selected_nation;
            if (selected_component== "tree")
            {
                vill.trees_drawn.Add(p);
            }
            if (selected_component == "house")
            {
                vill.houses_drawn.Add(p);
            }
            if (selected_component == "water_source")
            {
                vill.rivers_drawn.Add(p);
            }
        }

        private void btn_openVillage_Click(object sender, EventArgs e)
        {
            //OpenVillageForm ovf = new OpenVillageForm();
            //ovf.Show();
        }

        private void btn_newVillage_Click(object sender, EventArgs e)
        {
            DrawingPanel.Invalidate();
            g.Clear(DrawingPanel.BackColor);
            vill = new Village();
        }

        private void nation_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_nation = nation_selector.Text;
            nf = new NationFactory();
            nation = nf.getNation(selected_nation); 
            nation.setBgColor(g);
            vill = new Village();

            if (selected_nation == "Arab Bedouins")
            {
                rbtn_waterSource.Visible = false;
                rbtn_tree.Visible = true;
            }
            if (selected_nation == "Inuit Hunters")
            {
                rbtn_waterSource.Visible = false;
                rbtn_tree.Visible = false;
            }
            if (selected_nation == "Bangladeshi Farmers")
            {
                rbtn_waterSource.Visible = true;
                rbtn_tree.Visible = true;
            }
            if (selected_nation == "Egyptian Kings")
            {
                rbtn_waterSource.Visible = true;
                rbtn_tree.Visible = true;
            }
        }
        private void DrawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point();
            p.X = e.X;
            p.Y = e.Y;
            

            if (selected_nation=="" || selected_component == "")
            {
                MessageBox.Show("Select nation and component to draw");
            }
            else
            {
                IComponent component;
                component = nation.getComponent(selected_component);
                component.draw(p, g, pen);
                this.SaveState(selected_component, selected_nation, p);               
            }
        }
    }
}
