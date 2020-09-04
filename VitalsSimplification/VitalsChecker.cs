using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalsSimplification
{   
    
    class VitalsChecker
    {
        internal static bool VitalsAreOk(bool BpmRange, bool RespRateRange, bool Spo2Range)
        {
            return (BpmRange && RespRateRange && Spo2Range);
        }
        
    }
}
