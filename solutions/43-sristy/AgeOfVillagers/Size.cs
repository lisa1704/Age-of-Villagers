using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_villagers
{
    public abstract class Size
    {

        public abstract int GetWeidth();
        public abstract int GetHeight();

    }

    public class Housesize : Size
    {
        public override int GetHeight()
        {
            return 16;
        }

        public override int GetWeidth()
        {
            return 16;
        }
    }

    public class Treesize : Size
    {
        public override int GetHeight()
        {
            return 24;
        }

        public override int GetWeidth()
        {
            return 16;
        }
    }
    public class BDWatersourcesize : Size
    {
        public override int GetHeight()
        {
            return 16;
        }

        public override int GetWeidth()
        {
            return 24;
        }
    }
    public class EGPTWatersourcesize : Size
    {
        public override int GetHeight()
        {
            return 12;
        }

        public override int GetWeidth()
        {
            return 12;
        }
    }

}
