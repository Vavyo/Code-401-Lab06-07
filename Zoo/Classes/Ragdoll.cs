using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public class Ragdoll : Cat, IHasClaws, IHasFur
    {
        public override string Gender { get; set; }
        public override int Age { get;  set; }

        public bool CanClimb => true;

        public char FurLength => 'l';

        public string FurPattern => "ragdoll";

        public string FurColor { get; }

        public Ragdoll(string gender, int age, string furColor)
        {
            Gender = gender;
            Age = age;
            FurColor = furColor;
        }

        public string Scratch()
        {
            return "Slash with my sharp claws"; ;
        }

        public override string Attack()
        {
            return Scratch();
        }
    }
}
