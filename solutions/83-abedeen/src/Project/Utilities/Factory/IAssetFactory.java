package Project.Utilities.Factory;
import Project.Utilities.NationItems.IAsset;

public interface IAssetFactory {
    IAsset CreateAsset(String nationType);
}
