namespace Age_Of_Villagers
{
    internal class InuitItemFactory : ItemFactory
    {
        public override IVillageItem getItem(string button)
        {
            if (button == "House")
            {
                return new InuitHunterHouse();
            }
            return new NullItem(); ;
        }
    }
}