package water;

import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.RadioButton;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;
import shape.Line;

public class BDWater implements IWater {
    boolean active = true;
    public BDWater(){
    }

    @Override
    public void draw(Canvas canvas, RadioButton radioButton) {

        GraphicsContext graphicsContext = canvas.getGraphicsContext2D();
        canvas.addEventHandler(MouseEvent.MOUSE_PRESSED, new EventHandler<MouseEvent>() {

            @Override
            public void handle(MouseEvent mouseEvent) {

                if(active){
                    double x= mouseEvent.getX();
                    double y= mouseEvent.getY();


                    new Line(x,y,x+10,y-5).draw(graphicsContext);
                    new Line(x+10,y-5,x+10,y+10).draw(graphicsContext);
                    new Line(x+10,y+10,x+20,y-10).draw(graphicsContext);
                    new Line(x+20,y-10,x+30,y+20).draw(graphicsContext);
                    new Line(x+30,y+20,x+10,y+50).draw(graphicsContext);
                    new Line(x+10,y+50,x+10,y+10).draw(graphicsContext);
                    new Line(x+10,y+10,x,y).draw(graphicsContext);

                    radioButton.setSelected(false);
                    active = false;
                }
            }
        });
    }
}
