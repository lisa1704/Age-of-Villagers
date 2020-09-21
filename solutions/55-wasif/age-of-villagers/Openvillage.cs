using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_of_villagers
{
    class Openvillage
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog
        {
            CheckFileExists = true,
            CheckPathExists = true,

            DefaultExt = "txt",
            Filter = "aov files (*.aov)|*.txt",
            FilterIndex = 2,
            RestoreDirectory = true,

            ReadOnlyChecked = true,
            ShowReadOnly = true
        };

    }
}
