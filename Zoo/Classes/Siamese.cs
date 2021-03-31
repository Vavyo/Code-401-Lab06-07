using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public class Siamese : Cat, IHasClaws, IHasFur
    {

        public override int Age { get; set; }
        public override string Gender { get; set; }
        
        public bool CanClimb => true;

        public string FurPattern => "Siamese";

        public string FurColor { get; }

        public char FurLength => 's';

        public Siamese(string gender, int age, string furColor)
        {
            Gender = gender;
            Age = age;
            FurColor = furColor;
        }

        public string Scratch()
        {
            return "Slash with my sharp claws";
        }

        public override string Attack()
        {
            return Scratch();
        }
    }
}
