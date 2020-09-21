package sample;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.input.MouseEvent;


public class ArabBedouinHouse implements IHouse {
    private Canvas can;
    private GraphicsContext graphicsContext;
    private CurrentState currentState;
    private boolean Draw = true;

    private Point x;
    private Point y;
    private Point z;
    private Point w;
    private Point u;


    public ArabBedouinHouse() {
        CanvasSingleton canvasSingleton = CanvasSingleton.getInstance();
        this.can = canvasSingleton.getCanvas();
        currentState = CurrentState.getInstance();
    }

    private void calculateCornerPoints(Point selectedPoint) {
        x = new Point(selectedPoint.x-12, selectedPoint.y + 8);
        y = new Point(selectedPoint.x , selectedPoint.y +8);
        z = new Point(selectedPoint.x + 12, selectedPoint.y + 8);
        w = new Point(selectedPoint.x + 6, selectedPoint.y - 8);
        u = new Point(selectedPoint.x - 6, selectedPoint.y - 8);
    }

    @Override
    public void draw(Point point) {
        calculateCornerPoints(point);
        new Line(x, y).draw();
        new Line(y, z).draw();
        new Line(z, w).draw();
        new Line(w, u).draw();
        new Line(u, x).draw();
        new Line(u, y).draw();
    }

    @Override
    public void canvasController() {
        graphicsContext = can.getGraphicsContext2D();

        can.addEventHandler(MouseEvent.MOUSE_PRESSED,
                new EventHandler<MouseEvent>() {

                    @Override
                    public void handle(MouseEvent event) {
                        if (Draw) {
                            Point selectedPoint = new Point((int) event.getX(), (int) event.getY());
                            draw(selectedPoint);
                            currentState.addHouse(selectedPoint);
                        }
                    }
                });
    }


    @Override
    public void releaseCanvas() {
        Draw = false;
    }

    @Override
    public void getCanvas() {
        Draw = true;
    }
}