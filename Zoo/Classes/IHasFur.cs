using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Classes
{
    public interface IHasFur
    {
        char FurLength { get; }

        string FurPattern { get; }

        string FurColor { get; }
    }
}
