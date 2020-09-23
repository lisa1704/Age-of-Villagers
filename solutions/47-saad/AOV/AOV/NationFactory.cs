namespace AOV
{
    class NationFactory
    {
        public INation SelectNation(string typeOfNation)
        {
            switch (typeOfNation)
            {
                case "Arab Bedouin":
                    return new ArabNation();
                case "Egyptian Kings":
                    return new EgyptianNation();
                case "Bangladeshi Farmers":
                    return new BangladeshiNation();
                case "Inuit Hunters":
                    return new InuitNation();
                default:
                    return new NullNation();
            }
        }
    }
}
