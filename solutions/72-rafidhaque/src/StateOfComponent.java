public class StateOfComponent {
    double x, y;
    IDrawComponent drawComponent;
    String className;

    public StateOfComponent(double x, double y, IDrawComponent drawComponent) {
        this.x = x;
        this.y = y;
        this.drawComponent = drawComponent;
        this.className = drawComponent.getClass().getSimpleName();
    }

    @Override
    public String toString() {
        return "StateOfComponent{" +
                "x=" + x +
                ", y=" + y +
                ", className=" + className +
                '}';
    }
}
