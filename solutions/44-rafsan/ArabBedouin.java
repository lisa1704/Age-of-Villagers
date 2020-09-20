package sample;

public class ArabBedouin implements INation {
    @Override
    public IHouse getHouse() {
        System.out.println("Arab House Object Created");
        return new ArabBedouinHouse();
    }
}
