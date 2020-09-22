package Project.Utilities;

import java.util.ArrayList;

public class SceneSate {
    public String Village_name;
    public ArrayList<AssetInfo> assetList;

    public SceneSate(String Village_name){
        this.Village_name = Village_name;
        assetList = new ArrayList<AssetInfo>();
    }

    public void add_asset_to_list(String assetType, double x_coordinate, double y_coordinate){
        AssetInfo asset = new AssetInfo(assetType,x_coordinate,y_coordinate);
        this.assetList.add(asset);
    }
}
