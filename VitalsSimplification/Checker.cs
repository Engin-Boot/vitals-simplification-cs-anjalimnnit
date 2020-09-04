using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VitalsSimplification
{
    class Checker
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
        static void Main(string[] args)
        {
            RangeChecker BpmRange = new VitalsSimplification.RangeChecker("Bpm", 70, 150);
        /*    ExpectFalse(BpmRange.CheckRange(66));
            ExpectFalse(BpmRange.CheckRange(160));
            ExpectTrue(BpmRange.CheckRange(75));*/
            RangeChecker RespRateRange = new VitalsSimplification.RangeChecker("RespRate", 30, 95);
         /*   ExpectFalse(RespRateRange.CheckRange(25));
            ExpectFalse(RespRateRange.CheckRange(100));
            ExpectTrue(RespRateRange.CheckRange(45)); */
            RangeChecker Spo2Range = new VitalsSimplification.RangeChecker("Spo2", 90);
         /*   ExpectFalse(Spo2Range.CheckRange(85));
            ExpectTrue(Spo2Range.CheckRange(100)); */
            ExpectTrue(VitalsChecker.VitalsAreOk(BpmRange.CheckRange(71), RespRateRange.CheckRange(40), Spo2Range.CheckRange(97)));  //(1,1,1)
            Console.WriteLine("Vitals are Ok");
            ExpectFalse(VitalsChecker.VitalsAreOk(BpmRange.CheckRange(69), RespRateRange.CheckRange(40), Spo2Range.CheckRange(97)));  //(0,1,1)
            ExpectFalse(VitalsChecker.VitalsAreOk(BpmRange.CheckRange(152), RespRateRange.CheckRange(40), Spo2Range.CheckRange(97)));  //(0,1,1)
            ExpectFalse(VitalsChecker.VitalsAreOk(BpmRange.CheckRange(71), RespRateRange.CheckRange(25), Spo2Range.CheckRange(97)));  //(1,0,1)
            ExpectFalse(VitalsChecker.VitalsAreOk(BpmRange.CheckRange(71), RespRateRange.CheckRange(100), Spo2Range.CheckRange(97)));  //(1,0,1)
            ExpectFalse(VitalsChecker.VitalsAreOk(BpmRange.CheckRange(80), RespRateRange.CheckRange(90), Spo2Range.CheckRange(80)));  //(1,1,0)
            ExpectFalse(VitalsChecker.VitalsAreOk(BpmRange.CheckRange(69), RespRateRange.CheckRange(20), Spo2Range.CheckRange(80)));  //(0,0,0)
            
           
        }
    }
}
