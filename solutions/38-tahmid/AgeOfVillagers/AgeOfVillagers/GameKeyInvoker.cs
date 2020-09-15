using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class GameKeyInvoker
    {
        GameControlCommand theCommand;
        public GameKeyInvoker(GameControlCommand theCommand)
        {
            this.theCommand = theCommand;
        }

        public void click()
        {
            theCommand.execute();
        }
    }
}
