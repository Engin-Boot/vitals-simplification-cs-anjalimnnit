using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitalSimplification
{
    class RangeChecker
    {
        private float lowerLimit;
        private float upperLimit;
        private string name;

       public RangeChecker(String name, float lowerLimit, float upperLimit)
        {
            this.name = name;
            this.lowerLimit = lowerLimit;
            this.upperLimit = upperLimit;

        }
        public bool CheckRange(float input)
        {

            if (input < this.lowerLimit)
            {
                VitalSimplification.Alert.Display(this.name, "low");
                return false;

            }
            if (input > this.upperLimit)
            {
                VitalSimplification.Alert.Display(this.name, "high");
                return false;
            }
            return true;

        }
    }
}
