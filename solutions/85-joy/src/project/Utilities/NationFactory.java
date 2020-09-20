package project.Utilities;

public class NationFactory {
    public INation nation;
    public String SelectedNation;

    public NationFactory(String SelectedNation){
        this.SelectedNation = SelectedNation;
    }

    public INation createNation(){
        this.nation = null;
        if(SelectedNation == "Bangladeshi Farmers"){
            nation = new BangladeshiFarmers();
        }
        else if(SelectedNation == "Arab Bedouin"){
            nation = new ArabBedouin();
        }
        else if(SelectedNation == "Egyptian Kings"){
            nation = new EgyptianKings();
        }

        return nation;
    }
}
