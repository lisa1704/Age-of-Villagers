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
        public Graphics g;
        public Pen pen = new Pen(Color.Black);
        public string selected_nation = "";
        public string selected_component = "";
        NationFactory nf = new NationFactory();
        //INations nation;
        //abstract factory implement
        AbstractComponentFactory nation;


        public VillageWindow()
        {
            InitializeComponent();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
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
            selected_nation = nation_selector.Text;
            nation = ComponentFactoryProducer.getComponentFactory(selected_nation);

            if (selected_nation == "Arab Bedouins")
            {
                DrawingPanel.BackColor = Color.GreenYellow;
                rbtn_waterSource.Visible = false;
                rbtn_tree.Visible = true;
            }
            if (selected_nation == "Inuit Hunters")
            {
                DrawingPanel.BackColor = Color.White;
                rbtn_waterSource.Visible = false;
                rbtn_tree.Visible = false;
            }
            if (selected_nation == "Bangladeshi Farmers")
            {
                DrawingPanel.BackColor = Color.Green;
                rbtn_waterSource.Visible = true;
                rbtn_tree.Visible = true;
            }
            if (selected_nation == "Egyptian Kings")
            {
                DrawingPanel.BackColor = Color.Yellow;
                rbtn_waterSource.Visible = true;
                rbtn_tree.Visible = true;
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
                IComponent component = nation.getComponent(selected_component);
                component.draw();
                //nation = nf.GetNation(selected_nation);
                
            }
        }
    }
}
