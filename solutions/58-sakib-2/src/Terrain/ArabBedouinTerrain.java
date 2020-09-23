package Terrain;

import javafx.geometry.Insets;
import javafx.scene.layout.BackgroundFill;
import javafx.scene.layout.CornerRadii;
import javafx.scene.paint.Color;

public class ArabBedouinTerrain implements ITerrain {
    @Override
    public BackgroundFill getTerrain() {
        return new BackgroundFill(Color.LIGHTYELLOW,CornerRadii.EMPTY, Insets.EMPTY);
    }
}
