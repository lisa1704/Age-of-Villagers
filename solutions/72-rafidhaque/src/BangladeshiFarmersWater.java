import javafx.scene.Group;
import javafx.scene.shape.Line;

public class BangladeshiFarmersWater extends DrawWater{
    public BangladeshiFarmersWater(Group g, double width, double height) {
        super(g, width, height);
    }

    public void draw() {
        Line line1 = new Line(x + 1, y + 8, x + 8, y);
        Line line2 = new Line(x + 8, y, x + 15, y + 8);
        Line line3 = new Line(x + 15, y + 8, x + 24, y + 10);
        Line line4 = new Line(x + 24, y + 10, x + 10, y + 16);
        Line line5 = new Line( x + 10, y + 16, x + 1, y + 8);
        g.getChildren().addAll(line1, line2, line3, line4, line5);
        drawOuterLayer();
    }

}
