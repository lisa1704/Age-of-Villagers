package house;

import canvas.MyCanvas;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.RadioButton;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;

public class ArabBedouinHouse implements IHouse {
    boolean active = false;

    public ArabBedouinHouse() {
    }


    @Override
    public void draw(Canvas canvas, RadioButton radioButton) {
        GraphicsContext graphicsContext = canvas.getGraphicsContext2D();
        canvas.addEventHandler(MouseEvent.MOUSE_PRESSED, new EventHandler<MouseEvent>() {

            @Override
            public void handle(MouseEvent mouseEvent) {
                if (active) {
                    graphicsContext.strokeArc(mouseEvent.getX(), mouseEvent.getY(), 10, 50, 200, 360, ArcType.OPEN);
                    graphicsContext.strokeText("arab        house", mouseEvent.getX(), mouseEvent.getY());
                    active = false;
                    radioButton.setSelected(false);
                }
            }
        });
    }

}
