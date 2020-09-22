package project.Utilities;

import java.io.FileOutputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;
import java.util.ArrayList;

public class Villages implements Serializable {
    public String VillageName;
    public ArrayList<VillageState> assetList;

    public Villages(String Name){
        this.VillageName = Name;
        assetList = new ArrayList<VillageState>();
    }

    public ArrayList<VillageState> AddAsset(double x, double y , String AssetType){
        VillageState currentState = new VillageState(x,y,AssetType);
        this.assetList.add(currentState);
        return assetList;
    }

    public void SaveVillage(String Village_Name){
        String Filename = Village_Name + ".aov";
//        JSONObject obj = new JSONObject();
//        obj.put("Village_Name",Village_Name.getText());
//        obj.put("Nation",NationDropDown.getValue());
//        Villages villages = new Villages(Village_Name.getText(), (String) NationDropDown.getValue());
        try {
            FileOutputStream file = new FileOutputStream("SavedVillages/"+Filename);
            ObjectOutputStream out = new ObjectOutputStream(file);
//            out.writeObject(villages);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void LoadVillage(){

    }
}
