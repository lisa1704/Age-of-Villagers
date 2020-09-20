package Project.Utilities;

import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Arab_Bedouins implements INations{
    private String TerrainColor = "#fffde3";
    public Arab_Bedouins(){
        super();
    }

    @Override
    public ArrayList<Shape> drawHouse(double x, double y) {
        ArrayList<Shape> house = new ArrayList<Shape>();
        //Triangle
        house.add(new Line(x,y,x+(3*houseWidth/4),y));
        house.add(new Line(x+(3*houseWidth/4),y,x+(3*houseWidth/4)/2,y-(3*houseHeight/4)));
        house.add(new Line(x+(3*houseWidth/4)/2,y-(3*houseHeight/4),x,y));

        //Rectangle
        house.add(new Line(x+(3*houseWidth/4),y,x+houseWidth,y-(houseHeight/4)));
        house.add(new Line(x+(3*houseWidth/4)/2,y-(3*houseHeight/4),x+((3*houseWidth/4)/2)+(houseWidth/4),y-houseHeight));
        house.add(new Line(x+houseWidth,y-(houseHeight/4),x+((3*houseWidth/4)/2)+(houseWidth/4),y-houseHeight));
        return house;
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
