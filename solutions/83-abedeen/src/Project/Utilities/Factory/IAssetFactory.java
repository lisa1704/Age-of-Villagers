package Project.Utilities.Factory;

import Project.Utilities.NationItems.IAsset;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public interface IAssetFactory {
    IAsset CreateAsset(String nationType);
}
