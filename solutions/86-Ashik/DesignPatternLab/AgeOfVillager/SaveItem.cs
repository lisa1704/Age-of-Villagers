using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillager
{
    public class SaveItem
    {
        private readonly Form1 form;
        private readonly MouseEventArgs e;

        public SaveItem(Form1 form, MouseEventArgs e)
        {
            this.form = form;
            this.e = e;
        }

        public void Save()
        {
            TextWriter txt = new StreamWriter("C:\\Users\\User\\Desktop\\save.txt");
            String text = String.Format("({0}, {1})", e.X, e.Y);
            txt.Write(text);
            txt.Close();
        }
    }
}
