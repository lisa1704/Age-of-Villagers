package Project.Utilities;

import Project.Utilities.NationItems.Bangladeshi_House;
import Project.Utilities.NationItems.IHouse;

public class Nation {
    private IHouse house;

    public Nation(String nation_type){
        if(nation_type == "Bangladeshi Farmers"){
            house = new Bangladeshi_House();
        }
    }
}
