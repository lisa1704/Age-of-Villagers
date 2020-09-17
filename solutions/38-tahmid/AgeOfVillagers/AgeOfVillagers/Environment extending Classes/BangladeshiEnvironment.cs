using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.Environment_extending_Classes
{
    public class BangladeshiEnvironment : Environment
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

        public BangladeshiEnvironment(Label nation_Name, RadioButton secondNation, RadioButton thirdNation, RadioButton fourthNation, RadioButton tree, RadioButton house, RadioButton waterSource, Graphics graphics, string selectedNation)
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

        public override void showNationName()
        {
            nation_Name.Text = selectedNation;
        }

        public override void InvalidateOtherNations()
        {
            secondNation.Hide();
            thirdNation.Hide();
            fourthNation.Hide();
        }

        public override void setTerrainColor()
        {
            SolidBrush sb = new SolidBrush(Color.Green);
            graphics.FillRectangle(sb, 0, 0, 600, 400);
        }
    }
}
