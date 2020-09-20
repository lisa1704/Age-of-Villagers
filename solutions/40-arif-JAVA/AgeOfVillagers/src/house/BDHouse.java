package house;

import canvas.MyCanvas;
import javafx.event.Event;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.RadioButton;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;

public class BDHouse implements IHouse {

    boolean active = true;
    public BDHouse(){
    }
    @Override
    public void draw(Canvas canvas, RadioButton radioButton) {

        GraphicsContext graphicsContext = canvas.getGraphicsContext2D();
        EventHandler handler = new EventHandler<MouseEvent>() {
            @Override
            public void handle(MouseEvent mouseEvent) {
                if(active) {
                    graphicsContext.strokeArc(mouseEvent.getX(), mouseEvent.getY(), 20, 30, 200, 360, ArcType.OPEN);
                    graphicsContext.strokeText("bd house", mouseEvent.getX(), mouseEvent.getY());
                    radioButton.setSelected(false);
                    active= false;
                }
            }
        };

        canvas.addEventHandler(MouseEvent.MOUSE_PRESSED, handler);
        canvas.removeEventHandler(MouseEvent.MOUSE_CLICKED, handler);
    }


}
