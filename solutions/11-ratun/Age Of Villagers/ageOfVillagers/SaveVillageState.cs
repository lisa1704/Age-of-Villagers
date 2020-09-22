namespace ageOfVillagers
{
    internal class SaveVillageState
    {
        readonly MenuForm menuForm = new MenuForm();

		public string save()
		{
			VillageState state = new VillageState();
			state.GetState();
			return "Saving the village. ";
		}
	}
}