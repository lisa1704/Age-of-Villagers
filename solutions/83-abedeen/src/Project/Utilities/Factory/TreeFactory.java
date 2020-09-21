package Project.Utilities.Factory;

import Project.Utilities.NationItems.*;

public class TreeFactory implements IAssetFactory{
    ITree tree;
    @Override
    public ITree CreateAsset(String nationType) {
        if(nationType == "Bangladeshi Farmers"){
            tree = new Bangladeshi_Tree();
        }
        else if(nationType == "Arab Bedouins"){
            tree = new Arab_Bedouin_Tree();
        }
        else if(nationType == "Egyptian Kings"){
            tree = new Egyptian_Kings_Tree();
        }
        else {
            tree = new Null_Tree();
        }
        return tree;
    }
}
