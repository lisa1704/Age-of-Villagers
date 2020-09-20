using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class OpenVillageNation : Form
    {
        private readonly Form1 main;
        private readonly VillageState villageState;
        private readonly Graphics g;
        private readonly Pen pen;
        private readonly Panel panel;

        public OpenVillageNation(Form1 main,VillageState villageState,Graphics g ,Pen pen,Panel panel)
        {
            InitializeComponent();
            this.main = main;
            this.villageState = villageState;
            this.g = g;
            this.pen = pen;
            this.panel = panel;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            NationManager manager = new NationManager(Opencombobox.Text);

            OpenVillageEdit opn = new OpenVillageEdit(g,pen,panel);
            main.NationName.Text = Opencombobox.Text;
            main.VillageName.Text = villageState._name;

            panel.BackColor = manager.getNation(new Point()).GetTerritoryColor();
            panel.Refresh();

            opn.ResetState(villageState, Opencombobox.Text);

            this.Hide();
        }

        private void Opencomboboc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
