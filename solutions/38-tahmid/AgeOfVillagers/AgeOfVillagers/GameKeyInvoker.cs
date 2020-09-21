using AgeOfVillagers.Model_Class_Folder;
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

        public State click()
        {
            return theCommand.execute();
        }
    }
}
