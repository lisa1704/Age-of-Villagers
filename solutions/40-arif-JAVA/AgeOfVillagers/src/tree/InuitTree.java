package tree;

import canvas.MyCanvas;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.RadioButton;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;

public class InuitTree implements ITree {
    Canvas canvas;

    public InuitTree(){
        MyCanvas myCanvas = MyCanvas.getInstance();
        this.canvas = myCanvas.getCanvas();
    }
    @Override
    public void draw(Canvas canvas, RadioButton radioButton) {

        GraphicsContext graphicsContext = canvas.getGraphicsContext2D();
        canvas.addEventHandler(MouseEvent.MOUSE_PRESSED, new EventHandler<MouseEvent>() {

            @Override
            public void handle(MouseEvent mouseEvent) {
                graphicsContext.strokeArc(mouseEvent.getX(), mouseEvent.getY(),50,50,200,360, ArcType.OPEN);
                graphicsContext.strokeText("inuit tree", mouseEvent.getX(),mouseEvent.getY());
            }
        });
    }
}
