package project.Utilities.NationItems;

import javafx.scene.paint.Color;
import javafx.scene.shape.Arc;
import javafx.scene.shape.ArcType;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Egyptian_Kings_WaterSource implements IWaterSource{
    private double WaterSourceHeight;
    private double WaterSourceWidth;

    public Egyptian_Kings_WaterSource(){
        this.WaterSourceHeight = 12.0;
        this.WaterSourceWidth = 12.0;
    }
    @Override
    public ArrayList<Shape> drawAsset(double x, double y) {
        ArrayList<Shape> WaterSource = new ArrayList<Shape>();

        Arc arc = new Arc();
        arc.setCenterX(x);
        arc.setCenterY(y);
        arc.setRadiusX(WaterSourceHeight/2.0);
        arc.setRadiusY(WaterSourceWidth/2.0);
        arc.setStartAngle(0.0);
        arc.setLength(100000.0);
        arc.setType(ArcType.OPEN);
        arc.setStroke(Color.BLACK);
        arc.setFill(Color.TRANSPARENT);

        WaterSource.add(arc);
        return WaterSource;
    }
}
