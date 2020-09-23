package house;

import canvas.MyCanvas;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.RadioButton;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;
import shape.Circle;
import shape.Line;

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


                    double x= mouseEvent.getX();
                    double y= mouseEvent.getY();

                    new Line(x-20,y,x+20,y).draw(graphicsContext);
                    new Circle(x-20,y-20,40).draw(graphicsContext);
                    new Circle(x-20,y-20,10).draw(graphicsContext);


                    radioButton.setSelected(false);
                    active = false;
                }
            }
        });

    }


}
