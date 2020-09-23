package nation;

import canvas.MyCanvas;

public class NationFactory {

    public INation getNation(String nationType) {

        if (nationType.equals( "Bangladeshi Farmer"))
            return new BDFarmers();
        else if (nationType.equals("Arab Bedouin"))
            return new ArabBedouins();
        else if (nationType.equals( "Egyptian King"))
            return new EgyptianKings();
        else if (nationType.equals( "Inuit Hunter"))
            return new InuitHunters();
        else {
            NoNationSingleton noNationSingleton = NoNationSingleton.getInstance();
            return noNationSingleton.getNation();
        }
    }
}
