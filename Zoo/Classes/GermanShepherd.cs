using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public class GermanShepherd : Dog, IHasFur
    {
        public override string Gender { get; set; }
        public override int Age { get; set; }
        public string FurPattern => "sable";

        public char FurLength => 's';

        public string FurColor { get; }

        public GermanShepherd(string gender, int age, string furColor)
        {
            Gender = gender;
            Age = age;
            FurColor = furColor;
        }
    }
}
