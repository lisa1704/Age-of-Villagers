namespace age_of_villagers
{
    class NationFactory
    {
        public INation GetNation(string nation_name)
        {
            return new Bangladeshifarmer();
        }
    }
}
