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

public class WaterBodyTest {
    double x = 10;
    double y = 20;

    @Test
    protected void Bangladeshi_WaterBody_test()
    {
        IWaterBody BDWB = new Bangladeshi_Waterbody();
        double WaterBodyWidth = 24;
        double WaterBodyHeight = 16;

        ArrayList<Shape> pond = new ArrayList<Shape>();
        Line l1 = new Line(x,y,x+(WaterBodyWidth/4),y+(WaterBodyHeight /2));
        pond.add(l1);
        Line l2 = new Line(x+(WaterBodyWidth/4),y+(WaterBodyHeight /2),x+(WaterBodyWidth/2),y);
        pond.add(l2);
        Line l3 = new Line(x+(WaterBodyWidth/2),y,x+(3*WaterBodyWidth/4),y+(WaterBodyHeight /2)-2);
        pond.add(l3);
        Line l4 = new Line(x+(3*WaterBodyWidth/4),y+(WaterBodyHeight /2)-2,x+WaterBodyWidth,y-(WaterBodyHeight /3));
        pond.add(l4);
        Line l5 = new Line(x+WaterBodyWidth,y-(WaterBodyHeight /3),x+(3*WaterBodyWidth/5),y-(WaterBodyHeight /2));
        pond.add(l5);
        Line l6 = new Line(x+(3*WaterBodyWidth/5),y-(WaterBodyHeight /2),x+(WaterBodyWidth/2)-2,y-4);
        pond.add(l6);
        Line l7 = new Line(x+(WaterBodyWidth/2)-2,y-4,x+(WaterBodyWidth/2)-2,y-(WaterBodyHeight /2));
        pond.add(l7);
        Line l8 = new Line(x+(WaterBodyWidth/2)-2,y-(WaterBodyHeight /2),x+(WaterBodyWidth/4),y-(WaterBodyHeight /2));
        pond.add(l8);
        Line l9 = new Line(x+(WaterBodyWidth/4),y-(WaterBodyHeight /2),x,y);
        pond.add(l9);

        Assertions.assertEquals(pond.toString(), BDWB.drawAsset(x,y).toString());
    }

    @Test
    protected void Egyptian_WaterBody_test()
    {
        IWaterBody EKWB = new Egyptian_Kings_Waterbody();
        double WaterBodyWidth = 12;
        double WaterBodyHeight = 12;

        ArrayList<Shape> WaterSource = new ArrayList<Shape>();
        Arc arc = new Arc();
        arc.setCenterX(x);
        arc.setCenterY(y);
        arc.setRadiusX(WaterBodyWidth/2);
        arc.setRadiusY(WaterBodyHeight/2);
        arc.setType(ArcType.OPEN);
        arc.setStroke(Color.BLACK);
        arc.setStrokeWidth(2);
        arc.setFill(Color.TRANSPARENT);
        arc.setStartAngle(0.0);
        arc.setLength(1000.0);
        WaterSource.add(arc);

        Assertions.assertEquals(WaterSource.toString(), EKWB.drawAsset(x,y).toString());
    }
}
