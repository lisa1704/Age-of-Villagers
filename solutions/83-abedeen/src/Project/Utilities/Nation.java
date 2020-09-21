package Project.Utilities;

import Project.Utilities.NationItems.Bangladeshi_House;
import Project.Utilities.NationItems.IHouse;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Nation {
    private IHouse house;

    public Nation(String nation_type){
        if(nation_type == "Bangladeshi Farmers"){
            house = new Bangladeshi_House();
        }
    }

    public ArrayList<Shape> drawHouse(double x, double y){
        return house.drawHouse(x,y);
    }
}
