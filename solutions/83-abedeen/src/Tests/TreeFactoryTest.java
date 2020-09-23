package Tests;

import Project.Utilities.Nation;
import Project.Utilities.NationItems.*;
import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

public class TreeFactoryTest {
    @Test
    protected void Bangladeshi_Tree_Factory_Test()
    {
        Nation bangladesh = new Nation("Bangladeshi Farmers");
        ITree tree = new Bangladeshi_Tree();
        Assertions.assertEquals(tree.getClass(), bangladesh.tree.getClass());
    }

    @Test
    protected void Arabian_Tree_Factory_Test()
    {
        Nation arab = new Nation("Arab Bedouins");
        ITree tree = new Arab_Bedouin_Tree();
        Assertions.assertEquals(tree.getClass(), arab.tree.getClass());
    }

    @Test
    protected void Egyptian_Tree_Factory_Test()
    {
        Nation Egyptian = new Nation("Egyptian Kings");
        ITree tree = new Egyptian_Kings_Tree();
        Assertions.assertEquals(tree.getClass(), Egyptian.tree.getClass());
    }

}
