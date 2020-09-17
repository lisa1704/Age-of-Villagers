﻿using System;
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
        public static string UNEQUAL_NONAGON_HINT = "Unequal Nonago";


        //Item hints
        public static string BDTREE_HINT = "Bangladeshi Farmer,Tree";
        public static string BDWATERSOURCE_HINT = "Bangladeshi Farmer,Water Source";


        //house pixell range
        public static int HOUSE_HEIGHT = 16;
        public static int HOUSE_WIDTH = 16;

        //tree pixell range
        public static int TREE_HEIGHT = 24;
        public static int TREE_WIDTH = 16;

        //bangladeshi water source range
        public static int BDWaterSource_HEIGHT = 24;
        public static int BDWATERSOURCE_WIDTH = 16;

        //angle range
        public static int OVAL_STARTING_ANG = 0;
        public static int OVAL_ENDING_ANG = 360;

        //Items
        public static string HOUSE_ITEM = "HOUSE";
        public static string TREE_ITEM = "TREE";
        public static string WATER_SOURCE_ITEM = "WATER SOURCE";

        //Nations

        public static string BD_NATION = "Bangladeshi_Farmer";
        public static string ARAB_NATION = "ARAB BEDOUIN";
        public static string EGYPT_NATION = "EGYPTIAN KING";
        public static string INUIT_NATION = "Inuit Hunters";


    }
}
