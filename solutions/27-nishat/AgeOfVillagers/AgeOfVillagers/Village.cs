using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public class Village
    {
        private INation nation;
        private string villagename;

        public Village(INation nation, string villagename)
        {
            this.nation = nation;
            this.villagename = villagename;
        }

        internal void initiate(Graphics g)
        {
            g.Clear(nation.GetTerrainColor());
        }

        internal IState GetState()
        {
            return new Villagestate(villagename);
        }

        internal void SetState(IState state)
        {
            villagename = state.GetVillageName();
        }
    }
    public interface IState
    {
        void SetVillageName(string villagename);
        String GetVillageName();
    }
    public class Villagestate : IState
    {
        public string villagename;

        public Villagestate(string villagename)
        {
            this.villagename = villagename;
        }

        public string GetVillageName()
        {
            return villagename;
        }

        public void SetVillageName(string villagename)
        {
            this.villagename = villagename;
        }
    }
}
