namespace ageOfVillagers
{
    internal class SaveVillageState
    {
		public string Save()
		{
			VillageState state = new VillageState();
			state.GetState();
			return "Saving the village. ";
		}
	}
}