package project.Utilities.NationItems;

import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Arab_Bedouin_House implements IHouse{
    @Override
    public ArrayList<Shape> drawAsset(double x1, double y1) {
        ArrayList<Shape> House = new ArrayList<Shape>();

        //Triangle
        Line line1 = new Line(x1,y1,x1+(HouseWidth-4),y1);
        House.add(line1);
        Line line2 = new Line(x1+(HouseWidth-4),y1,x1+((HouseWidth-4)/2),y1-12);
        line2.setStrokeWidth(2.0);
        House.add(line2);
        Line line3 = new Line(x1+((HouseWidth-4)/2),y1-12,x1,y1);
        House.add(line3);

        //Rectangle
        Line line4 = new Line(x1+(HouseWidth-4),y1,x1+HouseWidth,y1-4);
        House.add(line4);
        Line line5 = new Line(x1+HouseWidth,y1-4,x1+((HouseWidth-4)-2),y1-HouseHeight);
        House.add(line5);
        Line line6 = new Line(x1+((HouseWidth-4)-2),y1-HouseHeight,x1+((HouseWidth-4)/2),y1-12);
        House.add(line6);

        return House;
    }
}
