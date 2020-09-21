namespace ageOfVillagers
{
    internal class ArabFactory : Shape
    {
        public override IShape GetItem(string itemType)
        {
            if (itemType == "tree")
                return new ArabTree();
            else if (itemType == "house")
                return new ArabHouse();
            else
                return null;
        }
    }
}