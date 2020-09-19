package canvas;

import javafx.scene.canvas.Canvas;

public class MyCanvas {
    private static MyCanvas myCanvas = null;
    private Canvas canvas;


    public static MyCanvas getInstance(){
        if(myCanvas==null){
            myCanvas = new MyCanvas();
        }
        return myCanvas;
    }

    private MyCanvas(){
        canvas = new Canvas(525,500);
    }
    public Canvas getCanvas(){
        return canvas;
    }
}
