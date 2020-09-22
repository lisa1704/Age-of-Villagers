package project.Utilities;

import javafx.scene.shape.Shape;
import project.Utilities.Factories.HouseFactory;
import project.Utilities.Factories.IAssetFactory;
import project.Utilities.Factories.TreeFactory;
import project.Utilities.Factories.WaterSourceFactory;
import project.Utilities.NationItems.IHouse;
import project.Utilities.NationItems.ITree;
import project.Utilities.NationItems.IWaterSource;

import java.awt.*;
import java.util.ArrayList;

public class NationFactory {
    public IHouse house;
    public ITree tree;
    public IWaterSource waterSource;
    public String terrainColor;


    public String SelectedNation;

    public NationFactory(String SelectedNation){
        IAssetFactory houseFactory = new HouseFactory();
        house = (IHouse) houseFactory.createAsset(SelectedNation);

        IAssetFactory treeFactory = new TreeFactory();
        tree = (ITree) treeFactory.createAsset(SelectedNation);

        IAssetFactory waterSourceFactory = new WaterSourceFactory();
        waterSource = (IWaterSource) waterSourceFactory.createAsset(SelectedNation);

    }


    public String getTerrainColor(String SelectedNation){
        if(SelectedNation == "Bangladeshi Farmers"){
            terrainColor = "#9DE0AD";
        }
        else if(SelectedNation == "Arab Bedouin"){
            terrainColor = "#EDE574";
        }
        else if(SelectedNation == "Egyptian Kings"){
            terrainColor = "#F9D423";
        }
        else if(SelectedNation == "Inuit Hunters"){
            terrainColor = "WHITE";
        }
        return terrainColor;
    }

    public ArrayList<Shape> drawHouse(double x, double y){
        return this.house.drawAsset(x,y);
    }
    public ArrayList<Shape> drawTree(double x, double y) {return this.tree.drawAsset(x,y); }
    public ArrayList<Shape> drawWaterSource(double x, double y) { return this.waterSource.drawAsset(x,y);}

}
