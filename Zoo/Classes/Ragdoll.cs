using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public class Ragdoll : Cat
    {
        public override string Gender { get; set; }
        public override int Age { get;  set; }
        public Ragdoll(string gender, int age)
        {
            Gender = gender;
            Age = age;
        }
        
    }
}
