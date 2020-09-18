package Project.Utilities;

import java.io.Serializable;

public class Village implements Serializable {
    public String Name;
    public String Nation;
    public Village(String name, String nation){
        this.Name = name;
        this.Nation = nation;
    }
}
