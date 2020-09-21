package Project.Utilities.NationItems;

import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Egyptian_Kings_House  implements IHouse{

    public Egyptian_Kings_House(){ super(); }

    @Override
    public ArrayList<Shape> drawAsset(double x, double y) {
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
}
