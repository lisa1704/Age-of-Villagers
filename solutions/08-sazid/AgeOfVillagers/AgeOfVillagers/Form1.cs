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
        Color backGroundColor;
        string nationName;
        NationFactory nationType = new NationFactory();
        string objectName;
        List<Point> houseLocations = new List<Point>();
        List<Point> treeLocations = new List<Point>();
        List<Point> sourceLocations = new List<Point>();
        Graphics g;


        public Form1()
        {
            InitializeComponent();
        }

        private void houseButton_Click(object sender, EventArgs e)
        {
            objectName = "house";
        }

        private void treeButton_Click(object sender, EventArgs e)
        {
            objectName = "tree";
        }

        private void waterButton_Click(object sender, EventArgs e)
        {
            objectName = "waterSource";
        }

        private void submitName_Click(object sender, EventArgs e)
        {
            villageName.Text = villageNameInput.Text;
            villageNameInput.Text = "Enter Village Name";
            villageNameInput.ForeColor = Color.Silver;
        }

        private void villageNameInput_Enter(object sender, EventArgs e)
        {
            if (villageNameInput.Text == "Enter Village Name")
            {
                villageNameInput.Text = "";

                villageNameInput.ForeColor = Color.Black;
            }
        }

        private void villageNameInput_Leave(object sender, EventArgs e)
        {
            if (villageNameInput.Text == "")
            {
                villageNameInput.Text = "Enter Village Name";

                villageNameInput.ForeColor = Color.Silver;
            }
        }

        private void nationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            nationName = nationList.Text;
            //Console.WriteLine(nationName);
            //nationType=NationFactory
            backGroundColor = nationType.GetNation(nationName).GetColor();
            drawinPanel.BackColor = backGroundColor;
        }

        private void drawinPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = drawinPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            foreach (Point points in houseLocations)
            {
                nationType.GetNation(nationName).DrawHouse(g, points);
            }

            foreach (Point points in treeLocations)
            {
                nationType.GetNation(nationName).DrawTree(g, points);
            }

            foreach(Point points in sourceLocations)
            {
                nationType.GetNation(nationName).DrawWaterResource(g, points);
            }
        }

        private void drawinPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if(objectName == "house")
            {
                houseLocations.Add(e.Location);
            }
            if(objectName == "tree")
            {
                treeLocations.Add(e.Location);
            }
            if(objectName == "waterSource")
            {
                sourceLocations.Add(e.Location);
            }
        }
    }
}
