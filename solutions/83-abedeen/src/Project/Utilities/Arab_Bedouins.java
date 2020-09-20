package Project.Utilities;

import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Arab_Bedouins implements INations{
    private String TerrainColor = "#fffec4";
    public Arab_Bedouins(){
        super();
    }

    @Override
    public ArrayList<Shape> drawHouse(double x, double y) {
        return null;
    }

    @Override
    public ArrayList<Shape> drawTree(double x, double y) {
        return null;
    }

    @Override
    public ArrayList<Shape> drawWaterBody(double x, double y) {
        ArrayList<Shape> WB = new ArrayList<Shape>();
        return WB;
    }

    @Override
    public String GetTerrainColor() {
        return this.TerrainColor;
    }
}
