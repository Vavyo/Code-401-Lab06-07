using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Zoo.Classes;

namespace Zoo.tests.Classes
{
    public class GermanShepherdTests
    {
        [Fact]
        public void Age_is_set_in_constructor()
        {
            // arrange
            GermanShepherd gus = new GermanShepherd("boy", 10, "brown");

            // act
            int age = gus.Age;

            // assert
            Assert.Equal(10, age);

        }
        [Fact]
        public void Gender_is_set_in_constructor()
        {
            // arrange
            GermanShepherd gus = new GermanShepherd("boy", 10, "black");

            // act
            string gender = gus.Gender;

            // assert
            Assert.Equal("boy", gender);

        }
        [Fact]
        public void Interface_implemented()
        {
            // arrange
            GermanShepherd gus = new GermanShepherd("boy", 10, "black");

            // act
            char result = gus.FurLength;

            // assert
            Assert.Equal('s', result);

        }
    }
}
