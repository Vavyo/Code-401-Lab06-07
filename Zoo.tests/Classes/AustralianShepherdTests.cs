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
            AustralianShepherd gus = new AustralianShepherd("boy", 10, "blue", "merle");

            // act
            string fur = gus.FurPattern;
            // assert
            Assert.Equal("merle", fur);
        }
        [Fact]
        public void Cry_returns_bark()
        {
            // arrange
            AustralianShepherd gus = new AustralianShepherd("boy", 10, "black", "tri");

            // act
            string cry = gus.Cry();
            // assert
            Assert.Equal("Bark", cry);
        }
        [Fact]
        public void Interface_implemented()
        {
            // arrange
            AustralianShepherd gus = new AustralianShepherd("boy", 10, "black", "tri");

            // act
            string fur = gus.FurColor;
            // assert
            Assert.Equal("black", fur);
        }
    }
}
