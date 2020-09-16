package canvas;

import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.input.MouseEvent;

public class CanvasHelper {

    private Canvas canvas;

    public CanvasHelper(javafx.scene.canvas.Canvas canvas) {
        this.canvas = canvas;
    }
    public void execute(){
        final GraphicsContext graphicsContext = canvas.getGraphicsContext2D();

        canvas.addEventHandler(MouseEvent.MOUSE_PRESSED,
                new EventHandler<MouseEvent>(){

                    @Override
                    public void handle(MouseEvent event) {
                        graphicsContext.strokeLine(event.getX(), event.getY(), 10, 10);

                        String x = String.valueOf(event.getX());
                        String y = String.valueOf(event.getY());
                        System.out.println(x+", "+y);
                    }
                });

    }
}
