package house;

import canvas.MyCanvas;
import javafx.event.Event;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;

public class BDHouse implements IHouse {
//    Canvas canvas;

    public BDHouse(){
//        MyCanvas myCanvas = MyCanvas.getInstance();
//        this.canvas = myCanvas.getCanvas();
    }
    @Override
    public void draw(Canvas canvas, String item) {


        GraphicsContext graphicsContext = canvas.getGraphicsContext2D();

        EventHandler handler = new EventHandler<MouseEvent>() {

            @Override
            public void handle(MouseEvent mouseEvent) {
                if(item.equals("house")) {
                    graphicsContext.strokeArc(mouseEvent.getX(), mouseEvent.getY(), 20, 30, 200, 360, ArcType.OPEN);
                    graphicsContext.strokeText("bd house", mouseEvent.getX(), mouseEvent.getY());
                    System.out.println("bd house");
                }
            }
        };

        canvas.addEventHandler(MouseEvent.MOUSE_PRESSED, handler);
        canvas.removeEventHandler(MouseEvent.MOUSE_RELEASED, handler);
    }

}
