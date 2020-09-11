using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class GameFactory
    {
        public Games getGame()
        {
            Console.WriteLine("xx");
            return new AOV();
        }
    }
}
