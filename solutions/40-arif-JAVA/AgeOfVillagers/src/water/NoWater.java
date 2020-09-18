package water;

public class NoWater implements IWater {
    @Override
    public void draw() {
        System.out.println("no water");
    }
}
