package shape;

import javafx.scene.canvas.GraphicsContext;
import javafx.scene.shape.ArcType;
import statemanager.State;


public class Circle implements IShape {
    double r, x, y;

    public Circle(double x, double y, double r) {
        this.r = r;
        this.x = x;
        this.y = y;
    }

    @Override
    public void draw(GraphicsContext graphicsContext) {
        graphicsContext.strokeArc(x, y, r, r, 0, 360, ArcType.OPEN);

        Circle circle = new Circle(r, x, y);

        State state = State.getInstance();
        state.addCircle(circle);
    }

    public double getR() {
        return r;
    }

    public void setR(double r) {
        this.r = r;
    }

    public double getX() {
        return x;
    }

    public void setX(double x) {
        this.x = x;
    }

    public double getY() {
        return y;
    }

    public void setY(double y) {
        this.y = y;
    }
}
