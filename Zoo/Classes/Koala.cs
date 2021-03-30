using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public class Koala : Marsupial
    {
        public override string Gender { get; set; }
        public override int Age { get; set; }

        public override string Attack()
        {
            return "I will drop from on high and rip the skin from your face.";
        }

        public override string Cry()
        {
            return "bellow";
        }
        public override string Feed(string food)
        {
            if (food == "plant")
                return "yum";
            else
                return "yuck";
        }
        public Koala(string gender, int age)
        {
            Gender = gender;
            Age = age;
        }
    }
}
