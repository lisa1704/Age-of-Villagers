using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class NationNameFactory
    {
        Form1 form;
        INation obj;
        public NationNameFactory(Form1 form)
        {
            this.form = form;
        }
        public INation NationNameFactoryMethod()
        {
            return obj;
        }


    }

}
