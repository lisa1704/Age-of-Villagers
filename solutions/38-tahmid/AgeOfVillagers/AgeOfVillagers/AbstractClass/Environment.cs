using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    public abstract class Environment
    {
        public abstract void showNationName();
        public abstract void InvalidateOtherNations();

        public abstract void setTerrainColor();

        public void setEnvironment()
        {
            showNationName();
            InvalidateOtherNations();
            setTerrainColor();
        }



    }
}
