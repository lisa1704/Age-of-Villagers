package Project.Utilities.NationItems;

import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Egyptian_Kings_Tree implements ITree{
    @Override
    public ArrayList<Shape> drawAsset(double x, double y) {
        double half_width = TreeWidth/2;
        ArrayList<Shape> tree = new ArrayList<>();
        tree.add(new Line(x,y,x-half_width+2,y-TreeHeight));
        tree.add(new Line(x,y,x+half_width-2,y-TreeHeight));
        tree.add(new Line(x-half_width/2,y-TreeHeight/2,x-2,y-TreeHeight));
        tree.add(new Line(x-half_width/2,y-TreeHeight/2,x-half_width,y-TreeHeight*2/3));
        tree.add(new Line(x+half_width/3,y-TreeHeight/3,x+2,y-TreeHeight));
        tree.add(new Line(x+half_width/3,y-TreeHeight/3,x+half_width,y-TreeHeight*2/3));
        return tree;
    }
}
