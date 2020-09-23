using AgeOfVillagers;
using System;
using Xunit;

namespace AgeOfVillagersTest
{
    public class UnitTest1
    {
        [Fact]
        Form1 form;
        public UnitTest1(Form1 form)
        {
            this.form = form;
        }
        BdFarmers bdFarmers = new BdFarmers();
        
        

        public void Test1()
        {
            if(form.comboBoxNationName.Text== "Bangladeshi Farmers")
            {

            }

        }
    }
}
