package tree;

import canvas.CanvasSingleton;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.input.MouseEvent;
import shape.Circle;
import shape.Point;
import shape.Rectangle;
import state.CurrentState;

public class BangladeshiFarmersTree implements ITree {
    private Canvas canvas;

    private Point topLeft;
    private Point bottomRight;
    private Point center;

    private GraphicsContext graphicsContext;
    private CanvasSingleton canvasSingleton;

    private boolean shouldBeDrawn = true;

    private CurrentState currentState;

    public BangladeshiFarmersTree() {
        canvasSingleton = CanvasSingleton.getInstance();
        this.canvas = canvasSingleton.getCanvas();
        currentState = CurrentState.getInstance();
    }

    private void calculateCornerPoints(Point selectedPoint) {
        center = new Point(selectedPoint.x - 8, selectedPoint.y - 12);

        topLeft = new Point(selectedPoint.x + 2, selectedPoint.y - 4);
        bottomRight = new Point(selectedPoint.x - 2, selectedPoint.y + 12);
    }

    @Override
    public void draw(Point point) {
        System.out.println(point.x);
        calculateCornerPoints(point);
        new Rectangle(topLeft, bottomRight, graphicsContext).draw();
        new Circle(center, 16, graphicsContext).draw();
    }

    @Override
    public void canvasController() {
        graphicsContext = canvas.getGraphicsContext2D();

        canvas.addEventHandler(MouseEvent.MOUSE_PRESSED,
                new EventHandler<MouseEvent>() {

                    @Override
                    public void handle(MouseEvent event) {
                        if (shouldBeDrawn) {
                            Point selectedPoint = new Point((int) event.getX(), (int) event.getY());
                            draw(selectedPoint);
                            currentState.addTree(selectedPoint);
                        }
                    }
                });
    }

    @Override
    public void releaseCanvas() {
        shouldBeDrawn = false;
    }

    @Override
    public void getCanvas() {
        shouldBeDrawn = true;
    }
}
