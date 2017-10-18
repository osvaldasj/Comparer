using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparer.CompareEngine
{
    public interface IWritable
    {
        string Write(string x, int a);
        void Write(string x, float a);
        void Write(string x, string y, float a);
    }
}
