using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public interface IHasClaws
    {
        string Scratch();

        bool CanClimb { get; }
    }
}
