package Project.Utilities.NationItems;

import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Arab_Bedouin_House implements IHouse{
    public Arab_Bedouin_House(){ super(); }

    @Override
    public ArrayList<Shape> drawHouse(double x, double y) {
        ArrayList<Shape> house = new ArrayList<Shape>();
        //Triangle
        house.add(new Line(x,y,x+(3*houseWidth/4),y));
        Line l1 = new Line(x+(3*houseWidth/4),y,x+(3*houseWidth/4)/2,y-(3*houseHeight/4));
        l1.setStrokeWidth(2);
        house.add(l1);
        house.add(new Line(x+(3*houseWidth/4)/2,y-(3*houseHeight/4),x,y));

        //Rectangle
        house.add(new Line(x+(3*houseWidth/4),y,x+houseWidth,y-(houseHeight/4)));
        house.add(new Line(x+(3*houseWidth/4)/2,y-(3*houseHeight/4),x+((3*houseWidth/4)/2)+(houseWidth/4),y-houseHeight));
        house.add(new Line(x+houseWidth,y-(houseHeight/4),x+((3*houseWidth/4)/2)+(houseWidth/4),y-houseHeight));
        return house;
    }
}
