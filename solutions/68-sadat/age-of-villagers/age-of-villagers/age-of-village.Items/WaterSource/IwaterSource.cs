using age_of_villagers.age_of_villagers.utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace age_of_villagers
{
    interface IwaterSource
    {
        void createWaterSource(Coordinate coordinate, Panel villageCanvas);
    }
}
