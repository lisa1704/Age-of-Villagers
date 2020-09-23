﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public partial class ConfirmName : Form
    {
        private Panel VillageDrawing;
        private readonly VillageWindow primary;
        public ConfirmName(VillageWindow villageWindow, Panel panel)
        {
            InitializeComponent();
            primary = villageWindow;
            VillageDrawing = panel;
        }

        private void ConfirmVillage_Click(object sender, EventArgs e)
        {
            NationController nationController = new NationController(NationNameCombo.Text);
            primary.VillageNameText.Text = VillageNameText.Text;
            primary.NationNameCombo.Text = NationNameCombo.Text;
            VillageDrawing.BackColor = nationController.GetNation(new Point()).GetTerrainColor();
            this.Hide();

        }

        public string GetVillageName()
        {
            return VillageNameText.Text;
        }

        public string GetNationName()
        {
            return NationNameCombo.Text;
        }

    }
}