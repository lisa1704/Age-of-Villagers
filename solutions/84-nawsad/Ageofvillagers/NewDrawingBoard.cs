using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ageofvillagers
{
    public partial class Ageofvillagers : Form
    {
        private Panel drawingboard;
        private void button4_Click(object sender, EventArgs e)
        {
            drawingboard             = new System.Windows.Forms.Panel();
            drawingboard.BackColor   = System.Drawing.SystemColors.ActiveCaptionText;
            drawingboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            drawingboard.Font        = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            drawingboard.Location    = new System.Drawing.Point(0, 0);
            drawingboard.Name        = "Drawingboard";
            drawingboard.Size        = new System.Drawing.Size(600, 400);
            drawingboard.TabIndex    = 1;
            Controls.Add(drawingboard);
        }
    }
}
