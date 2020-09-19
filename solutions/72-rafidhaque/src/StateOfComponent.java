public class StateOfComponent {
    double x, y;
    IDrawComponent drawComponent;

    public StateOfComponent(double x, double y, IDrawComponent drawComponent) {
        this.x = x;
        this.y = y;
        this.drawComponent = drawComponent;
    }

    @Override
    public String toString() {
        return "StateOfComponent{" +
                "x=" + x +
                ", y=" + y +
                ", drawComponent=" + drawComponent.toString() +
                '}';
    }
}
