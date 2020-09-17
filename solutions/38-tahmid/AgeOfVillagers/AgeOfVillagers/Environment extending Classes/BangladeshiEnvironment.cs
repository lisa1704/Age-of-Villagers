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
        private RadioButton seconNation1;
        private RadioButton thirdNation;
        private RadioButton fourthNation;
        private RadioButton tree;
        private RadioButton house;
        private RadioButton waterSource;
        private Graphics graphics;
        private RadioButton seconNation2;

        public BangladeshiEnvironment(Label nation_Name, RadioButton seconNation1, RadioButton thirdNation, RadioButton fourthNation, RadioButton tree, RadioButton house, RadioButton waterSource, Graphics graphics, RadioButton seconNation2)
        {
            this.nation_Name = nation_Name;
            this.seconNation1 = seconNation1;
            this.thirdNation = thirdNation;
            this.fourthNation = fourthNation;
            this.tree = tree;
            this.house = house;
            this.waterSource = waterSource;
            this.graphics = graphics;
            this.seconNation2 = seconNation2;
        }

        public override void showNationName()
        {
            nation_Name.Text = selectedNation;
        }

        public override void InvalidateOtherNations()
        {
            egyptians.Hide();
            arabians.Hide();
            hunters.Hide();
        }

        public override void setTerrainColor()
        {
            SolidBrush sb = new SolidBrush(Color.Green);
            graphics.FillRectangle(sb, 0, 0, 600, 400);
        }
    }
}
