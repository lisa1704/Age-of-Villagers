using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace AgeOfVillagers
{
	public interface IShape
	{
        public void draw(Pen pen, Graphics graphics);
        
    }
}
