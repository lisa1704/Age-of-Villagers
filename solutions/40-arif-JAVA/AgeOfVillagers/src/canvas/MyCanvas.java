package canvas;

import javafx.scene.canvas.Canvas;

public class MyCanvas {
    private static MyCanvas myCanvas = null;
    private Canvas canvas;

    private MyCanvas(){
        canvas = new Canvas(500,500);
    }

    public static MyCanvas getInstance(){
        if(myCanvas==null){
            myCanvas = new MyCanvas();
        }
        return myCanvas;
    }
    public Canvas getCanvas(){
        return canvas;
    }
}
