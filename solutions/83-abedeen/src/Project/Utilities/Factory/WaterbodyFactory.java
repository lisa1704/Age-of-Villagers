package Project.Utilities.Factory;

import Project.Utilities.NationItems.*;

public class WaterbodyFactory implements IAssetFactory{
    IWaterBody waterBody;
    @Override
    public IWaterBody CreateAsset(String nationType) {
        if(nationType == "Bangladeshi Farmers"){
            waterBody = new Bangladeshi_Waterbody();
        }
        else if(nationType == "Egyptian Kings"){
            waterBody = new Egyptian_Kings_Waterbody();
        }
        else {
            waterBody = new Null_Water_Body();
        }
        return waterBody;
    }
}
