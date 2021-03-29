using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public abstract class Dog: Mammal
    {
        // properties
        public virtual string FurPattern => "solid";

        // methods
        public override string Attack()
        {
            return "Bite with my strong teeth";
        }
        public override string Cry()
        {
            return "Bark";
        }
        public override string Climb()
        {
            return "Unless it's a slope I'll have a hard time";
        }
    }
}
