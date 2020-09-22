using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    
    public partial class DrawingWindow : Form
    {
        public static string VillageName;
       
        private VillageState village;
        private List<Point> house_locations { get; set; } = new List<Point>();
        private List<Point> tree_locations { get; set; } = new List<Point>();
        private List<Point> watersource_locations { get; set; } = new List<Point>();
        public DrawingWindow()
        {
            InitializeComponent();
            village = new VillageState();

        }
        private void DrawingWindow_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.VillageName;
            label3.Text = Form1.NationName;
            Nations nation = new Nations(Form1.NationName, Drawingpanel);
            nation.getNation().PaintTerrain(Drawingpanel);
            
             if (Form1.NationName == "Arab Beduins")
            {
                
                radioButton3.Visible = false;
            }
            
            if (Form1.NationName == "Inuit Hunters")
            {
                radioButton3.Visible = false;
                radioButton1.Visible = false;
            }
            

        }
        public void GetVillageState()
        {   

            village.villagename = label2.Text;
            village.nationname = Form1.NationName;
            village.terraincolor = Drawingpanel.BackColor;
            village.Houses = house_locations;
            village.Trees =  tree_locations;
            village.Watersources = watersource_locations;
        }
        public void SetVillageState(VillageState village)
        {
            Drawingpanel.BackColor = village.terraincolor;

            foreach (Point point in village.Houses)
            {
                house_locations.Add(point);
            }
            foreach (Point point in village.Trees)
            {
                house_locations.Add(point);
            }
            foreach (Point point in village.Watersources)
            {
                watersource_locations.Add(point);
            }
        }


        private void SaveVillage_Click(object sender, EventArgs e)
        {

            GetVillageState();
            VillageStateSaver savevillage = new VillageStateSaver(village);
            savevillage.execute();


        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            Refresh();

        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {

            
        }
        private void Drawingpanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point P = new Point(e.X, e.Y);
            Nations nation = new Nations(Form1.NationName, Drawingpanel);
            

            //Drawingpanel.Invalidate();

            if (radioButton2.Checked == true)
            {
                nation.getNation().DrawHouse(P, Drawingpanel);
                //state.setHouseState(P);
                house_locations.Add(P);

            }
            if (radioButton1.Checked == true)
            {

                nation.getNation().DrawTree(P, Drawingpanel);
                //state.setTreeState(P);
                tree_locations.Add(P);

            }
            if (radioButton3.Checked == true)
            {

                nation.getNation().DrawWaterSource(P, Drawingpanel);
                //state.setWsourceState(P);
                watersource_locations.Add(P);
            }
        }

        
    }
}
