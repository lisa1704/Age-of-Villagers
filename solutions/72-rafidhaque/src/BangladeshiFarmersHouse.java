import javafx.scene.Group;
import javafx.scene.shape.Line;

public class BangladeshiFarmersHouse extends DrawHouse{
    public BangladeshiFarmersHouse(Group g) {
        super(g);
    }

    public void draw() {
        super.drawOuterLayer();
        Rectangle rectangle = new Rectangle(super.g, super.x+1, super.y+8, super.x + 15, super.y + 15);
        Line line1 = new Line(super.x + 1, super.y + 8, super.x + 8, super.y);
        Line line2 = new Line(super.x + 15, super.y + 8, super.x + 8, super.y);
        rectangle.draw();
        super.g.getChildren().addAll(line1, line2);
    }


}
