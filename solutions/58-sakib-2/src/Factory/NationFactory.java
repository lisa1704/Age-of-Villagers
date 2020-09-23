package Factory;

import Nations.*;

public class NationFactory {
    public INation getNation(String nation){
        if (nation=="Bangladeshi Farmers")return new BangladeshiFarmers();
        else if (nation=="Arab Bedouin")return new ArabBedouin();
        else if (nation=="Egyptian Kings")return new EgyptianKings();
        else if (nation=="Inuit Hunters")return new InuitHunters();
        else return null;
    }
}
