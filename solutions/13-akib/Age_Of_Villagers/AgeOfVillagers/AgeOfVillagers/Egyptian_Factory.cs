using System;

namespace AgeOfVillagers
{
    internal class Egyptian_Factory : Shape
    {
        public override I_Shape Get_Item(string Item_Type)
        {
            if (Item_Type == "Tree")
                return new Egyptian_Tree();
            else if (Item_Type == "House")
                return new Egyptian_House();
            else if (Item_Type == "Water_Resource")
                return new Egyptian_WaterRes();
            else
                throw new NotSupportedException();
        }
    }
}