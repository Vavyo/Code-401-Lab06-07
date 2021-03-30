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
            Siamese kitter = new Siamese("girl", 4);
            // act
            string cry = kitter.Cry();
            // assert
            Assert.Equal("Meow", cry);
        }
        [Fact]
        public void Gender_returns_constructed()
        {
            // arrange
            Siamese kitter = new Siamese("girl", 4);
            // act
            string gender = kitter.Gender;
            // assert
            Assert.Equal("girl", gender);
        }
    }
}
