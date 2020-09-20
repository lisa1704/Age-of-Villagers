using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_Test
{
    static class Program
    {
        //private static Graphics g;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



            //NationFactory nationFactory = new NationFactory(g);

            
            //INation nation1 = nationFactory.GetNation("BangladeshiFarmers");

            
           // nation1.DrawHouse(Point e, Graphics g, Pen mypen);

            //get an object of Rectangle and call its draw method.
            //INation nation2 = nationFactory.GetNation("ArabBedouin");

           
            //nation2.draw();

            
            //INation nation3 = nationFactory.GetNation("EgyptianKing");

            
            //ation2.draw();
        }
        
    }
}
