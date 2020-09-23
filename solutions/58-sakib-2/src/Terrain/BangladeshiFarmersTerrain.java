package Terrain;

import javafx.geometry.Insets;
import javafx.scene.layout.BackgroundFill;
import javafx.scene.layout.CornerRadii;
import javafx.scene.paint.Color;

public class BangladeshiFarmersTerrain implements ITerrain {
    @Override
    public BackgroundFill getTerrain() {
        return new BackgroundFill(Color.GREEN, CornerRadii.EMPTY, Insets.EMPTY);
    }
}
