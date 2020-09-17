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
        private RadioButton egyptians;
        private RadioButton arabians;
        private RadioButton hunters;
        private Graphics graphics;
        private string selectedNation;

        public BangladeshiEnvironment(Label nation_Name, RadioButton egyptians, RadioButton arabians, RadioButton hunters, Graphics graphics, string selectedNation
            )
        {
            this.nation_Name = nation_Name;
            this.egyptians = egyptians;
            this.arabians = arabians;
            this.hunters = hunters;
            this.graphics = graphics;
            this.selectedNation = selectedNation;
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
