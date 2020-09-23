package Tests;

import Project.Utilities.NationItems.*;
import javafx.scene.paint.Color;
import javafx.scene.shape.Arc;
import javafx.scene.shape.ArcType;
import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

import java.util.ArrayList;

public class TreeTest {
    double TreeWidth = 16;
    double TreeHeight = 24;
    double x = 10;
    double y = 20;

    @Test
    protected void Bangladeshi_Tree_test()
    {
        ITree BDT = new Bangladeshi_Tree();

        ArrayList<Shape> tree = new ArrayList<Shape>();
        Arc arc = new Arc();
        arc.setCenterX(x);
        arc.setCenterY(y);
        arc.setRadiusX(TreeWidth/2);
        arc.setRadiusY((TreeWidth/2)+2);
        arc.setType(ArcType.OPEN);
        arc.setStroke(Color.BLACK);
        arc.setStrokeWidth(1);
        arc.setFill(Color.TRANSPARENT);
        arc.setStartAngle(0.0);
        arc.setLength(360.0);

        tree.add(arc);

        Line l1 = new Line(x-1,y,x+1,y);
        tree.add(l1);
        Line l2 = new Line(x-1,y+15,x+1,y+15);
        tree.add(l2);
        Line l3 = new Line(x-1,y,x-1,y+15);
        tree.add(l3);
        Line l4 = new Line(x+1,y,x+1,y+15);
        tree.add(l4);

        Assertions.assertEquals(tree.toString(), BDT.drawAsset(x,y).toString());
    }

    @Test
    protected void Arabian_tree_test()
    {
        ITree ABT = new Arab_Bedouin_Tree();

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

        Assertions.assertEquals(tree.toString(), ABT.drawAsset(x,y).toString());
    }

    @Test
    protected void Egyptian_house_test()
    {
        ITree EKT = new Egyptian_Kings_Tree();

        double half_width = TreeWidth/2;
        ArrayList<Shape> tree = new ArrayList<>();
        tree.add(new Line(x,y,x-half_width+2,y-TreeHeight));
        tree.add(new Line(x,y,x+half_width-2,y-TreeHeight));
        tree.add(new Line(x-half_width/2,y-TreeHeight/2,x-2,y-TreeHeight));
        tree.add(new Line(x-half_width/2,y-TreeHeight/2,x-half_width,y-TreeHeight*2/3));
        tree.add(new Line(x+half_width/3,y-TreeHeight/3,x+2,y-TreeHeight));
        tree.add(new Line(x+half_width/3,y-TreeHeight/3,x+half_width,y-TreeHeight*2/3));

        Assertions.assertEquals(tree.toString(), EKT.drawAsset(x,y).toString());
    }
}
