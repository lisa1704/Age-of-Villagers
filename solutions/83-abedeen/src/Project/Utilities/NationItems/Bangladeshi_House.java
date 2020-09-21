package Project.Utilities.NationItems;

import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Bangladeshi_House implements IHouse{
    public Bangladeshi_House(){
        super();
    }
    @Override
    public ArrayList<Shape> drawAsset(double x, double y) {
        ArrayList<Shape> House = new ArrayList<Shape>();
        double halfWidth = houseWidth/2;
        double halfHeight = houseHeight/2;
        Line l1 = new Line(x-halfWidth,y,x+halfWidth,y);
        House.add(l1);
        Line l2 = new Line(x-halfWidth,y+halfHeight,x+halfWidth,y+halfHeight);
        House.add(l2);
        Line l3 = new Line(x-halfWidth,y,x-halfWidth,y+halfHeight);
        House.add(l3);
        Line l4 = new Line(x+halfWidth,y,x+halfWidth,y+halfHeight);
        House.add(l4);
        Line l5 = new Line(x-halfWidth,y,x,y-halfHeight);
        House.add(l5);
        Line l6 = new Line(x+halfWidth,y,x,y-halfHeight);
        House.add(l6);
        return House;
    }
}
