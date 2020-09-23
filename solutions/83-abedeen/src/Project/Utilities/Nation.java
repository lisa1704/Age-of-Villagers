package Project.Utilities;
import Project.Utilities.Factory.HouseFactory;
import Project.Utilities.Factory.IAssetFactory;
import Project.Utilities.Factory.TreeFactory;
import Project.Utilities.Factory.WaterbodyFactory;
import Project.Utilities.NationItems.*;
import javafx.scene.shape.Shape;
import java.util.ArrayList;

public class Nation {
    private IHouse house;
    private ITree tree;
    private IWaterBody water_body;
    private INationColor terrainColor;

    public Nation(String nation_type){
        IAssetFactory houseFactory = new HouseFactory();
        IAssetFactory treeFactory = new TreeFactory();
        IAssetFactory waterbodyFactory = new WaterbodyFactory();

        house = (IHouse) houseFactory.CreateAsset(nation_type);
        tree = (ITree) treeFactory.CreateAsset(nation_type);
        water_body = (IWaterBody) waterbodyFactory.CreateAsset(nation_type);

        ColorFactory(nation_type);
    }
    private void ColorFactory(String nationType){
        if(nationType == "Bangladeshi Farmers"){
            terrainColor = new BangladeshiFarmers();
        }
        else if(nationType == "Arab Bedouins"){
            terrainColor = new Arab_Bedouin_Terrain();
        }
        else if(nationType == "Egyptian Kings"){
            terrainColor = new Egyptian_Kings_Terrain();
        }
        else if(nationType == "Inuit Hunters"){
            terrainColor = new Inuit_Hunters_Terrain();
        }
        else {
            terrainColor = new Null_Color();
        }
    }


    public ArrayList<Shape> drawHouse(double x, double y){
        return this.house.drawAsset(x,y);
    }
    public ArrayList<Shape> drawTree(double x, double y){ return this.tree.drawAsset(x,y); }
    public ArrayList<Shape> drawWaterBody(double x, double y){ return this.water_body.drawAsset(x,y); }
    public String GetTerrainColor(){ return this.terrainColor.GetNationColor(); }
}
