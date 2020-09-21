package Project.Utilities.Factory;
import Project.Utilities.NationItems.*;


public class HouseFactory implements IAssetFactory{
    public IHouse house;
    @Override
    public IHouse CreateAsset(String nationType) {
        if(nationType == "Bangladeshi Farmers"){
            house = new Bangladeshi_House();
        }
        else if(nationType == "Arab Bedouins"){
            house = new Arab_Bedouin_House();
        }
        else if(nationType == "Egyptian Kings"){
            house = new Egyptian_Kings_House();
        }
        else if(nationType == "Inuit Hunters"){
            house = new Inuit_Hunters_House();
        }
        else {
            house = new Null_House();
        }
        return house;
    }
}
