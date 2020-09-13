using System;

namespace AgeOfVillagers
{
    public interface IState
    {
        void SetVillageName(string villagename);

        String GetVillageName();
    }
}
