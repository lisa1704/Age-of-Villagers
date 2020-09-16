package house;

import canvas.MyCanvas;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;

public class BDHouse implements IHouse {
    Canvas canvas;
    @Override
    public void draw() {

        MyCanvas myCanvas = MyCanvas.getInstance();
        this.canvas = myCanvas.getCanvas();

        GraphicsContext graphicsContext = canvas.getGraphicsContext2D();
        canvas.addEventHandler(MouseEvent.MOUSE_PRESSED, new EventHandler<MouseEvent>() {

            @Override
            public void handle(MouseEvent mouseEvent) {
                graphicsContext.strokeArc(mouseEvent.getX(), mouseEvent.getY(),50,50,200,360, ArcType.OPEN);
            }
        });
    }
}
