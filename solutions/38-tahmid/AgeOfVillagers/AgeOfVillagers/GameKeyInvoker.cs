using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class GameKeyInvoker
    {
        Command theCommand;
        public GameKeyInvoker(Command theCommand)
        {
            this.theCommand = theCommand;
        }

        public void click()
        {
            theCommand.execute();
        }
    }
}
