package statemanager;

public class CircleState {
    double r, x,y;

    public CircleState(double x, double y, double r) {
        this.r = r;
        this.x = x;
        this.y = y;
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
