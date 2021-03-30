using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Zoo.Classes;

namespace Zoo.tests.Classes
{
    public class RagdollTests
    {
        [Fact]
        public void Feed_returns_yum_on_meat()
        {
            // arrange
            Ragdoll meg = new Ragdoll("girl", 5);
            // act
            string result = meg.Feed("meat");
            // assert
            Assert.Equal("Yum", result);
        }
        [Fact]
        public void Attack_returns_claw_message()
        {
            // arrange
            Ragdoll meg = new Ragdoll("girl", 5);
            // act
            string result = meg.Attack();
            // assert
            Assert.Equal("Slash with my sharp claws", result);
        }
    }
}
