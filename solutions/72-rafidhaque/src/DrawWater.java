import javafx.scene.Group;

public class DrawWater implements IDrawComponent{
    double x, y;
    Group g;
    Rectangle outerArea;

    @Override
    public void setX(double x) {
        this.x = x;
    }

    @Override
    public void setY(double y) {
        this.y = y;
    }

    public DrawWater(Group g) {
        this.g = g;
    }

    @Override
    public void draw() {
    }

    @Override
    public void drawOuterLayer() {
        outerArea = new Rectangle(g, x, y, x + 24, y + 24);
        outerArea.draw();
    }
}
