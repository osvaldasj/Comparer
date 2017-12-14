using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparer.AdditionalFeatures
{
    public class LazyInicialization
    {
        public LazyInicialization(int x)
        {
            Console.WriteLine("Magic happened" + x);
        }
    }
}
