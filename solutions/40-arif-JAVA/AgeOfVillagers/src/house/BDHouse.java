package house;

import canvas.MyCanvas;
import javafx.event.Event;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.RadioButton;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;
import shape.IShape;
import shape.Rectangle;
import shape.Triangle;

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
                    new Triangle(graphicsContext, mouseEvent.getX(), mouseEvent.getY()).draw();
                    new Rectangle(graphicsContext, mouseEvent.getX()-5, mouseEvent.getY()+10, 10,10).draw();
                    radioButton.setSelected(false);
                    active= false;
                }
            }
        };

        canvas.addEventHandler(MouseEvent.MOUSE_PRESSED, handler);
        canvas.removeEventHandler(MouseEvent.MOUSE_CLICKED, handler);
    }


}
