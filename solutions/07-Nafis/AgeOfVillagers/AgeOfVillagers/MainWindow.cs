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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AgeOfVillagers
{
    public partial class MainWindow : Form
    {

        int x;
        int y;
        string objectName;
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

            if(objectName == "TREE")
            {
                treeLocations.Add(e.Location);
                //Debug.WriteLine(treeLocations.Count);
            }
            else if(objectName == "HOUSE")
            {
                houseLocations.Add(e.Location);
            }
            else
            {
                waterLocation.Add(e.Location);
            }

            //Console.WriteLine(houseLocations);
            foreach(Point point in treeLocations)
            {
                currentNation.DrawTree(point.X, point.Y, g);
            }

            foreach(Point point in houseLocations)
            {
                currentNation.DrawHouse(point.X, point.Y, g);
            }

            foreach (Point point in waterLocation)
            {
                currentNation.DrawWater(point.X, point.Y, g);
            }
        }

        private void TreeButton_MouseClick(object sender, MouseEventArgs e)
        {
            objectName = "TREE";
        }

        private void houseButton_MouseClick(object sender, MouseEventArgs e)
        {
            objectName = "HOUSE";
        }

        private void waterButton_MouseClick(object sender, MouseEventArgs e)
        {
            objectName = "WATER";
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
            drawingAreaPanel.BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            villageNameBox.Clear();
            nationTypeCombo.SelectedItem = null;
            houseLocations.Clear();
            treeLocations.Clear();
            waterLocation.Clear();
            
        }

        public void Set_to_state()
        {
            village.Name = villageNameBox.Text;
            village.H_locations = houseLocations;
            village.T_locations = treeLocations;
            village.W_locations = waterLocation;
            village.nation = nation;

        }

        public void Get_from_state(VillageState village)
        {

            villageNameBox.Text = village.Name;
            nation = village.nation;
            houseLocations = village.H_locations;
            treeLocations = village.T_locations;
            waterLocation = village.W_locations;
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "AOV files|*.aov";
            sfd.FileName = "New Save";

            Set_to_state();

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                JsonWriter jw = new JsonTextWriter(sw);

                serializer.Serialize(jw, village);

                jw.Close();
                sw.Close();
                sw.Dispose();

            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                newButton_Click(sender, e);
                StreamReader sr = new StreamReader(ofd.FileName);

                village = (VillageState)serializer.Deserialize(sr, typeof(VillageState));

                sr.Close();
                sr.Dispose();
            }
            g = drawingAreaPanel.CreateGraphics();

            Get_from_state(village);
            drawingAreaPanel.Refresh();
        }
    }
}
