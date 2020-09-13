namespace AgeOfVillagers
{
    public interface INationFactory
    {
        string NationName { get; set; }
        INation GetNation();
    }
}
