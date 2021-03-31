using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public class AustralianShepherd : Dog, IHasFur
    {
        public override string Gender { get; set; }
        public override int Age { get; set; }
        public string FurPattern { get; }

        public char FurLength => 'l';

        public string FurColor { get; }

        public AustralianShepherd(string gender, int age, string furColor, string furPattern)
        {
            Gender = gender;
            Age = age;
            FurColor = furColor;
            FurPattern = furPattern;
        }
    }
}
