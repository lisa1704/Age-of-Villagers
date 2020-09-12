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
    public partial class VillageActions : Form
    {
        string item;
        string villageName;
        string villageType;
        public VillageActions()
        {
            InitializeComponent();
        }

        private void NewVillage_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void NationsName(object sender, EventArgs e)
        {
            villageType = (string)Nations.SelectedItem;
            //Console.WriteLine(villageType);
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            //InitializeComponent();
        }

        private void SaveVillage_Click(object sender, EventArgs e)
        {
            villageName = VillageName.Text;
            ConfirmSaveVillage.ShowDialog();
        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {
            DialogResult result = ConfirmOpenVillage.ShowDialog();
        }

        private void House_CheckedChanged(object sender, EventArgs e)
        {
            item = "house";

        }

        private void TreeButton_CheckedChanged(object sender, EventArgs e)
        {
            item = "tree";
        }

        private void WaterSourceButton_CheckedChanged(object sender, EventArgs e)
        {
            item = "water";
        }

        private void DrawingBoardActions(object sender, EventArgs e)
        {
            Village v = new Village(villageType);
            if (item == "house")
                v.GetVillage().DrawHouse();
            if (item == "tree")
                v.GetVillage().DrawTree();
            if (item == "water")
                v.GetVillage().DrawWaterSource();
        }

        private void OptionsBoard_Enter(object sender, EventArgs e)
        {

        }

        private void MousePointer(object sender, PaintEventArgs e)
        {

        }
    }
}
