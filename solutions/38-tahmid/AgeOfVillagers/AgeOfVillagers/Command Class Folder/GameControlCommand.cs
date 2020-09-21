using System;
using System.Collections.Generic;
using System.Text;
using AgeOfVillagers.Model_Class_Folder;


namespace AgeOfVillagers
{
    interface GameControlCommand
    {
        
        public State execute();
    }
}
