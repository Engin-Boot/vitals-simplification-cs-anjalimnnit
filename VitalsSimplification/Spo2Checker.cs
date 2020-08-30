using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalsSimplification
{
    class Spo2Checker
    {
        internal static string vitalName = "SpO2";
        internal static bool Checkspo2(float spo2)
        {
            if (spo2 < 90)
            {
                VitalSimplification.Alert.Display(vitalName, "low");
                return true;

            }
            return false;

        }
    }
}
