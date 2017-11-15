using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.ComparisonEngine
{
    public interface IWritable
    {
        string Write(int a, string infoToShow);
        string Write<T>(T x, float a, string infoToShow);
        string Write(string x, string y, float a, string infoToShow);
    }
}