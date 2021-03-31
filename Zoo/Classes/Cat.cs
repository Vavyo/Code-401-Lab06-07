using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public abstract class Cat : Mammal 
    {
        // methods
        public override string Cry()
        {
            return "Meow";
        }
    }
}
