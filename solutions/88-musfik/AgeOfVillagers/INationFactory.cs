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
}
