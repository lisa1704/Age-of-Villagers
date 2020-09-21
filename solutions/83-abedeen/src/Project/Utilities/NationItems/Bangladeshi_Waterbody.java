package Project.Utilities.NationItems;

import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Bangladeshi_Waterbody implements IWaterBody{
    private double WaterBodyWidth = 24;
    private double WaterBodyHeight = 16;
    @Override
    public ArrayList<Shape> drawAsset(double x, double y) {
        ArrayList<Shape> pond = new ArrayList<Shape>();
        Line l1 = new Line(x,y,x+(this.WaterBodyWidth/4),y+(this.WaterBodyHeight /2));
        pond.add(l1);
        Line l2 = new Line(x+(this.WaterBodyWidth/4),y+(this.WaterBodyHeight /2),x+(this.WaterBodyWidth/2),y);
        pond.add(l2);
        Line l3 = new Line(x+(this.WaterBodyWidth/2),y,x+(3*this.WaterBodyWidth/4),y+(this.WaterBodyHeight /2)-2);
        pond.add(l3);
        Line l4 = new Line(x+(3*this.WaterBodyWidth/4),y+(this.WaterBodyHeight /2)-2,x+this.WaterBodyWidth,y-(this.WaterBodyHeight /3));
        pond.add(l4);
        Line l5 = new Line(x+this.WaterBodyWidth,y-(this.WaterBodyHeight /3),x+(3*this.WaterBodyWidth/5),y-(this.WaterBodyHeight /2));
        pond.add(l5);
        Line l6 = new Line(x+(3*this.WaterBodyWidth/5),y-(this.WaterBodyHeight /2),x+(this.WaterBodyWidth/2)-2,y-4);
        pond.add(l6);
        Line l7 = new Line(x+(this.WaterBodyWidth/2)-2,y-4,x+(this.WaterBodyWidth/2)-2,y-(this.WaterBodyHeight /2));
        pond.add(l7);
        Line l8 = new Line(x+(this.WaterBodyWidth/2)-2,y-(this.WaterBodyHeight /2),x+(this.WaterBodyWidth/4),y-(this.WaterBodyHeight /2));
        pond.add(l8);
        Line l9 = new Line(x+(this.WaterBodyWidth/4),y-(this.WaterBodyHeight /2),x,y);
        pond.add(l9);
        return pond;
    }
}
