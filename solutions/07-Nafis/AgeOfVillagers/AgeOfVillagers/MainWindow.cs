using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        JsonSerializer serializer = new JsonSerializer();

        public List<Point> houseLocations = new List<Point>();
        public List<Point> treeLocations = new List<Point>();
        public List<Point> waterLocation = new List<Point>();

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
                //Debug.WriteLine(treeLocations.Count);
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
            Console.WriteLine(houseLocations);

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
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "AOV files|*.aov";
            sfd.FileName = "New Save";

            SaveState();

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                JsonWriter jw = new JsonTextWriter(sw);

                serializer.Serialize(jw, village);

                jw.Close();
                sw.Close();

            }
        }

        
    }
}
