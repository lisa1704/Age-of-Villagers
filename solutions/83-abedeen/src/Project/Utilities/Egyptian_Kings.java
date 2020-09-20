package Project.Utilities;

import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Egyptian_Kings implements INations{
    private double WaterBodyWidth = 12;
    private double WaterBodyheight = 12;
    private String TerrainColor = "yellow";
    public Egyptian_Kings(){
        super();
    }

    @Override
    public ArrayList<Shape> drawHouse(double x, double y) {
        ArrayList<Shape> pyramid = new ArrayList<>();
        Line l1 = new Line(x,y,x+houseWidth*3/5,y+houseHeight/4);
        l1.setStrokeWidth(2);
        pyramid.add(l1);
        Line l2 = new Line(x+houseWidth*3/5,y+houseHeight/4,x+houseWidth,y-houseHeight/4);
        l2.setStrokeWidth(2);
        pyramid.add(l2);
        Line l3 = new Line(x+houseWidth,y-houseHeight/4,x+houseWidth*2/5,y-houseHeight*3/4);
        l3.setStrokeWidth(2);
        pyramid.add(l3);
        Line l4 = new Line(x+houseWidth*2/5,y-houseHeight*3/4,x,y);
        l4.setStrokeWidth(2);
        pyramid.add(l4);
        Line l5 = new Line(x+houseWidth*3/5,y+houseHeight/4,x+houseWidth*2/5,y-houseHeight*3/4);
        pyramid.add(l5);
        return pyramid;
    }

    @Override
    public ArrayList<Shape> drawTree(double x, double y) {
        return null;
    }

    @Override
    public ArrayList<Shape> drawWaterBody(double x, double y) {
        return null;
    }

    @Override
    public String GetTerrainColor() {
        return this.TerrainColor;
    }
}
