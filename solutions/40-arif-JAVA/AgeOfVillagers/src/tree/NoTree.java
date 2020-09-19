package tree;

import canvas.MyCanvas;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.input.MouseEvent;
import javafx.scene.shape.ArcType;

public class NoTree implements ITree{
    public NoTree(){
    }

    @Override
    public void draw() {

        System.out.println("blank tree");
    }
}
