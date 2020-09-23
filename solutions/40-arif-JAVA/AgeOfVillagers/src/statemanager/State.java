package statemanager;

import shape.Circle;
import shape.Line;

import java.io.Serializable;
import java.util.ArrayList;

public class State implements Serializable {
    ArrayList<Line> lines = new ArrayList<>();
    ArrayList<Circle> circles = new ArrayList<>();

    private static State ourInstance = new State();

    public static State getInstance() {
        return ourInstance;
    }

    private State() {
    }

    public void addLine(Line lineState){
        lines.add(lineState);
    }
    public void addCircle(Circle circleState){
        circles.add(circleState);
    }

    public ArrayList<Line> getLines(){
        return this.lines;
    }
    public ArrayList<Circle> getCircles(){
        return this.circles;
    }


}
