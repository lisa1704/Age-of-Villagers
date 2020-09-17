﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.Environment_extending_Classes
{
    class ArabianEnvironmet : Environment
    {
        private Label nation_Name;
        private RadioButton secondNation;
        private RadioButton thirdNation;
        private RadioButton fourthNation;
        private RadioButton tree;
        private RadioButton house;
        private RadioButton waterSource;
        private Graphics graphics;
        private string selectedNation;

        public ArabianEnvironmet(Label nation_Name, RadioButton secondNation, RadioButton thirdNation, RadioButton fourthNation, RadioButton tree, RadioButton house, RadioButton waterSource, Graphics graphics, string selectedNation)
        {
            this.nation_Name = nation_Name;
            this.secondNation = secondNation;
            this.thirdNation = thirdNation;
            this.fourthNation = fourthNation;
            this.tree = tree;
            this.house = house;
            this.waterSource = waterSource;
            this.graphics = graphics;
            this.selectedNation = selectedNation;
        }

        public override void ValidateOtherGameElements()
        {
            secondNation.Hide();
            thirdNation.Hide();
            fourthNation.Hide();
            waterSource.Hide();
        }

        public override void setTerrainColor()
        {
            
        }

        public override void showNationName()
        {
            nation_Name.Text = selectedNation;
        }
    }
}
