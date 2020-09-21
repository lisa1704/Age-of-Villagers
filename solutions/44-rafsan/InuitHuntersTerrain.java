package sample;

public class InuitHuntersTerrain implements ITerrain {
    @Override
    public String draw(int point1, int point2) {
        return point1 + "and" + point2;
    }
}
