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
        
        public Boolean checkStringInput(String inputString)
        {
            

            
            if (inputString=="" || inputString==null)
            {

                
                return true;
            }
            return false;
        }

        public Boolean checkPoints(Point point)
        {
            if(point.X<Constants.PANEL_BORDER || point.X>Constants.PANEL_WIDTH- Constants.PANEL_BORDER ||point.Y< Constants.PANEL_BORDER || point.Y> Constants.PANEL_HEIGHT - Constants.PANEL_BORDER)
            {
                
                return true;
            }
            return false;
        }

    }
}
