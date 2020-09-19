using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empty_project
{
    public partial class Form1 : Form
    {
        INation nation;
        SelectNation chooseNation;
        String element_text;

        public Form1()
        {
            InitializeComponent();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs paint)
        {
            
        }

        private void SaveVillage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Village Saved");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Tree_Click(object sender, EventArgs e)
        {
            element_text = "Tree";
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {

        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Village Opened");
        }

        private void House_Click(object sender, EventArgs e)
        {
            element_text = "House";
        }

        private void WaterSource_Click(object sender, EventArgs e)
        {
            element_text = "Water Source";
        }

        private void DrawingPanel_MouseClick(object sender, MouseEventArgs click)
        {
            if (element_text == "Tree")
            {
                
            }
            if (element_text == "House")
            {
                
            }
            if (element_text == "WaterSource")
            {
                
            }
            DrawingPanel.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nation = chooseNation.NationIndex(NationBox.SelectedIndex);
        }
    }
}
