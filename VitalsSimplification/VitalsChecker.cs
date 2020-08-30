using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalsSimplification
{
    class VitalsChecker
    {
        internal static bool VitalsAreOk(float bpm, float spo2, float respRate)
        {
            return !(VitalsSimplification.BpmChecker.Checkbpm(bpm) || VitalsSimplification.Spo2Checker.Checkspo2(spo2) || VitalsSimplification.RespRateChecker.CheckrespRate(respRate));
        }

        
    }
}
