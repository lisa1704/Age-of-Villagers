package project.Utilities;

import java.io.Serializable;

public class Villages implements Serializable {
    public String VillageName;
    public Object Nation;

    public Villages(String Name, String nation){
        this.Nation = nation;
        this.VillageName = Name;
    }
}
