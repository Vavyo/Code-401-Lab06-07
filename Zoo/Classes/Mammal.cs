using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public abstract class Mammal
    {
        // Properties
        public virtual int Limbs => 4;
        public virtual bool Nocturnal => true;
        public abstract string Gender { get; set; }
        public abstract int Age { get; set; }

        // Methods
        public abstract string Cry();
        public abstract string Attack();
        public virtual string Feed(string food)
        {
            if (food == "meat")
                return "yum";
            else
                return "yuck";
        }
        public virtual string Climb()
        {
            return "With ease.";
        }
    }
}
