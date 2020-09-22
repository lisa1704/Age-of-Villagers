package project.Utilities.Factories;

import project.Utilities.NationItems.*;

public class TreeFactory implements IAssetFactory{
    public ITree tree;
    @Override
    public IAssets createAsset(String nationType) {
        this.tree = null;
        if(nationType == "Bangladeshi Farmers"){
            tree = new Bangladeshi_Farmers_Tree();
        }
        else if(nationType == "Arab Bedouin"){
            tree = new Arab_Bedouin_Tree();
        }
        else if(nationType == "Egyptian Kings"){
            tree = new Egyptian_kings_Tree();
        }
        else if(nationType == "Inuit Hunters"){
            tree = new Null_Tree();
        }
        else{
            tree = new Null_Tree();
        }

        return tree;
    }
}
