package Project.Utilities;

public class NationFactory {
    public INations nation;
    public String nationName;

    public NationFactory(String nationName){
        this.nationName = nationName;
    }

    public INations createNation(){
        if(this.nationName == "Bangladeshi Farmers"){
            nation = new Bangladeshi_Farmers();
        }
        else if (this.nationName == "Arab Bedouins"){
            nation = new Arab_Bedouins();
        }
        return nation;
    }
}
