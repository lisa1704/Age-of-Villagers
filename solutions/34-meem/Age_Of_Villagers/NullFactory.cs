

namespace Age_Of_Villagers
{
    internal class NullFactory : ItemFactory
    {
        public override IVillageItem getItem(string button)
        {

            return new NullItem();
        }
    }
}