public class StateOfComponent implements java.io.Serializable {
    double x, y;
    IDrawComponent drawComponent;
    String className;

    public void setX(double x) {
        this.x = x;
    }

    public void setY(double y) {
        this.y = y;
    }

    public StateOfComponent(double x, double y, IDrawComponent drawComponent) {
        this.x = x;
        this.y = y;
        this.drawComponent = drawComponent;
        this.className = drawComponent.getClass().getSimpleName();
    }

    public double getX() {
        return x;
    }

    public double getY() {
        return y;
    }

    @Override
    public String toString() {
        return "StateOfComponent{" +
                "x=" + x +
                ", y=" + y +
                ", drawComponent=" + drawComponent +
                ", className='" + className + '\'' +
                '}';
    }
}
