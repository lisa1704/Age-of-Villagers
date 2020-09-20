using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.Shape_implementing_Classes
{
    class NullShape : Shapes
    {
        private string hint;
        private string[] splittedHints;
        

        public NullShape(string hint)
        {
            this.hint = hint;
        }

        public void makeShape()
        {
            splittedHints = hint.Split(",");
            MessageBox.Show(splittedHints[1] + Constants.conversion_error_message + splittedHints[0] );
        }
    }
}
