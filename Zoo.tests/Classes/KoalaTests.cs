using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Zoo.Classes;

namespace Zoo.tests.Classes
{
    public class KoalaTests
    {
        [Fact]
        public void Feed_returns_yum_with_plant()
        {
            // arrange 
            Koala greg = new Koala("boy", 2, "brown");
            // act
            string result = greg.Feed("plant");
            // assert
            Assert.Equal("Yum", result);
        }
        [Fact]
        public void Feed_returns_yuck_with_meat()
        {
            // arrange 
            Koala greg = new Koala("boy", 2, "brown");
            // act
            string result = greg.Feed("meat");
            // assert
            Assert.Equal("Yuck", result);
        }
        [Fact]
        public void Interface_implemented()
        {
            // arrange 
            Koala greg = new Koala("boy", 2, "brown");
            // act
            string result = greg.FurPattern;
            // assert
            Assert.Equal("solid", result);
        }
    }
}
