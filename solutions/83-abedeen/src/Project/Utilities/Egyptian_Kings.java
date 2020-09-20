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
        double half_width = TreeWidth/2;
        ArrayList<Shape> tree = new ArrayList<>();
        tree.add(new Line(x,y,x-half_width+2,y-TreeHeight));
        tree.add(new Line(x,y,x+half_width-2,y-TreeHeight));
        tree.add(new Line(x-half_width/2,y-TreeHeight/2,x-2,y-TreeHeight));
        tree.add(new Line(x-half_width/2,y-TreeHeight/2,x-half_width,y-TreeHeight*2/3));
        tree.add(new Line(x+half_width/3,y-TreeHeight/3,x+2,y-TreeHeight));
        tree.add(new Line(x+half_width/3,y-TreeHeight/3,x+half_width,y-TreeHeight*2/3));
        return tree;
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
