import javafx.scene.input.MouseEvent;

import java.util.ArrayList;

public class MouseClickManager {
    public void onMousePressed(MouseEvent mouseEvent, IDrawComponent drawComponent, ArrayList<StateOfComponent> allComponents) {
        double x = mouseEvent.getX();
        double y = mouseEvent.getY();
        StateOfComponent stateOfComponent = new StateOfComponent(x, y, drawComponent);
        allComponents.add(stateOfComponent);
        System.out.println(x+" "+y);
        if (x + 24 <= 600 && y + 24 <= 400) {
            drawComponent.setX(x);
            drawComponent.setY(y);
            drawComponent.drawOuterLayer();
        }
    }
}
