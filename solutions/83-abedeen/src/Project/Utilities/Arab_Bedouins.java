package Project.Utilities;

import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;
import javafx.scene.transform.Rotate;

import java.util.ArrayList;

public class Arab_Bedouins implements INations{
    private String TerrainColor = "#fffde3";
    public Arab_Bedouins(){
        super();
    }

    @Override
    public ArrayList<Shape> drawHouse(double x, double y) {
        ArrayList<Shape> house = new ArrayList<Shape>();
        //Triangle
        house.add(new Line(x,y,x+(3*houseWidth/4),y));
        house.add(new Line(x+(3*houseWidth/4),y,x+(3*houseWidth/4)/2,y-(3*houseHeight/4)));
        house.add(new Line(x+(3*houseWidth/4)/2,y-(3*houseHeight/4),x,y));

        //Rectangle
        house.add(new Line(x+(3*houseWidth/4),y,x+houseWidth,y-(houseHeight/4)));
        house.add(new Line(x+(3*houseWidth/4)/2,y-(3*houseHeight/4),x+((3*houseWidth/4)/2)+(houseWidth/4),y-houseHeight));
        house.add(new Line(x+(3*houseWidth/4)+.5,y-.5,x+.5+(3*houseWidth/4)/2,y-(3*houseHeight/4)-.5));
        house.add(new Line(x+houseWidth,y-(houseHeight/4),x+((3*houseWidth/4)/2)+(houseWidth/4),y-houseHeight));
        return house;
    }

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

    @Override
    public ArrayList<Shape> drawWaterBody(double x, double y) {
        ArrayList<Shape> WB = new ArrayList<Shape>();
        return WB;
    }

    @Override
    public String GetTerrainColor() {
        return this.TerrainColor;
    }
}
