package project.Utilities;

import java.io.Serializable;
import java.util.ArrayList;

public class Villages implements Serializable {
    public String VillageName;
    public ArrayList<VillageState> assetList;

    public Villages(String Name){
        this.VillageName = Name;
        assetList = new ArrayList<VillageState>();
    }

    public void AddAsset(double x, double y , String AssetType){
        VillageState currentState = new VillageState(x,y,AssetType);
        this.assetList.add(currentState);
    }

    public void SaveVillage(){

    }

    public void LoadVillage(){

    }
}
