package Terrain;

import javafx.geometry.Insets;
import javafx.scene.layout.BackgroundFill;
import javafx.scene.layout.CornerRadii;
import javafx.scene.paint.Color;

public class InuitHuntersTerrain implements ITerrain {
    @Override
    public BackgroundFill getTerrain() {
        return new BackgroundFill(Color.WHITE, CornerRadii.EMPTY, Insets.EMPTY);
    }
}
