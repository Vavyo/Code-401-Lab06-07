using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Zoo.Classes;

namespace Zoo.tests.Classes
{
    public class SiameseTests
    {
        [Fact]
        public void Cry_returns_meow()
        {
            // arrange
            Siamese kitter = new Siamese("girl", 4, "light");
            // act
            string cry = kitter.Cry();
            // assert
            Assert.Equal("Meow", cry);
        }
        [Fact]
        public void Gender_returns_constructed()
        {
            // arrange
            Siamese kitter = new Siamese("girl", 4, "dark");
            // act
            string gender = kitter.Gender;
            // assert
            Assert.Equal("girl", gender);
        }
        [Fact]
        public void Proof_of_interface()
        {
            // arrange
            Siamese kitter = new Siamese("girl", 5, "dark");

            // act
            char result = kitter.FurLength;

            //assert
            Assert.Equal('s', result);
        }

    }
}
