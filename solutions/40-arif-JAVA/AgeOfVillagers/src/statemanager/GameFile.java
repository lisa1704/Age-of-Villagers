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
}
