package Terrain;

import javafx.geometry.Insets;
import javafx.scene.layout.BackgroundFill;
import javafx.scene.layout.CornerRadii;
import javafx.scene.paint.Color;

public class EgyptianKingsTerrain implements ITerrain {
    @Override
    public BackgroundFill getTerrain() {
        return new BackgroundFill(Color.YELLOW, CornerRadii.EMPTY, Insets.EMPTY);
    }
}
