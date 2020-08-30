using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalSimplification
{
    class Alert
    {
        internal static void Display(string vitalName, string breach)
        {
            Console.WriteLine($"{vitalName} is {breach}");

        }
    }
}
