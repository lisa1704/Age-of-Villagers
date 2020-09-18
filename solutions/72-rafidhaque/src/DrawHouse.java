import javafx.scene.Group;

public class DrawHouse implements IDrawComponent{
    double x, y;

    public void setX(double x) {
        this.x = x;
    }

    public void setY(double y) {
        this.y = y;
    }

    Group g;
    Rectangle outerArea;
    public DrawHouse(Group g, double currentX, double currentY) {
        this.x = currentX;
        this.y = currentY;
        this.g = g;
    }

    @Override
    public void draw() {

    }

    @Override
    public void drawOuterLayer() {
        outerArea = new Rectangle(g, x, y, x + 16, y + 16);
        outerArea.draw();
    }
}
