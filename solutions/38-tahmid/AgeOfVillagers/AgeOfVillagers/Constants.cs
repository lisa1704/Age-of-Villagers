using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    abstract class Constants
    {
        public static string error_message = "Please enter your village name";

        //state elements
        public static string VILLAGE_NAME_ELEMENT_HINT = "Village Name";
        public static string VILLAGE_ITEMS_ELEMENT_HINT = "Village Item";

        //shape hints
        public static string RECT_HINT = "Rectangle";
        public static string TRIANGLE_HINT = "Tryangle";
        public static string OVAL_HINT = "OVAL";
        public static string UNEQUAL_NONAGON_HINT = "Unequal Nonago";


       


        //house pixell range
        public static int HOUSE_HEIGHT = 16;
        public static int HOUSE_WIDTH = 16;

        //tree pixell range
        public static int TREE_HEIGHT = 24;
        public static int TREE_WIDTH = 16;

        //bangladeshi water source range
        public static int BDWaterSource_HEIGHT = 24;
        public static int BDWATERSOURCE_WIDTH = 16;

        //Arabian water source range
        public static int Egyptian_WATER_SOURCE_HEIGHT = 12;
        public static int Egyptian_WATER_SOURCE_WIDTH = 12;


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
        public static string DEFAULT_NATION = "Default Nation";

        //Shape hints
        public static string BDTREE_HINT = "Bangladeshi_Farmer" + "TREE";
        public static string BDWATERSOURCE_HINT = "Bangladeshi_Farmer" + "WATER SOURCE";

        //Panel Size
        public static int PANEL_HEIGHT = 600;
        public static int PANEL_WIDTH = 400;
        public static int PANEL_STARTING_POINT_X = 0;
        public static int PANEL_STARTING_POINT_y = 0;

        //Color
        public static Color BANGLADESHI_COLOR = Color.Green;
        public static Color EGYPTIAN_COLOR = Color.Yellow;
        public static Color INUIT_COLOR = Color.White;
        public static Color ARABIAN_COLOR = Color.LightYellow;
        public static Color DEFAULT_COLOR = Color.White;

    }
}
