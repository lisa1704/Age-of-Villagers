package Project.Utilities.NationItems;

import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Arab_Bedouin_Tree implements ITree{
    public Arab_Bedouin_Tree(){ super(); }

    @Override
    public ArrayList<Shape> drawTree(double x, double y) {
        ArrayList<Shape> tree = new ArrayList<Shape>();
        double trunk_height = TreeHeight - (TreeWidth/2);
        double half_width = TreeWidth/2;
        //Rectangle
        tree.add(new Line(x-1,y,x+1,y));
        tree.add(new Line(x-1,y+trunk_height,x+1,y+trunk_height));
        tree.add(new Line(x-1,y,x-1,y+trunk_height));
        tree.add(new Line(x+1,y,x+1,y+trunk_height));

        //Lines
        Line l1 = new Line(x,y,x+(half_width),y-half_width/3); tree.add(l1);
        Line l2 = new Line(x,y,x-(half_width),y-half_width/3); tree.add(l2);
        Line l3 = new Line(x,y,x+(3*half_width/4),y-(2*half_width/3)); tree.add(l3);
        Line l4 = new Line(x,y,x-(3*half_width/4),y-(2*half_width/3)); tree.add(l4);
        Line l5 = new Line(x,y,x,y-half_width); tree.add(l5);

        return tree;
    }
}
