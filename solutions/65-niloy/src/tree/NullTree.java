package tree;

import shape.Point;

public class NullTree implements ITree {
    @Override
    public void draw(Point point) {
        System.out.println("No tree exists!");
    }

    @Override
    public void canvasController() {

    }

    @Override
    public void releaseCanvas() {

    }

    @Override
    public void getCanvas() {

    }
}
