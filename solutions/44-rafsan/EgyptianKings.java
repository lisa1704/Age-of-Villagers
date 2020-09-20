package sample;

public class EgyptianKings implements INation {
    @Override
    public IHouse getHouse() {
        return new EgyptianKingsHouse();
    }
}
