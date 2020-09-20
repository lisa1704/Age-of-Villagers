package project.Utilities;

public class NationFactory {
    public INation nation;
    public String SelectedNation;

    public NationFactory(String SelectedNation){
        this.SelectedNation = SelectedNation;
        nation = createNation(this.SelectedNation);
    }

    public INation createNation(String SelectedNation){
        this.nation = null;
        if(SelectedNation == "Bangladeshi Farmers"){
            nation = new BangladeshiFarmers();
        }
        else if(SelectedNation == "Arab Bedouin"){
            nation = new ArabBedouin();
        }

        return nation;
    }
}
