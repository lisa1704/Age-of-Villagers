namespace ageOfVillagers
{
    internal class BangladeshFactory : Shape
    {
        public override IShape GetItem(string itemType)
        {
            if (itemType == "tree")
                return new Bdtree();
            else if (itemType == "house")
                return new Bdhouse();
            else if (itemType == "water")
                return new Bdwater();
            else
                return null;
        }
    }
}