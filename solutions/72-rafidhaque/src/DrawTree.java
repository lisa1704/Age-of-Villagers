import javafx.scene.Group;

public class DrawTree implements IDrawComponent{
    double x, y;
    Group g;

    @Override
    public void setX(double x) {
        this.x = x;
    }

    @Override
    public void setY(double y) {
        this.y = y;
    }

    Rectangle outerArea;
    public DrawTree(Group g) {
        this.g = g;
    }

    @Override
    public void draw() {
    }

    @Override
    public void drawOuterLayer() {
        outerArea = new Rectangle(g, x, y, x + 16, y + 24);
        outerArea.draw();
    }

    @Override
    public String toString() {
        return "DrawTree";
    }
}

