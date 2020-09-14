using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    abstract class Constants
    {
        public static string error_message = "Please enter your village name";
        

        //shape hints
        public static string RECT_HINT = "Rectangle";
        public static string TRIANGLE_HINT = "Tryangle";
        public static string OVAL_HINT = "OVAL";

        //Item hints
        public static string BDTREE_HINT = "Bangladeshi Farmer,Tree";


        //house pixell range
        public static int HOUSE_HEIGHT = 16;
        public static int HOUSE_WIDTH = 16;

        //tree pixell range
        public static int TREE_HEIGHT = 24;
        public static int TREE_WIDTH = 16;

        //bangladeshi tree angle range
        public static int OVAL_STARTING_ANG = 0;
        public static int OVAL_ENDING_ANG = 360;


    }
}
