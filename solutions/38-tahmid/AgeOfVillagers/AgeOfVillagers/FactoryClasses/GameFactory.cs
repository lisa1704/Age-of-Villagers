using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class GameFactory
    {
        public IGames getGame()
        {
            Console.WriteLine("xx");
            return new AOV();
        }
    }
}
