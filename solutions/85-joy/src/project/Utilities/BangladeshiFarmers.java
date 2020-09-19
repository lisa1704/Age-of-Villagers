package project.Utilities;

import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class BangladeshiFarmers implements INation{

    public BangladeshiFarmers(){
        super();
    }
    @Override
    public ArrayList<Shape> DrawHouse(double x1, double y1) {
        ArrayList<Shape> House = new ArrayList<Shape>();
        //Upper Triangle..
        Line line1 = new Line(x1,y1,x1+HouseWidth,y1);
        House.add(line1);
        Line line2 = new Line(x1,y1,x1+(HouseWidth/2.0),y1-(HouseHeight/2.0));
        House.add(line2);
        Line line3 = new Line(x1+HouseWidth,y1,x1+(HouseHeight/2.0),y1-(HouseHeight/2.0));
        House.add(line3);
        //Lower Rectangle
        Line line4 = new Line(x1,y1,x1,y1+HouseHeight);
        House.add(line4);
        Line line5 = new Line(x1,y1+HouseHeight,x1+HouseWidth,y1+HouseHeight);
        House.add(line5);
        Line line6 = new Line(x1+HouseWidth,y1+HouseHeight,x1+HouseWidth,y1);
        House.add(line6);

        return House;
    }

    @Override
    public void DrawTree() {

    }

    @Override
    public void DrawWaterSource() {

    }
}
