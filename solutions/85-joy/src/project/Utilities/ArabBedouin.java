package project.Utilities;

import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class ArabBedouin implements  INation{
    private  String TerrainColor = "#EDE574";

    public ArabBedouin(){
        super();
    }
    @Override
    public ArrayList<Shape> DrawHouse(double x1, double y1) {

        ArrayList<Shape> House = new ArrayList<Shape>();

        //Triangle
        Line line1 = new Line(x1,y1,x1+(HouseWidth-4),y1);
        House.add(line1);
        Line line2 = new Line(x1+(HouseWidth-4),y1,x1+((HouseWidth-4)/2),y1-12);
        line2.setStrokeWidth(2.0);
        House.add(line2);
        Line line3 = new Line(x1+((HouseWidth-4)/2),y1-12,x1,y1);
        House.add(line3);

        //Rectangle
        Line line4 = new Line(x1+(HouseWidth-4),y1,x1+HouseWidth,y1-4);
        House.add(line4);
        Line line5 = new Line(x1+HouseWidth,y1-4,x1+((HouseWidth-4)-2),y1-HouseHeight);
        House.add(line5);
        Line line6 = new Line(x1+((HouseWidth-4)-2),y1-HouseHeight,x1+((HouseWidth-4)/2),y1-12);
        House.add(line6);

        return House;
    }

    @Override
    public ArrayList<Shape> DrawTree(double x1, double y1) {
        ArrayList<Shape> Tree = new ArrayList<Shape>();

        Line line1 = new Line(x1,y1,x1-(TreeWidth/2),y1-4);
        Tree.add(line1);
        Line line2 = new Line(x1,y1,x1-(5),y1-8);
        Tree.add(line2);
        Line line3 = new Line(x1,y1,x1,y1-(TreeHeight/2));
        Tree.add(line3);

        Line line4 = new Line(x1,y1,x1+5,y1-8);
        Tree.add(line4);
        Line line5 = new Line(x1,y1,x1+(TreeWidth/2),y1-4);
        Tree.add(line5);

        //Tinsy Square
        Line line6 = new Line(x1-1,y1-1,x1+1,y1+1);
        Tree.add(line6);
        Line line7 = new Line(x1-1,y1-1,x1-1,y1+(TreeHeight/2));
        Tree.add(line7);
        Line line8 = new Line(x1-1,y1+(TreeHeight/2),x1+1,y1+(TreeHeight/2));
        Tree.add(line8);
        Line line9 = new Line(x1+1,y1+(TreeHeight/2),x1+1,y1+1);
        Tree.add(line9);
        
        return Tree;
    }

    @Override
    public ArrayList<Shape> DrawWaterSource(double x1, double y1) {
        return null;
    }

    @Override
    public String getTerrainColor() {
        return TerrainColor;
    }
}
