using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Classes;
using Xunit;

namespace Zoo.tests.Classes
{
    public class AustralianShepherdTests
    {
        [Fact]
        public void FurPattern_returns_black_tri()
        {
            // arrange
            AustralianShepherd gus = new AustralianShepherd("boy", 10);

            // act
            string fur = gus.FurPattern;
            // assert
            Assert.Equal("black tri", fur);
        }
        [Fact]
        public void Cry_returns_bark()
        {
            // arrange
            AustralianShepherd gus = new AustralianShepherd("boy", 10);

            // act
            string cry = gus.Cry();
            // assert
            Assert.Equal("Bark", cry);
        }
    }
}
