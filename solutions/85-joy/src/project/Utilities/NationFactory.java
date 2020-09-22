package project.Utilities;

import javafx.scene.shape.Shape;
import project.Utilities.Factories.HouseFactory;
import project.Utilities.Factories.IAssetFactory;
import project.Utilities.NationItems.IHouse;
import project.Utilities.NationItems.ITree;

import java.awt.*;
import java.util.ArrayList;

public class NationFactory {
    public IHouse house;
    public ITree tree;

    public INation nation;
    public String SelectedNation;

    public NationFactory(String SelectedNation){
        IAssetFactory houseFactory = new HouseFactory();
        house = (IHouse) houseFactory.createAsset(SelectedNation);


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
        else if(SelectedNation == "Inuit Hunters"){
            nation = new InuitHunters();
        }

        return nation;
    }

    public ArrayList<Shape> drawHouse(double x, double y){
        return this.house.drawAsset(x,y);
    }

}
