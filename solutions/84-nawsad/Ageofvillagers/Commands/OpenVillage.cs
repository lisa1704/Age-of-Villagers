using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ageofvillagers
{
    class OpenVillage : Command
    {
        public string location;

        public OpenVillage(string location)
        {
            this.location = location;
        }
        public void execute(List<State> Itemslist)
        {
            using(FileStream fs2 = File.OpenRead(location))
            {
                XmlSerializer xm = new XmlSerializer(typeof(List<State>));
                Itemslist = (List<State>)xm.Deserialize(fs2);

            }
           
        }
    }
}
