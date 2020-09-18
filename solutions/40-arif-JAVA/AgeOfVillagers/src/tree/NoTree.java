package tree;

import canvas.MyCanvas;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;

public class NoTree implements ITree{
    Canvas canvas;

    public NoTree(){
        MyCanvas myCanvas = MyCanvas.getInstance();
        this.canvas = myCanvas.getCanvas();
    }

    @Override
    public void draw() {

        System.out.println("blank tree");
    }
}
