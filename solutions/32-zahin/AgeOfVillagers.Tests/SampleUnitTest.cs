using Xunit;
namespace AgeOfVillagers.Tests
{
    public class SampleUnitTest
    {
        [Fact]
        public void VillageTypeTest()
        {
            var expected = 4;
            var actual = 2 + 2;
            Assert.Equal(expected, actual);
        }
    }
}
