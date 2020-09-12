namespace AgeOfVillagers
{
    public interface INationFactory
    {
        INation getNation();
    }

    public class ArabBedouin_Factory : INationFactory
    {
        public INation getNation()
        {
            return new ArabBedouin();
        }
    }

    public class BangladeshiFarmer_Factory : INationFactory
    {
        public INation getNation()
        {
            return new BangladeshiFarmers();
        }
    }

    public class EgyptianKings_Factory : INationFactory
    {
        public INation getNation()
        {
            return new EgyptianKings();
        }
    }
}
