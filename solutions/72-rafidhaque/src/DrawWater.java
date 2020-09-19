import javafx.scene.Group;

public abstract class DrawWater implements IDrawComponent{
    double x, y, width, height;
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

    public DrawWater(Group g, double width, double height) {
        this.g = g;
        this.width = width;
        this.height = height;
    }

    @Override
    public void drawOuterLayer() {
        outerArea = new Rectangle(g, x, y, x + width, y + height);
        outerArea.draw();
    }

    @Override
    public String toString() {
        return "DrawWater";
    }
}
