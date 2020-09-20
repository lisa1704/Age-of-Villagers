package sample;

public class InuitHunters implements INation {
    @Override
    public IHouse getHouse() {
        return new InuitHuntersHouse();
    }
}
