using System;
using System.Diagnostics;

class Checker
{
   
    static void ExpectTrue(bool expression) {
        if(!expression) {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }
    static void ExpectFalse(bool expression) {
        if(expression) {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }
    static int Main() {
        ExpectTrue(VitalsChecker.vitalsAreOk(100, 95, 60)); //(1,1,1,)
        ExpectFalse(VitalsChecker.vitalsAreOk(40, 91, 92)); //(0,1,1)
        ExpectFalse(VitalsChecker.vitalsAreOk(151, 92, 94)); //(0,1,1)
        ExpectFalse(VitalsChecker.vitalsAreOk(72, 80, 92));  //(1,0,1)
        ExpectFalse(VitalsChecker.vitalsAreOk(80, 92, 20)); //(1,1,0)
        ExpectFalse(VitalsChecker.vitalsAreOk(80, 92, 100)); //(1,1,0)
		ExpectTrue(VitalsChecker.vitalsAreOk(70, 92, 95));  //(1,1,1)
		ExpectTrue(VitalsChecker.vitalsAreOk(150, 90, 30));  //(1,1,1)

        Console.WriteLine("All ok");
        return 0;
    }
}
