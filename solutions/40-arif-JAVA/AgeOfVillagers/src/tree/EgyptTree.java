package tree;

import canvas.MyCanvas;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.RadioButton;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;
import shape.Line;
import shape.Rectangle;

public class EgyptTree implements ITree {
    boolean active= true;

    public EgyptTree(){
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

                    new Line(x,y,x-20,y-10).draw(graphicsContext);
                    new Line(x,y,x-10,y-20).draw(graphicsContext);
                    new Line(x,y,x,y-30).draw(graphicsContext);
                    new Line(x,y,x+10,y-20).draw(graphicsContext);
                    new Line(x,y,x+20,y-10).draw(graphicsContext);


                    new Line(x,y,x+20,y+50).draw(graphicsContext);


                    new Line(x+30,y,x+20,y+50).draw(graphicsContext);



                    new Line(x+30,y,x-20+30,y-10).draw(graphicsContext);
                    new Line(x+30,y,x-10+30,y-20).draw(graphicsContext);
                    new Line(x+30,y,x+30,y-30).draw(graphicsContext);
                    new Line(x+30,y,x+10+30,y-20).draw(graphicsContext);
                    new Line(x+30,y,x+20+30,y-10).draw(graphicsContext);




                    radioButton.setSelected(false);
                    active = false;
                }
            }
        });

    }
}
