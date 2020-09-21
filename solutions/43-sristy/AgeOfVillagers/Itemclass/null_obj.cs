using System.Drawing;

namespace Age_of_villagers
{
    public class null_obj : IObject
    {
        private static IObject _instance;
        private null_obj() { }
        public void paint(Pen p, Graphics g)
        {
            //null
        }
        public static IObject Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new null_obj();
                }
                return _instance;
            }
        }
    }
}
