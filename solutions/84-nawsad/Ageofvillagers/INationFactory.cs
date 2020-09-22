using Ageofvillagers.Nations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ageofvillagers
{    
    
    class INationFactory
    {
        INation nation;
        String nation_type;
        private Graphics g;
        private Pen p;
        public INationFactory(Graphics g,Pen p,string nation_type)
        {
            this.g = g;
            this.p = p;
            this.nation_type = nation_type;
        }
        public INation get_Nation()
        {
            if(nation_type=="Arab Beduin")
            {
                return new ArabBeduin(g, p);
            }
            else if(nation_type=="Bangladeshi Farmer")
            {
                return new BangladeshiFarmer(g, p);
            }
            else if(nation_type=="Egyptian King")
            {
                return new EgyptianKing(g, p);
            }
            else
            {
                return new InuitHunters(g, p);
            }
            

        }
    }
}
