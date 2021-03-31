using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public class Koala : Marsupial, IHasClaws, IHasFur
    {
        public override string Gender { get; set; }
        public override int Age { get; set; }

        public bool CanClimb => true;

        public char FurLength => 's';

        public string FurPattern => "solid";

        public string FurColor { get; }

        public override string Attack()
        {
            return Scratch();
        }

        public override string Cry()
        {
            return "bellow";
        }
        public override string Feed(string food)
        {
            if (food == "plant")
                return "Yum";
            else
                return "Yuck";
        }

        public string Scratch()
        {
            return "I will drop from on high and rip the skin from your face.";
        }

        public Koala(string gender, int age, string furColor)
        {
            Gender = gender;
            Age = age;
            FurColor = furColor;
        }
    }
}
