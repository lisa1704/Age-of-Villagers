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
        public List<Point> HousePoints { get; set; } = new List<Point>();
        public List<Point> TreePoints { get; set; } = new List<Point>();
        public List<Point> WatersrcPoints { get; set; } = new List<Point>();


        VillageState villageState;

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

        }

        private void VillageName_Click(object sender, EventArgs e)
        {
            if (VillageName.Text.Trim() != "" || VillageName.Text != null)

            {

                VillageName.Text = "";

            }
        }

        private void DrawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (nation == null)
            {
                //do nothing
            }
            else
            {

                Point p = new Point();
                p.X = e.X;
                p.Y = e.Y;

                if (chosen_component == "tree")
                {
                    nation.drawtree(p);
                    TreePoints.Add(p);
                }
                if (chosen_component == "house")
                {
                    nation.drawhouse(p);
                    HousePoints.Add(p);
                }
                if (chosen_component == "watersrc")
                {
                    nation.drawwatersrc(p);
                    WatersrcPoints.Add(p);
                }
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
                villageState.Vname = VillageName.Text;
                villageState.HPoint = HousePoints;
                villageState.TPoint = TreePoints;
                villageState.WPoint = WatersrcPoints;
                SaveVillage saveVillage = new SaveVillage(villageState);
                saveVillage.execute();
                MessageBox.Show(VillageName.Text + " Saved!");
            }

        }


        private void NewVillage_Click(object sender, EventArgs e)
        {
            formRefresh();
        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
            OpenVillage openVillage = new OpenVillage();
            openVillage.execute();
            villageState = openVillage.getsavedvillage();
            repaint(villageState);
        }

        public void repaint(VillageState villageState)
        {
            if (Nations.SelectedIndex < 0)
            {
                MessageBox.Show("Select Nation Type");
            }
            if (Nations.SelectedIndex > -1)
            {
                nation = NF.nationUpdate(Nations.SelectedIndex);
                VillageName.Text = villageState.Vname;
                foreach (Point point in villageState.HPoint)
                {
                    HousePoints.Add(point);
                    nation.drawhouse(point);
                }

                foreach (Point point in villageState.TPoint)
                {
                    TreePoints.Add(point);
                    nation.drawtree(point);
                }

                foreach (Point point in villageState.WPoint)
                {
                    WatersrcPoints.Add(point);
                    nation.drawwatersrc(point);
                }
                MessageBox.Show("Village Opened!");
            }
        }

        private void formRefresh()
        {
            VillageName.Text = "Enter Village Name";
            Nations.SelectedIndex = -1;
            House.Checked = false;
            Tree.Checked = false;
            WaterSource.Checked = false;
            HousePoints.Clear();
            TreePoints.Clear();
            WatersrcPoints.Clear();
            DrawingPanel.Invalidate();
            DrawingPanel.BackColor = Color.Empty;
            chosen_component = null;
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
