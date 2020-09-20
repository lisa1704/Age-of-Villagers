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
        string selected_nation = "";
        string selected_component = "";
        NationFactory nf = new NationFactory();
        INations nation;

        public VillageWindow()
        {
            InitializeComponent();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = DrawingPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_aovtitle_Click(object sender, EventArgs e)
        {

        }

        private void Label_villName_Click(object sender, EventArgs e)
        {

        }

        private void btn_saveVillage_Click(object sender, EventArgs e)
        {
            SaveVillageForm svf = new SaveVillageForm();
            svf.Show();
        }

        private void btn_openVillage_Click(object sender, EventArgs e)
        {
            OpenVillageForm ovf = new OpenVillageForm();
            ovf.Show();
        }

        private void btn_newVillage_Click(object sender, EventArgs e)
        {
            DrawingPanel.Invalidate();
        }

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

        private void nation_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_nation = nation_selector.Items[nation_selector.SelectedIndex].ToString();
            if(selected_nation == "arab")
            {
                rbtn_waterSource.Visible = false;
            }
            if (selected_nation == "inuit")
            {
                rbtn_waterSource.Visible = false;
                rbtn_tree.Visible = false;
            }
        }

        private void DrawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point();
            p.X = e.X;
            p.Y = e.Y;
            //DrawingPanel.Invalidate();
            if(selected_nation=="" || selected_component == "")
            {
                MessageBox.Show("Select nation and component to draw");
            }
            else
            {
                g = DrawingPanel.CreateGraphics();

                nation = nf.GetNations(selected_nation);
                if (selected_component == "tree")
                {
                    nation.drawtree(p,g);
                }
                if (selected_component == "house")
                {
                    nation.drawhouse(p,g);
                }
                if (selected_component == "water_source")
                {
                    nation.drawwatersource(p,g);
                }
            }
        }
    }
}
