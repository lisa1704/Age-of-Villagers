package nation;

public class NationFactory {

    public INation getNation(String nationType) {

        if (nationType == "Bangladeshi Farmer")
            return new BDFarmers();
        else if (nationType == "Arab Bedouin")
            return new ArabBedouins();
        else if (nationType == "Egyptian King")
            return new EgyptianKings();
        else if (nationType == "Inuit Hunter")
            return new InuitHunters();
        else {
            return new NoNations();
        }
    }
}
