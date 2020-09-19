using System;

public class SaveVillageState
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
		SaveVillageState state = new SaveVillageState();
		state.getState(villagename);
		return "Saved !";
    }
}
