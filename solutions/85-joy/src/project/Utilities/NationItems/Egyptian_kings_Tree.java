package project.Utilities.NationItems;

import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Egyptian_kings_Tree implements ITree{
    @Override
    public ArrayList<Shape> DrawTree(double x1, double y1) {
        ArrayList<Shape> Tree = new ArrayList<Shape>();

        Line line1 = new Line(x1,y1,x1+4,y1-18);
        Tree.add(line1);
        Line line2 = new Line(x1+4,y1-18,x1+8,y1-19);
        Tree.add(line2);
        Line line3 = new Line(x1+4,y1-18,x1+6,y1-23);
        Tree.add(line3);
        Line line4 = new Line(x1+4,y1-16,x1+3,y1-24);
        Tree.add(line4);

        Line line5 = new Line(x1,y1,x1-4,y1-18);
        Tree.add(line5);
        Line line6 = new Line(x1-4,y1-18,x1-8,y1-19);
        Tree.add(line6);
        Line line7 = new Line(x1-4,y1-18,x1-6,y1-23);
        Tree.add(line7);
        Line line8 = new Line(x1-4,y1-16,x1-3,y1-24);
        Tree.add(line8);
        return Tree;
    }
}
