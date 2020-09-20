package house;

import canvas.MyCanvas;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.RadioButton;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;

public class InuitHunterHouse implements IHouse {

    boolean active = true;
    public InuitHunterHouse(){
    }
    @Override
    public void draw(Canvas canvas, RadioButton radioButton) {

        GraphicsContext graphicsContext = canvas.getGraphicsContext2D();
        canvas.addEventHandler(MouseEvent.MOUSE_PRESSED, new EventHandler<MouseEvent>() {

            @Override
            public void handle(MouseEvent mouseEvent) {
                if(active) {
                    graphicsContext.strokeArc(mouseEvent.getX(), mouseEvent.getY(), 50, 10, 200, 360, ArcType.OPEN);
                    graphicsContext.strokeText("Inuit house", mouseEvent.getX(), mouseEvent.getY());
                    radioButton.setSelected(false);
                    active = false;
                }
            }
        });

    }


}
