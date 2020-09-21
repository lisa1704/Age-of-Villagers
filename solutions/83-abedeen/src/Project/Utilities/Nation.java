package Project.Utilities;

import Project.Utilities.NationItems.Bangladeshi_House;
import Project.Utilities.NationItems.Bangladeshi_Tree;
import Project.Utilities.NationItems.IHouse;
import Project.Utilities.NationItems.ITree;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Nation {
    private IHouse house;
    private ITree tree;

    public Nation(String nation_type){
        if(nation_type == "Bangladeshi Farmers"){
            this.house = new Bangladeshi_House();
            this.tree = new Bangladeshi_Tree();
        }
    }

    public ArrayList<Shape> drawHouse(double x, double y){
        return this.house.drawHouse(x,y);
    }
    public ArrayList<Shape> drawTree(double x, double y){
        return this.tree.drawTree(x,y);
    }
}
