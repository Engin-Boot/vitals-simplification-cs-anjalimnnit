using System;

class VitalsChecker
{
     public static bool vitalsAreOk(float bpm, float spo2, float respRate) {
       return !(checkbpm(bpm)||checkspo2(spo2)||checkrespRate(respRate));
    }
    static bool checkbpm(float bpm)
    { 
         return (bpm < 70 || bpm > 150) ;

    }
    static bool checkspo2(float spo2)
    { 
         if(spo2 < 90)
         return true
         return false;
        
    }static bool checkrespRate(float respRate)
    { 
         return (respRate < 30 || respRate > 95);
            
    }
}