package statemanager;

import java.util.ArrayList;

public class State {
    ArrayList<LineState> lines = new ArrayList<>();
    ArrayList<CircleState> circles = new ArrayList<>();

    private static State ourInstance = new State();

    public static State getInstance() {
        return ourInstance;
    }

    private State() {
    }

    public void addLine(LineState lineState){
        lines.add(lineState);
    }
    public void addCircle(CircleState circleState){
        circles.add(circleState);
    }
}
