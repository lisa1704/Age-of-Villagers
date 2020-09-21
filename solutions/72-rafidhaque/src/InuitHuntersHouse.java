import javafx.scene.paint.Color;
import javafx.scene.shape.Arc;
import javafx.scene.shape.ArcType;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class InuitHuntersHouse extends DrawHouse {

    @Override
    public ArrayList<Shape> draw() {
        Arc outerArc = new Arc(x+8, y+16, 8, 8, 0, 180);
        Arc innerArc = new Arc(x+8, y+16, 2, 2, 0, 180);
        outerArc.setFill(Color.TRANSPARENT);
        outerArc.setStroke(Color.BLACK);
        outerArc.setType(ArcType.ROUND);
        innerArc.setFill(Color.TRANSPARENT);
        innerArc.setStroke(Color.BLACK);
        innerArc.setType(ArcType.ROUND);

        ArrayList<Shape> arcs = new ArrayList<>();
        arcs.add(outerArc);
        arcs.add(innerArc);

        return arcs;
    }
}
