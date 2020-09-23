package Tests;
import Project.Utilities.NationItems.*;
import javafx.scene.paint.Color;
import javafx.scene.shape.Arc;
import javafx.scene.shape.ArcType;
import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;
import java.util.ArrayList;

public class HouseTest {
    double houseWidth = 16;
    double houseHeight = 16;
    double x = 10;
    double y = 20;

    @Test
    protected void Bangladeshi_house_test()
    {
        IHouse BDH = new Bangladeshi_House();
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

        Assertions.assertEquals(House.toString(), BDH.drawAsset(x,y).toString());
    }

    @Test
    protected void Arabian_house_test()
    {
        IHouse ABH = new Arab_Bedouin_House();

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

        Assertions.assertEquals(house.toString(), ABH.drawAsset(x,y).toString());
    }

    @Test
    protected void Egyptian_house_test()
    {
        IHouse EKH = new Egyptian_Kings_House();

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

        Assertions.assertEquals(pyramid.toString(), EKH.drawAsset(x,y).toString());
    }

    @Test
    protected void Inuit_house_test()
    {
        IHouse IHH = new Inuit_Hunters_House();

        ArrayList<Shape> igloo = new ArrayList<>();
        Arc Dome = new Arc();
        Dome.setCenterX(x);
        Dome.setCenterY(y);
        Dome.setRadiusX(houseWidth/2);
        Dome.setRadiusY(houseHeight/2);
        Dome.setType(ArcType.ROUND);
        Dome.setStroke(Color.BLACK);
        Dome.setStrokeWidth(1);
        Dome.setFill(Color.TRANSPARENT);
        Dome.setStartAngle(0.0);
        Dome.setLength(180.0);
        igloo.add(Dome);

        double inner_radius = houseWidth/6;
        Arc Entry = new Arc();
        Entry.setCenterX(x);
        Entry.setCenterY(y);
        Entry.setRadiusX(inner_radius);
        Entry.setRadiusY(inner_radius);
        Entry.setType(ArcType.OPEN);
        Entry.setStroke(Color.BLACK);
        Entry.setStrokeWidth(1);
        Entry.setFill(Color.TRANSPARENT);
        Entry.setStartAngle(0.0);
        Entry.setLength(180.0);
        igloo.add(Entry);

        Assertions.assertEquals(igloo.toString(), IHH.drawAsset(x,y).toString());
    }

}
