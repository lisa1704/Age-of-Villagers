public class ArabBedouin implements INation {

    @Override
    public void house(DrawHouse drawHouse) {
        drawHouse.drawOuterLayer();
    }

    @Override
    public void tree(DrawTree drawTree) {
        drawTree.drawOuterLayer();
    }

    @Override
    public void waterSource(DrawWater drawWater) {
        drawWater.drawOuterLayer();
    }
}
