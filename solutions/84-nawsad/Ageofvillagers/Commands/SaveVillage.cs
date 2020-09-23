using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Ageofvillagers
{
    public class SaveVillage : Command
    {
        public void execute(List<State> Itemslist)
        {
            Stream stream = File.OpenWrite("C:\\Users\\Rakib\\Desktop\\Design Pattern Lab assignment\\solutions\\84-nawsad\\Ageofvillagers\\SavedVillages\\village.txt");
            XmlSerializer xm = new XmlSerializer(typeof(List<State>));
            xm.Serialize(stream, Itemslist);
        }
        
    }
}
