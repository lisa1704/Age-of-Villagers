namespace ageOfVillagers
{
    internal class EgyptFactory : Shape
    {
        public override IShape GetItem(string itemType)
        {
            if (itemType == "tree")
                return new EgyptTree();
            else if (itemType == "house")
                return new EgyptHouse();
            else if (itemType == "water")
                return new EgyptWater();
            else
                return null;
        }
    }
}