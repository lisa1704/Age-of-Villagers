using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class VillageForm : Form
    {
        
        public int x;
        public int y;
        Graphics graphics;
        Pen pen;
        private Nations nationsform;
        //private string villageName;
        
        public string nationtype;
        public VillageState villageState;

        private List<Point> HouseLoc { get; set; } = new List<Point>();
        private List<Point> TreeLoc { get; set; } = new List<Point>();
        private List<Point> WaterLoc { get; set; } = new List<Point>();

        public void getState()
        {
            this.villageState = new VillageState(Village.Text, HouseLoc, TreeLoc, WaterLoc);
        }

        public void setState(VillageState villageState)
        {
            foreach (Point point in villageState.houseLoc)
            {
                HouseLoc.Add(point);
            }
            foreach (Point point in villageState.treeLoc)
            {
                TreeLoc.Add(point);
            }
            foreach (Point point in villageState.waterLoc)
            {
                WaterLoc.Add(point);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            getState();
            SaveVillage saveVillage = new SaveVillage(villageState);
            saveVillage.execute();
        }


        public VillageForm()
        {
            InitializeComponent();
            graphics = drawingBoard.CreateGraphics();
            pen = new Pen(Color.Black);
            
        }
        

        private void drawingBoard_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            Point point = new Point(x, y);
            
            
            Nations nations = new Nations(Nation.Text);

            if(radioButton1.Checked == true)
            {
                
                nations.GetNation(point).DrawTree(point).draw(pen, graphics);
                
            }

            if(radioButton3.Checked == true)
            {

                nations.GetNation(point).DrawHouse(point).draw(pen, graphics);
                

            }

            if(radioButton2.Checked == true)
            {
                nations.GetNation(point).DrawWaterSource(point).draw(pen, graphics);
               
            }

          
            
        }
        private void drawingBoard_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = drawingBoard.CreateGraphics();
            Pen pen = new Pen(Color.Black);
        }
        private void header_Click(object sender, EventArgs e)
        {

        }

        private void villageName_Click(object sender, EventArgs e)
        {


        }
        
        private void new_button_Click(object sender, EventArgs e)
        {
            drawingBoard.Invalidate();
        }
        

        private void open_button_Click(object sender, EventArgs e)
        {
            OpenVillage openVillage = new OpenVillage();
            openVillage.execute();
        }
        private void tree_changed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void house_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void water_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Nation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Nations nations = new Nations(nationtype);
            nationtype = Nation.Text;
            if (nationtype == "Bangladeshi Farmers")
            {
                drawingBoard.BackColor = Color.Green;
            }
            else if (nationtype == "Arab Beduins")
            {
                drawingBoard.BackColor = Color.Transparent;
            }
            else if (nationtype == "Egyptian King")
            {
                drawingBoard.BackColor = Color.Yellow;
            }
            else if (nationtype == "Iniut Hunter")
            {
                drawingBoard.BackColor = Color.White;
            }

        }
    }
}
