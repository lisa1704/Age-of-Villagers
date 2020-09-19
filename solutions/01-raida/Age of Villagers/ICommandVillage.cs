namespace Age_of_Villagers
{
    public interface ICommandVillage
    {
        village execute(string path, INation nation);
    }
}
