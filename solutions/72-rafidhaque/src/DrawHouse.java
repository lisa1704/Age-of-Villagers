

public abstract class DrawHouse implements IDrawComponent{
    double x, y;

    public void setX(double x) {
        this.x = x;
    }

    public void setY(double y) {
        this.y = y;
    }

    @Override
    public String toString() {
        return "DrawHouse";
    }
}
