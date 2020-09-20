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
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.Black);
        //int x, y;
        Graphics g;
        //Brush brush = new SolidBrush(Color.Black);
        //string text = "";
        string chosen_nation = "";
        string chosen_component = "";
        NationFactory NF;
        INation nation;
        public Form1()
        {
            InitializeComponent();
            NF = new NationFactory(DrawingPanel);
        }

        private void DrawingPanel_Click(object sender, EventArgs e)
        {
            //ElementSelect();
        }

        private void VillageName_Click(object sender, EventArgs e)
        {
            if (VillageName.Text.Trim() != "" || VillageName.Text != null)

            {

                VillageName.Text = "";

            }
        }

        private void Nations_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void VillageName_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void DrawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            //x = e.X;
            //y = e.Y;
            Point p = new Point();
            p.X = e.X;
            p.Y = e.Y;

            //nation = NF.nationUpdate(Nations.SelectedIndex);
            g = DrawingPanel.CreateGraphics();
            //g.DrawString(text, Font, brush, new Point(x, y));
            if (chosen_component == "tree")
            {
                nation.drawtree(p);
            }
            if (chosen_component == "house")
            {
                nation.drawhouse(p);
            }
            if (chosen_component == "watersrc")
            {
                nation.drawwatersrc(p);
            }
        }

        private void SaveVillage_Click(object sender, EventArgs e)
        {
            if (VillageName.Text == "Enter Village Name" || VillageName.Text == "" || Nations.SelectedIndex == -1)
            {
                MessageBox.Show("Please Enter Village Name and Nation type!");
            }
            else
            {
                MessageBox.Show(VillageName.Text + " Saved!");
            }
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            formRefresh();
        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Village Opened!");
        }

        private void formRefresh()
        {
            VillageName.Text = "Enter Village Name";
            Nations.SelectedIndex = -1;
            House.Checked = false;
            Tree.Checked = false;
            WaterSource.Checked = false;
            DrawingPanel.Invalidate();
            DrawingPanel.BackColor = Color.Empty;
            //text = "";
        }

        private void Nations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Nations.SelectedIndex != -1)
            {
                chosen_nation = Nations.SelectedItem.ToString();
                BackColorSelect();
            }
            nation = NF.nationUpdate(Nations.SelectedIndex);

        }
        
        private void BackColorSelect()
        {
            if (chosen_nation == "Bangladeshi Farmers")
            {
                DrawingPanel.BackColor = Color.Green;
            }
            if (chosen_nation == "Arab Bedouins")
            {
                DrawingPanel.BackColor = Color.LightGoldenrodYellow;
            }
            if (chosen_nation == "Egyptian Kings")
            {
                DrawingPanel.BackColor = Color.LightYellow;
            }
            if (chosen_nation == "Inuit Hunters")
            {
                DrawingPanel.BackColor = Color.White;
            }
        }

        private void Tree_CheckedChanged(object sender, EventArgs e)
        {
            if (Tree.Checked == true)
            {
                chosen_component = "tree";
            }
        }

        private void House_CheckedChanged(object sender, EventArgs e)
        {
            if (House.Checked == true)
            {
                chosen_component = "house";
            }
        }

        private void WaterSource_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterSource.Checked == true)
            {
                chosen_component = "watersrc";
            }
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = DrawingPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);

        }
    }
}
