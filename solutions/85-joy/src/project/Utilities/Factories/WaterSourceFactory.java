package project.Utilities.Factories;

import project.Utilities.NationItems.*;

public class WaterSourceFactory implements IAssetFactory{
    public IWaterSource waterSource;

    @Override
    public IAssets createAsset(String nationType) {
        this.waterSource = null;
        if(nationType == "Bangladeshi Farmers"){
            waterSource = new Bangladeshi_Farmers_WaterSource();
        }
        else if(nationType == "Arab Bedouin"){
            waterSource = null;
        }
        else if(nationType == "Egyptian Kings"){
            waterSource = new Egyptian_Kings_WaterSource();
        }
        else if(nationType == "Inuit Hunters"){
            waterSource = null;
        }


        return waterSource;
    }
}
