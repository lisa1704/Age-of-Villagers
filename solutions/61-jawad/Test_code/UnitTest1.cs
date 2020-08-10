using System;
using Xunit;


namespace Test_code
{
    public class UnitTest1
    {
        public void Test1()
        {
            int t1 = 10;
            int t2 = 10;
            object p = Assert.Equal(t1, t2);
        }
    }

}

