using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace age_of_villagers
{
    public class village_factory
    {
        public INations village;
        public Graphics gp;
        public village_factory(Graphics gp)
        {
            this.gp = gp;
        }
        public INations get_nation(string village_type)
        {
            if (village_type == "Bangladeshi Farmers")
                return new Bangladeshi_Farmers(gp);
            else if (village_type == "Arab Bedouin")
                return new Arab_Beduin(gp);
            else if (village_type == "Egyptian Kings")
                return new Egyptian_Kings(gp);
            else if (village_type == "Inuit Hunters")
                return new Inuit_Hunters(gp);
            else return null;
        }
    }
}
