package sample;

public class BangladeshiFarmers  implements INation{
    @Override
    public IHouse getHouse() {
        return new BangladeshiFarmersHouse();
    }
}
