import javafx.scene.input.MouseEvent;

public class MouseClickManager {

    StateOfComponent stateOfComponent = null;

    public StateOfComponent getStateOfComponent() {
        return stateOfComponent;
    }

    public void onMousePressed(MouseEvent mouseEvent, IDrawComponent drawComponent) {
        double x = mouseEvent.getX();
        double y = mouseEvent.getY();
        stateOfComponent = new StateOfComponent(x, y, drawComponent);

        System.out.println(x+" "+y);
        if (x + 24 <= 600 && y + 24 <= 400) {
            drawComponent.setX(x);
            drawComponent.setY(y);
            drawComponent.drawOuterLayer();
        }
    }
}
