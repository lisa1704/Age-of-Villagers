package tree;

import canvas.MyCanvas;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;

public class BDTree implements ITree {
    Canvas canvas;

    public BDTree(){
        MyCanvas myCanvas = MyCanvas.getInstance();
        this.canvas = myCanvas.getCanvas();
    }

    @Override
    public void draw() {

        MyCanvas myCanvas = MyCanvas.getInstance();
        this.canvas = myCanvas.getCanvas();

        GraphicsContext graphicsContext = canvas.getGraphicsContext2D();
        canvas.addEventHandler(MouseEvent.MOUSE_PRESSED, new EventHandler<MouseEvent>() {

            @Override
            public void handle(MouseEvent mouseEvent) {
                double x= mouseEvent.getX();
                double y= mouseEvent.getY();

                graphicsContext.strokeArc(x, y,50,50,200,360, ArcType.OPEN);
                graphicsContext.lineTo(x,y);
                graphicsContext.lineTo(x+10,y+20);
                graphicsContext.strokeText("bd tree", mouseEvent.getX(),mouseEvent.getY());
            }
        });
    }
}
