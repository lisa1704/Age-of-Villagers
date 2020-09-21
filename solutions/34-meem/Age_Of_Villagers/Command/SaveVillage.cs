using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Of_Villagers.Command
{
    public class SaveVillage : ICommand
    {
        Village _village;
        public SaveVillage(Village village)
        {
            _village = village;

        }

        public void execute()
        {
            


        }
    }
}
