import javafx.scene.input.MouseEvent;

public class MouseClickManager {

    public StateOfComponent onMousePressed(MouseEvent mouseEvent, IDrawComponent drawComponent) {
        double x = mouseEvent.getX();
        double y = mouseEvent.getY();

        System.out.println(x+" "+y);
        if (x + 24 <= 600 && y + 24 <= 400) {
            drawComponent.setX(x);
            drawComponent.setY(y);
            drawComponent.drawOuterLayer();
        }

        return new StateOfComponent(x, y, drawComponent);
    }
}
