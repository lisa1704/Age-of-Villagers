package shape;

import javafx.scene.canvas.GraphicsContext;
import statemanager.State;

public class Line implements IShape {
    double x1,x2, y1,y2;

    public Line(double x1, double y1, double x2, double y2) {
        this.x1 =x1;
        this.x2 = x2;
        this.y1 = y1;
        this.y2 = y2;
    }

    @Override
    public void draw(GraphicsContext graphicsContext) {
        graphicsContext.strokeLine(x1,y1, x2,y2);

        Line lineState = new Line(x1,y1,x2,y2);

        State state = State.getInstance();
        state.addLine(lineState);
    }

    public double getX1() {
        return x1;
    }

    public void setX1(double x1) {
        this.x1 = x1;
    }

    public double getX2() {
        return x2;
    }

    public void setX2(double x2) {
        this.x2 = x2;
    }

    public double getY1() {
        return y1;
    }

    public void setY1(double y1) {
        this.y1 = y1;
    }

    public double getY2() {
        return y2;
    }

    public void setY2(double y2) {
        this.y2 = y2;
    }
}
