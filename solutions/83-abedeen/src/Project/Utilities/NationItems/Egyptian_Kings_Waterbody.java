package Project.Utilities.NationItems;

import javafx.scene.paint.Color;
import javafx.scene.shape.Arc;
import javafx.scene.shape.ArcType;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Egyptian_Kings_Waterbody implements IWaterBody{
    private double WaterBodyWidth = 12;
    private double WaterBodyHeight = 12;

    @Override
    public ArrayList<Shape> drawWaterBody(double x, double y) {
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
        return WaterSource;
    }
}
