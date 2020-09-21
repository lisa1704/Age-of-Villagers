package project.Utilities.Factories;

import project.Utilities.NationItems.IAssets;

public interface IAssetFactory {
    IAssets createAsset(String nationType);
}
