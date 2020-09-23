package statemanager;

public class GameFile {
    String villagename;
    String villagetype;
    State state;

    public GameFile(String villagename, String villagetype, State state) {
        this.villagename = villagename;
        this.villagetype = villagetype;
        this.state = state;
    }

    public String getVillagename() {
        return villagename;
    }

    public void setVillagename(String villagename) {
        this.villagename = villagename;
    }

    public String getVillagetype() {
        return villagetype;
    }

    public void setVillagetype(String villagetype) {
        this.villagetype = villagetype;
    }

    public State getState() {
        return state;
    }

    public void setState(State state) {
        this.state = state;
    }
}
