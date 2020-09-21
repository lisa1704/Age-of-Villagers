using Xunit;
using Age_of_villagers;
using System.Drawing;
using System.Collections.Generic;
namespace AgeOfVillagers.Test
{
    public class Villagetest
    {
        village village;
        public List<Point> h_point=new List<Point>();
        public List<Point> t_point=new List<Point>();
        public List<Point> w_point=new List<Point>();

        public List<Point> test_h_point = new List<Point>();
        public List<Point> test_t_point = new List<Point>();
        public List<Point> test_w_point = new List<Point>();

        Point h1 = new Point(10, 20);
        Point h2 = new Point(30, 35);
        Point t1 = new Point(5, 20);
        Point t2 = new Point(45, 35);
        Point w1 = new Point(35, 60);
        public Villagetest()
        {
           
            this.h_point.Add(h1);
            this.h_point.Add(h2);
            this.t_point.Add(t1);
            this.t_point.Add(t2);
            this.w_point.Add(w1);
            this.village = new village("Shonatoli", h_point, t_point, w_point);
        }

        public void house_expected()
        {
            this.test_h_point.Add(h1);
            this.test_h_point.Add(h2);            

        }
        public void tree_expected()
        {
            this.test_t_point.Add(t1);
            this.test_t_point.Add(t2);

        }
        public void watersource_expected()
        {
            this.test_w_point.Add(w1);

        }


        [Fact]
        public void villagenameTest()
        {
            Assert.Equal("Shonatoli", village.name);
        }

        [Fact]
        public void villagehousepositionTest()
        {
            house_expected();
            Assert.Equal(village.house_point, test_h_point);
        }

        [Fact]
        public void villagetreepositionTest()
        {
            tree_expected();
            Assert.Equal(village.tree_point, test_t_point);
        }

        [Fact]
        public void villagewatersourcepositionTest()
        {
            watersource_expected();
            Assert.Equal(village.waterresource_point, test_w_point);
        }

    }
}
