package sample;

public class BangladeshiFarmersWaterSource implements IWaterSource {
    @Override
    public void draw(Point point) {

    }

    @Override
    public String canvasController(int point1, int pont2) {
        return point1+" and "+pont2;
    }

    @Override
    public String releaseCanvas(int point1, int pont2) {
        return point1+" and "+pont2;
    }

    @Override
    public String getCanvas(int point1, int pont2) {
        return point1+" and "+pont2;
    }
}
