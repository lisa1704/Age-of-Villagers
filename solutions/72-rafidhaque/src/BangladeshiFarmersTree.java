import javafx.scene.Group;

public class BangladeshiFarmersTree extends DrawTree{

    public BangladeshiFarmersTree(Group g) {
        super(g);
    }

    public void draw() {
        drawOuterLayer();
        Circle circle = new Circle(g, x + 8, y + 8, 7);
        Rectangle rectangle = new Rectangle(g, x + 8, y + 8, x + 10, y + 24);
        circle.draw();
        rectangle.draw();
    }
}
