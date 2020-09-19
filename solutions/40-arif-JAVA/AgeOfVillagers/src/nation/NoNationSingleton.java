package nation;

public class NoNationSingleton {
    private static NoNationSingleton ourInstance = null;
    private NoNations noNations;

    public static NoNationSingleton getInstance() {
        if(ourInstance==null) ourInstance = new NoNationSingleton();
        return ourInstance;
    }

    private NoNationSingleton() {
        noNations = new NoNations();
    }
    public INation getNation(){
        return noNations;
    }
}
