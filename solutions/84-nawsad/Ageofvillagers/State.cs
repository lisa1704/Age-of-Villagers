using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ageofvillagers
{  
    [Serializable]
    public class State
    {
        
        public int Itemx;
        public int Itemy;
        public String Item_name;
        public String Nation_Name;


        public State(int Itemx,int Itemy,String Item_name,string Nation_Name)
        {
            this.Itemx = Itemx;
            this.Itemy = Itemy;
            this.Item_name = Item_name;
            this.Nation_Name = Nation_Name;
        }
    }
}
