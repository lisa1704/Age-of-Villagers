namespace ageOfVillagers
{
    internal class InuitFactory : Shape
    {
        public override IShape GetItem(string itemType)
        {
            if (itemType == "house")
                return new InuitHouse();
            else
                return null;
        }
    }
}