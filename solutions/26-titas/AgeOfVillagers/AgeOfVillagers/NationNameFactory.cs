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
            if (form.comboBoxNationName.Text == "Bangladeshi Farmers")
            {
                obj = new BdFarmers();
            }
            else if (form.comboBoxNationName.Text == "Arab Bedouin")
            {
                obj = new ArabBedouin();
            }
            else if (form.comboBoxNationName.Text == "Egyptian Kings")
            {
                obj = new EgyptianKings();
            }
            else if (form.comboBoxNationName.Text == "Inuit Hunters")
            {
                obj = new InuitHunters();
            }
            return obj;
        }


    }

}
