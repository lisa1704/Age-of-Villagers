using System;

namespace AgeOfVillagers
{
    internal class Inuit_Factory : Shape
    {
        public override I_Shape Get_Item(string Item_Type)
        {
            if (Item_Type == "House")
                return new InuitHunters_House();
            else
                throw new NotSupportedException();
        }
    }
}