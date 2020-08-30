using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalsSimplification
{
    class RespRateChecker
    {
        internal static string vitalName = "RespRate";
        internal static bool CheckrespRate(float respRate)
        {
            if (respRate < 30)
            {
                VitalSimplification.Alert.Display(vitalName, "low");
                return true;
            }
            if (respRate > 95)
            {
                VitalSimplification.Alert.Display(vitalName, "high");
                return true;
            }
            return false;

        }
    }
}
