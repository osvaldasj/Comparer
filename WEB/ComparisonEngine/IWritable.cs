using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.ComparisonEngine
{
    public interface IWritable
    {
        string WriteFirst(int a, string infoToShow);
        string WriteLast(float a, string infoToShow);
        string Write(string x, float a, string infoToShow);
    }
}