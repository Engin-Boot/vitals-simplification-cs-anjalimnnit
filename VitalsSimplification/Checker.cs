using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VitalsSimplification
{
    class Program
    {
        static void ExpectTrue(bool expression)
        {
            if (!expression)
            {
                Console.WriteLine("Expected true, but got false");
                Environment.Exit(1);
            }
        }
        static void ExpectFalse(bool expression)
        {
            if (expression)
            {
                Console.WriteLine("Expected false, but got true");
                Environment.Exit(1);
            }
        }
        static int Main(string[] args)
        {
            ExpectTrue(VitalsSimplification.VitalsChecker.VitalsAreOk(100, 95, 60)); //(1,1,1,)
            ExpectFalse(VitalsSimplification.VitalsChecker.VitalsAreOk(40, 91, 92)); //(0,1,1)
            ExpectFalse(VitalsSimplification.VitalsChecker.VitalsAreOk(151, 92, 94)); //(0,1,1)
            ExpectFalse(VitalsSimplification.VitalsChecker.VitalsAreOk(72, 80, 92));  //(1,0,1)
            ExpectFalse(VitalsSimplification.VitalsChecker.VitalsAreOk(80, 92, 20)); //(1,1,0)
            ExpectFalse(VitalsSimplification.VitalsChecker.VitalsAreOk(80, 92, 100)); //(1,1,0)
            ExpectTrue(VitalsSimplification.VitalsChecker.VitalsAreOk(70, 92, 95));  //(1,1,1)
            ExpectTrue(VitalsSimplification.VitalsChecker.VitalsAreOk(150, 90, 30));  //(1,1,1)

            Console.WriteLine("All ok");
            return 0;
           
        }
    }
}
