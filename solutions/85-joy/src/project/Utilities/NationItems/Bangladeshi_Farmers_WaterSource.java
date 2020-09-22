package project.Utilities.NationItems;

import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Bangladeshi_Farmers_WaterSource implements IWaterSource{
    private double WaterSourceHeight;
    private double WaterSourceWidth;
    public Bangladeshi_Farmers_WaterSource(){
        super();
        this.WaterSourceHeight = 16.0;
        this.WaterSourceWidth = 24.0;
    }

    @Override
    public ArrayList<Shape> drawAsset(double x, double y) {
        ArrayList<Shape> WaterSource = new ArrayList<Shape>();

        Line line1 = new Line(x,y,x+4,y+WaterSourceHeight/2);
        WaterSource.add(line1);
        Line line2 = new Line(x+4,y+WaterSourceHeight/2,x+11,y+3);
        WaterSource.add(line2);
        Line line3 = new Line(x+11,y+3,x+18,y+6);
        WaterSource.add(line3);
        Line line4 = new Line(x+18,y+6,x+WaterSourceWidth,y-3);
        WaterSource.add(line4);

        Line line5 = new Line(x+WaterSourceWidth,y-3,x+15,y-WaterSourceHeight/2);
        WaterSource.add(line5);
        Line line6 = new Line(x+15,y-WaterSourceHeight/2,x+9,y-3);
        WaterSource.add(line6);
        Line line7 = new Line(x+9,y-3,x+7,y-6);
        WaterSource.add(line7);
        Line line8 = new Line(x+7,y-6,x+5,y-4);
        WaterSource.add(line8);
        Line line9 = new Line(x+5,y-4,x,y);
        WaterSource.add(line9);

        return  WaterSource;
    }
}
