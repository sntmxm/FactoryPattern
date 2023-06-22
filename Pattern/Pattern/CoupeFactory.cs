using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    public class CoupeFactory : ICarFactory
    {
        public IReleaseNewModel Create() => new Coupe();
    }
}
