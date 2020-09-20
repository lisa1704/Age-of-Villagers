package water;

import canvas.MyCanvas;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.RadioButton;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;

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
                    graphicsContext.strokeArc(x, y,40,50,200,360, ArcType.OPEN);
                    graphicsContext.lineTo(x,y);
                    graphicsContext.lineTo(x+10,y+20);
                    graphicsContext.strokeText("bd water", mouseEvent.getX(),mouseEvent.getY());
                    radioButton.setSelected(false);
                    active = false;
                }
            }
        });
    }
}
