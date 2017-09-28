using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparer
{
    public static class AddToDatabase
    {

        public static void CompareResults(string inputFile, string databaseFile)
        {
            //string x = System.IO.File.ReadLines(@"C:\Users\llluu\OneDrive\Documents\GitHub\ComparisonEngine\TemporaryResult.txt").ElementAt(0);
            string[] input = System.IO.File.ReadAllLines(inputFile);
            string[] database = System.IO.File.ReadAllLines(databaseFile);
            
            int neededValue = 85;
            int currentValue;

            foreach (string lineI in input)
            {
                foreach(string lineD in database)
                {
                    currentValue = Compare(lineI, lineD);
                    if(currentValue>neededValue)
                    {
                        
                    }
                    else
                    {
                        requestAddToDatabase(lineI);
                    }
                }
            }

            int Compare(string A, string B)
            {
                int counter = 0;
                int lenA = A.Length, lenB = B.Length;
                int lenMin, lenMax;
                if (lenA > lenB)
                {
                    lenMin = lenB;
                    lenMax = lenA;
                }
                else
                {
                    lenMin = lenA;
                    lenMax = lenB;
                }
                for (int i = 0; i < lenMin; i++)
                {
                    if (A[i] == B[i])
                        counter++;
                }
                return counter * 100 / lenMax;
            }

            void requestAddToDatabase(string newProduct)
            {

            }
        }
}
}
