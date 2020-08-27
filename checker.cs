using System;
using System.Diagnostics;
using VitalsChecker;

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
        Console.WriteLine("All ok");
        return 0;
    }
}
