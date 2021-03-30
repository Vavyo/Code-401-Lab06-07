using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public class AustralianShepherd : Dog
    {
        public override string Gender { get; set; }
        public override int Age { get; set; }
        public override string FurPattern => "black tri";
        public AustralianShepherd(string gender, int age)
        {
            Gender = gender;
            Age = age;
        }
    }
}
