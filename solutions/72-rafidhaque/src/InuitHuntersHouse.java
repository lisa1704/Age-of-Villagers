import javafx.scene.Group;
import javafx.scene.paint.Color;
import javafx.scene.shape.Arc;
import javafx.scene.shape.ArcType;

public class InuitHuntersHouse extends DrawHouse {

    public InuitHuntersHouse(Group g) {
        super(g);
    }

    @Override
    public void draw() {
        super.drawOuterLayer();
        Arc outerArc = new Arc(x+8, y+16, 8, 8, 0, 180);
        Arc innerArc = new Arc(x+8, y+16, 2, 2, 0, 180);
        outerArc.setFill(Color.TRANSPARENT);
        outerArc.setStroke(Color.BLACK);
        outerArc.setType(ArcType.ROUND);
        innerArc.setFill(Color.TRANSPARENT);
        innerArc.setStroke(Color.BLACK);
        innerArc.setType(ArcType.ROUND);
        super.g.getChildren().addAll(outerArc, innerArc);
    }
}
