using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public class Siamese : Cat
    {

        public override int Age { get; set; }
        public override string Gender { get; set; }

        public Siamese(string gender, int age)
        {
            Gender = gender;
            Age = age;
        }
    }
}
