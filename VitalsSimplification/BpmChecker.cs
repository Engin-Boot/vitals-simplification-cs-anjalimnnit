using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalsSimplification
{
    class BpmChecker
    {
       internal static string vitalName = "BeatPerMinute"; 
      internal static bool Checkbpm(float bpm)
        {
            if (bpm < 70)
            {
                VitalSimplification.Alert.Display(vitalName, "low");
                return true;
            }
            if (bpm > 150)
            {
                VitalSimplification.Alert.Display(vitalName, "high");
                return true;

            }
            return false;

        }
    }
}
