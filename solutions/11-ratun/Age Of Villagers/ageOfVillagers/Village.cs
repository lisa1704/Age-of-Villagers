﻿namespace ageOfVillagers
{
    public class Village
    {
        private Nation nation;
        private string villagename;
        public Village(Nation nation, string villagename)
        {
            this.nation = nation;
            this.villagename = villagename;
        }
    }
}