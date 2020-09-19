namespace ageOfVillagers
{
    internal class SaveVillageState
    {
		MenuForm menuForm = new MenuForm();
		private string nation;
		private string villagename;
		private panel drawingPanel;

		public void setVillage()
		{
			nation = menuForm.Nation.Text;
			villagename = menuForm.VillageName.Text;
			drawingPanel = menuForm.panel1;
		}

		public string save()
		{
			VillageState state = new VillageState();
			state.getState(villagename);
			return "Saving the village. ";
		}
	}
}