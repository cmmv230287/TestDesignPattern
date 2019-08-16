using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Prototype.Example2.Interfaces
{
    public interface IClonable<T> where T : IClonable<T>
    {
        T Clone();
    }
}
