using System;

namespace AgeOfVillagers
{
    internal class Bangladeshi_Factory : Shape
    {
        public override I_Shape Get_Item(string Item_Type)
        {
            if (Item_Type == "Tree")
                return new Bangladeshi_Tree();
            else if (Item_Type == "House")
                return new Bangladeshi_House();
            else if (Item_Type == "Water_Resource")
                return new Bangladeshi_WaterRes();
            else
                throw new NotSupportedException();
        }
    }
}