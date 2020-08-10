using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DesignPatternLab
{
    public class AgeOfVillagers
    {
        private void Form1_Paint(object sender,
            System.Windows.Forms.PaintEventArgs pe)
        {
            // Declares the Graphics object and sets it to the Graphics object  
            // supplied in the PaintEventArgs.  
            Graphics g = pe.Graphics;
            // Insert code to paint the form here.  
        }
        public int sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
