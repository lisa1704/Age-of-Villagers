using System;

namespace AgeOfVillagers
{
    internal class Arab_Factory : Shape
    {
        public override I_Shape Get_Item(string Item_Type)
        {
            if (Item_Type == "Tree")
                return new Arab_Tree();
            else if (Item_Type == "House")
                return new Arab_House();
            else
                throw new NotSupportedException();
        }
    }
}