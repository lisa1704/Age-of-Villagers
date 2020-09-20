using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class InputValidation
    {
        private string inputString;
        public Boolean checkStringInput(String inputString)
        {
            Regex pattern = new Regex(@"^[a-zA-Z]+$");

            
            if (!pattern.IsMatch(inputString))
            {

                MessageBox.Show(Constants.string_invalid_message);
                return false;
            }
            return true;
        }

        public Boolean checkPoints(Point point)
        {
            if(point.X<Constants.PANEL_BORDER || point.X>Constants.PANEL_WIDTH- Constants.PANEL_BORDER ||point.Y< Constants.PANEL_BORDER || point.Y> Constants.PANEL_HEIGHT - Constants.PANEL_BORDER)
            {
                MessageBox.Show(Constants.string_invalid_message);
                return false;
            }
            return true;
        }

    }
}
