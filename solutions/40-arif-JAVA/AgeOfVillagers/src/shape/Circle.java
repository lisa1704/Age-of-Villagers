package shape;

import javafx.scene.canvas.GraphicsContext;
import javafx.scene.shape.ArcType;
import statemanager.CircleState;
import statemanager.LineState;
import statemanager.State;

public class Circle implements IShape {
    double r, x,y;
    GraphicsContext graphicsContext;

    public Circle( GraphicsContext graphicsContext, double x, double y, double r) {
        this.r = r;
        this.x = x;
        this.y = y;
        this.graphicsContext = graphicsContext;
    }

    @Override
    public void draw() {
        graphicsContext.strokeArc(x,y,r,r,0,360, ArcType.OPEN);


        CircleState circle = new CircleState(r,x,y);

        State state = State.getInstance();
        state.addCircle(circle);
    }
}
