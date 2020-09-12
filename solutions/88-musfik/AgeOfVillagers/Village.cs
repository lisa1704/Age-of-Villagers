using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public interface INation
    {

    }
    public class Village
    {
        private string villageName;
        private INation nation;

        public Village(string villageName, INation nation)
        {
            this.villageName = villageName;
            this.nation = nation;
        }

        public string GetVillageName()
        {
            return villageName;
        }

        public void SetVillageName(string value)
        {
            villageName = value;
        }
    }
}
