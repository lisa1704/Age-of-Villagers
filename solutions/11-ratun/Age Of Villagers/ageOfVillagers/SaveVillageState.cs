namespace ageOfVillagers
{
    internal class SaveVillageState
    {
		MenuForm menuForm = new MenuForm();
		private string nation;
		private string villagename;

		public string save()
		{
			VillageState state = new VillageState();
			state.GetState();
			return "Saving the village. ";
		}
	}
}