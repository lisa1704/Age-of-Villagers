package tree;

import canvas.MyCanvas;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.RadioButton;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;
import shape.Circle;
import shape.Rectangle;

public class BDTree implements ITree {

    boolean active = true;

    public BDTree(){
    }

    @Override
    public void draw(Canvas canvas, RadioButton radioButton) {

        GraphicsContext graphicsContext = canvas.getGraphicsContext2D();
        canvas.addEventHandler(MouseEvent.MOUSE_PRESSED, new EventHandler<MouseEvent>() {

            @Override
            public void handle(MouseEvent mouseEvent) {
                if(active) {
                    double x = mouseEvent.getX();
                    double y = mouseEvent.getY();

                    new Circle(graphicsContext,x,y,20).draw();
                    new Rectangle(graphicsContext,x+5, y+10,15, 4).draw();

                    radioButton.setSelected(false);
                    active = false;
                }
            }
        });
    }
}
