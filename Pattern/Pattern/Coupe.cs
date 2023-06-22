using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    public class Coupe : IReleaseNewModel
    {
        public void Release() => Console.WriteLine("Released coupe");
    }
}
