using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class Inuit_Creator : AbstractNationFactoryCreator
    {
        private String nationName = "Inuit Hunters";

        public string GetNationName
        {
            get
            {
                return nationName;
            }

            set
            {
                if (value == "Inuit Hunters")
                    nationName = value;
            }
        }

        public override INation CreateNation()
        {
            return new Inuit_Hunter(nationName);
        } 
        
    }
}
