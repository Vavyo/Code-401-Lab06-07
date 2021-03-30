using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public class GermanShepherd : Dog
    {
        public override string Gender { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string FurPattern => "sable";
        public GermanShepherd(string gender, int age)
        {
            Gender = gender;
            Age = age;
        }
    }
}
