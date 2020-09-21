package Project.Utilities.NationItems;

import javafx.scene.paint.Color;
import javafx.scene.shape.Arc;
import javafx.scene.shape.ArcType;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Inuit_Hunters_House implements IHouse{
    public Inuit_Hunters_House(){ super(); }
    @Override
    public ArrayList<Shape> drawAsset(double x, double y) {
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
        return igloo;
    }
}
