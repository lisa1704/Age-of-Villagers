using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AgeOfVillagers
{
    public partial class MainWindow : Form
    {

        int x;
        int y;
        string text;
        string nation;
        Color background;
        VillageState village = new VillageState();
        NationBuilder builder = new NationBuilder();

        List<Point> houseLocations = new List<Point>();
        List<Point> treeLocations = new List<Point>();
        List<Point> waterLocation = new List<Point>();

        INations currentNation = new NoNation();
        Graphics g;

        public MainWindow()
        {

            InitializeComponent();
        }

        private void drawingAreaPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            x = e.X;
            y = e.Y;

            g = drawingAreaPanel.CreateGraphics();

            if(text == "TREE")
            {
                treeLocations.Add(e.Location);
                currentNation.DrawTree(e.X, e.Y, g);
            }
            else if(text == "HOUSE")
            {
                houseLocations.Add(e.Location);
                currentNation.DrawHouse(e.X, e.Y, g);
                
            }
            else
            {
                waterLocation.Add(e.Location);
                currentNation.DrawWater(e.X, e.Y, g);
            }

           
        }

        private void TreeButton_MouseClick(object sender, MouseEventArgs e)
        {
            text = "TREE";
        }

        private void houseButton_MouseClick(object sender, MouseEventArgs e)
        {
            text = "HOUSE";
        }

        private void waterButton_MouseClick(object sender, MouseEventArgs e)
        {
            text = "WATER";
        }

        private void nationTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            nation = nationTypeCombo.Text;
            currentNation = builder.BuildNations(nation);
            background = currentNation.SetColor();
            drawingAreaPanel.BackColor = background;

            /*if(nation == "Bangladeshi Farmers")
            {
                drawingAreaPanel.BackColor = Color.Green;
            }

            else if(nation == "Arab Bedouins")
            {
                drawingAreaPanel.BackColor = Color.LightYellow;
            }

            else if(nation == "Egyptian Kings")
            {
                drawingAreaPanel.BackColor = Color.Yellow;
            }

            else if(nation == "Inuit Hunters")
            {
                drawingAreaPanel.BackColor = Color.White;
            }

            else
            {
                drawingAreaPanel.BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            }*/

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            drawingAreaPanel.Refresh();
            //drawingAreaPanel.BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            villageNameBox.Clear();
            nationTypeCombo.SelectedItem = null;
        }

        public void SaveState()
        {
            village.Name = villageNameBox.Text;
            village.H_locations = houseLocations;
            village.T_locations = treeLocations;
            village.W_locations = waterLocation;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        
    }
}
