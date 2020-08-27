using System;

class VitalsChecker
{
     public static bool vitalsAreOk(float bpm, float spo2, float respRate) {
       return !(checkbpm(bpm)&&checkspo2(spo2)&&checkrespRate(respRate));
    }
    static bool checkbpm(float bpm)
    { 
         return (bpm < 70 || bpm > 150) ;

    }
    static bool checkspo2(float spo2)
    { 
         return (spo2 < 90);
        
    }static bool checkrespRate(float respRate)
    { 
         return (respRate < 30 || respRate > 95);
            
    }
}