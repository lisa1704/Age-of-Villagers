package tree;

import canvas.MyCanvas;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.RadioButton;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;

public class ArabTree implements ITree {
    boolean active =true;

    public ArabTree(){

    }
    @Override
    public void draw(Canvas canvas, RadioButton radioButton) {

        GraphicsContext graphicsContext = canvas.getGraphicsContext2D();
        canvas.addEventHandler(MouseEvent.MOUSE_PRESSED, new EventHandler<MouseEvent>() {

            @Override
            public void handle(MouseEvent mouseEvent) {
                if(active) {
                    graphicsContext.strokeArc(mouseEvent.getX(), mouseEvent.getY(), 100, 50, 200, 360, ArcType.OPEN);
                    graphicsContext.strokeText("Arab tree", mouseEvent.getX(), mouseEvent.getY());
                    radioButton.setSelected(false);
                    active= false;
                }

            }
        });

    }
}
