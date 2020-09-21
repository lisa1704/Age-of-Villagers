package Project.Utilities;
import Project.Utilities.NationItems.*;
import javafx.scene.shape.Shape;
import java.util.ArrayList;

public class Nation {
    private IHouse house;
    private ITree tree;
    private IWaterBody water_body;
    private INationColor terrainColor;

    public Nation(String nation_type){
        if(nation_type == "Bangladeshi Farmers"){
            this.house = new Bangladeshi_House();
            this.tree = new Bangladeshi_Tree();
            this.water_body = new Bangladeshi_Waterbody();
            this.terrainColor = new BangladeshiFarmersColor();
        }
        else if(nation_type == "Arab Bedouins"){
            this.house = new Arab_Bedouin_House();
            this.tree = new Arab_Bedouin_Tree();
            this.water_body = new Null_Water_Body();
            this.terrainColor = new Arab_Bedouin_TerrainColor();
        }
        else if(nation_type == "Egyptian Kings"){
            this.house = new Egyptian_Kings_House();
            this.tree = new Egyptian_Kings_Tree();
            this.water_body = new Egyptian_Kings_Waterbody();
            this.terrainColor = new Egyptian_Kings_Terrain();
        }
        else if(nation_type == "Inuit Hunters"){
            this.house = new Inuit_Hunters_House();
            this.tree = new Null_Tree();
            this.water_body = new Null_Water_Body();
            this.terrainColor = new Inuit_Hunters_Terrain();
        }

    }

    public ArrayList<Shape> drawHouse(double x, double y){
        return this.house.drawHouse(x,y);
    }
    public ArrayList<Shape> drawTree(double x, double y){ return this.tree.drawTree(x,y); }
    public ArrayList<Shape> drawWaterBody(double x, double y){ return this.water_body.drawWaterBody(x,y); }
    public String GetTerrainColor(){ return this.terrainColor.GetNationColor(); }
}
