using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class Egyptian_Creator : AbstractNationFactoryCreator
    {
        private String nationName = "Egyptian Kings";

        public string GetNationName
        {
            get
            {
                return nationName;
            }

            set
            {
                if (value == "Egyptian Kings")
                    nationName = value;
            }
        }

        public override INation CreateNation => new Egyptian_King(nationName);
    }
}
