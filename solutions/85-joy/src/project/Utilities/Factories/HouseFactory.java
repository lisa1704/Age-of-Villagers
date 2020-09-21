package project.Utilities.Factories;

import project.Utilities.NationItems.*;

public class HouseFactory implements IAssetFactory{
    public IHouse house;

    public HouseFactory(){

    }
    @Override
    public IHouse createAsset(String nationType) {
        this.house = null;
        if(nationType == "Bangladeshi Farmers"){
            house = new Bangladeshi_Farmers_House();
        }
        else if(nationType == "Arab Bedouin"){
            house = new Arab_Bedouin_House();
        }
        else if(nationType == "Egyptian Kings"){
            house = new Egyptian_Kings_House();
        }
        else if(nationType == "Inuit Hunters"){
            house = new Iuit_Hunters_House();
        }
        else{
            house = new Null_House();
        }

        return house;
    }
}
