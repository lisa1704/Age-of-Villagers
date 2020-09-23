package house;

import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.RadioButton;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;
import shape.Line;

public class EgyptKingHouse implements IHouse {

    boolean active= true;
    public EgyptKingHouse(){
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


                    new Line(x,y,x+20,y-20).draw(graphicsContext);

                    new Line(x+20,y-20,x+30,y).draw(graphicsContext);

                    new Line(x+30,y,x,y).draw(graphicsContext);



                    new Line(x+30,y,x+40,y-10).draw(graphicsContext);
                    new Line(x+20,y-20,x+40,y-10).draw(graphicsContext);

                    radioButton.setSelected(false);
                    active = false;
                }
            }
        });
    }

}
