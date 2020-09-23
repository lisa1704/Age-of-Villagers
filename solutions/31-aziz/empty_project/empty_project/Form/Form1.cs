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
        VillageSaveOpen saveOpenVillage;
        Village village;
        String NameofVillage;

        public Form1()
        {
            InitializeComponent();
            village = new Village();
            saveOpenVillage = new VillageSaveOpen(village);
            chooseNation = new SelectNation(DrawingPanel);
            NationBox.SelectedIndex = -1;
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs paint)
        {
            
        }

        private void SaveVillage_Click(object sender, EventArgs e)
        {
            saveOpenVillage.saveVillageState(village);
            MessageBox.Show("Village Saved");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            EnterText.Clear();
            Refresh();
            village.RefreshVillage();
        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
            if (NationBox.SelectedIndex != -1)
            {
                village = saveOpenVillage.openVillageState();
                Refresh();
                village.draw(nation);
                MessageBox.Show("Village Opened");
            }
            else
                MessageBox.Show("Please select your Nation first");
        }

        private void DrawingPanel_MouseClick(object sender, MouseEventArgs click)
        {
            if (element_text == "House")
            {
                village.insertHouse(new Axis(click.X, click.Y), nation);
            }
            if (element_text == "Tree")
            {
                village.insertTree(new Axis(click.X, click.Y), nation);
            }
            if (element_text == "Water Source")
            {
                village.insertWaterSource(new Axis(click.X, click.Y), nation);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nation = chooseNation.NationIndex(NationBox.SelectedIndex);
            Refresh();
            village.draw(nation);
        }

        private void radioButtonTree_Click(object sender, EventArgs e)
        {
            element_text = "Tree";
        }

        private void radioButtonHouse_Click(object sender, EventArgs e)
        {
            element_text = "House";
        }

        private void radioButtonWaterSource_Click(object sender, EventArgs e)
        {
            element_text = "Water Source";
        }

        private void EnterText_Click(object sender, EventArgs e)
        {

        }

        private void EnterText_TextChanged(object sender, EventArgs e)
        {
            NameofVillage = EnterText.Text;
        }
    }
}
