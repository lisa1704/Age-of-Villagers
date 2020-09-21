

public abstract class DrawTree implements IDrawComponent{
    double x, y;

    @Override
    public void setX(double x) {
        this.x = x;
    }

    @Override
    public void setY(double y) {
        this.y = y;
    }

    @Override
    public String toString() {
        return "DrawTree";
    }
}

