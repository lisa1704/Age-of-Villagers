﻿using System;
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
    public partial class VillageMain : Form
    {
        Color getColor;
        string villageName;
        string nation;
        string selectedItem;

        ConcreteNation nationType = new ConcreteNation();

        public VillageMain()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nation = comboBox1.Text;
            getColor = nationType.checkNation(nation).DrawTerrain();
            panel1.BackColor = getColor;
        }
    }
}
