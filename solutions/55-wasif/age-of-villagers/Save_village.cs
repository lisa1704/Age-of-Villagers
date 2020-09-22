using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_of_villagers
{
    class Save_village
    {
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        saveFileDialog1.DefaultExt = "txt";      
        saveFileDialog1.Filter = "AOV (*.aov)|*.txt";      
        saveFileDialog1.FilterIndex = 1;      
        saveFileDialog1.RestoreDirectory = true;      
        if (saveFileDialog1.ShowDialog() == DialogResult.OK) {      
            textBox1.Text = saveFileDialog1.FileName;

    }
}
