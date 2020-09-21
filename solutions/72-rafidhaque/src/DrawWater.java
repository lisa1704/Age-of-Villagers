

public abstract class DrawWater implements IDrawComponent{
    double x, y, width, height;

    @Override
    public void setX(double x) {
        this.x = x;
    }

    @Override
    public void setY(double y) {
        this.y = y;
    }

    public DrawWater(double width, double height) {
        this.width = width;
        this.height = height;
    }

    @Override
    public String toString() {
        return "DrawWater";
    }
}
