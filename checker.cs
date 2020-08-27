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
        ExpectTrue(VitalsChecker.vitalsAreOk(100, 95, 60));
        ExpectFalse(VitalsChecker.vitalsAreOk(40, 91, 92));
        ExpectFalse(VitalsChecker.vitalsAreOk(151, 92, 100));
        ExpectFalse(VitalsChecker.vitalsAreOk(72, 80, 92));
        ExpectFalse(VitalsChecker.vitalsAreOk(80, 92, 20));
        ExpectFalse(VitalsChecker.vitalsAreOk(80, 92, 100));
		ExpectTrue(VitalsChecker.vitalsAreOk(70, 92, 95));
		ExpectTrue(VitalsChecker.vitalsAreOk(150, 90, 30));

        Console.WriteLine("All ok");
        return 0;
    }
}
