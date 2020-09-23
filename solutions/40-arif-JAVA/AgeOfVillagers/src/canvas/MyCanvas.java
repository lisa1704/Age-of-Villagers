package canvas;

import javafx.scene.canvas.Canvas;

import java.io.Serializable;

public class MyCanvas implements Serializable {
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
