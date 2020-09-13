using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Age_of_villagers
{
    public interface Icommand
    {
        void execute(Stream stream,village vilage);
    }
    public struct village
    {
        public string name;
        public List<Point> house_point;
        public List<Point> tree_point;
        public List<Point> waterresource_point;
    }
    public class Savevillage : Icommand
    {
        public void execute(Stream stream, village village)
        {
            using(StreamWriter sw = new StreamWriter(stream))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(sw, village);
                sw.Close();
            }
           
        }
    }
}
