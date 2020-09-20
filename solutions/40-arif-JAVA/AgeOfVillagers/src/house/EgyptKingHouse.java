package house;

import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;

public class EgyptKingHouse implements IHouse {

    boolean active= false;
//    Canvas canvas;
    public EgyptKingHouse(){
//        MyCanvas myCanvas = MyCanvas.getInstance();
//        this.canvas = myCanvas.getCanvas();
    }

    @Override
    public void draw(Canvas canvas, String item) {

        GraphicsContext graphicsContext = canvas.getGraphicsContext2D();
        canvas.addEventHandler(MouseEvent.MOUSE_PRESSED, new EventHandler<MouseEvent>() {

            @Override
            public void handle(MouseEvent mouseEvent) {
                if(item.equals("house")) {
                    graphicsContext.strokeArc(mouseEvent.getX(), mouseEvent.getY(), 20, 30, 200, 360, ArcType.OPEN);
                    graphicsContext.strokeText("     Egypt house", mouseEvent.getX(), mouseEvent.getY());
                }
            }
        });
    }

    @Override
    public void releaseCanvas() {
active = false;
    }

    @Override
    public void getCanvas() {
active= true;
    }

}
