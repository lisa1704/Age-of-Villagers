package water;

import canvas.MyCanvas;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;

public class ArabWater implements IWater {
//    Canvas canvas;

    public ArabWater(){
//        MyCanvas myCanvas = MyCanvas.getInstance();
//        this.canvas = myCanvas.getCanvas();
    }
    @Override
    public void draw(Canvas canvas, String item) {


        GraphicsContext graphicsContext = canvas.getGraphicsContext2D();
        canvas.addEventHandler(MouseEvent.MOUSE_PRESSED, new EventHandler<MouseEvent>() {

            @Override
            public void handle(MouseEvent mouseEvent) {
                if(item.equals("water")) {
                    double x = mouseEvent.getX();
                    double y = mouseEvent.getY();

                    graphicsContext.lineTo(x, y);
                    graphicsContext.lineTo(x + 10, y + 20);
                    graphicsContext.strokeText("arab water", mouseEvent.getX(), mouseEvent.getY());
//
//                canvas.removeEventHandler(MouseEvent.MOUSE_RELEASED,this);
                    System.out.println("oknsdndkd");
                }

            }
        });
    }
}
