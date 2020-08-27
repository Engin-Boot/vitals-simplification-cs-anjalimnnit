using System;

class VitalsChecker
{
     static bool vitalsAreOk(float bpm, float spo2, float respRate) {
       return ((checkbpm(bpm)&&checkspo2(spo2)&&checkrespRate(respRate))? true : false);
    }
    static bool checkbpm(float bpm)
    { 
         return ((bpm < 70 || bpm > 150) ? false : true);

    }
    static bool checkspo2(float spo2)
    { 
         return ((spo2 < 90) ? false : true );
        
    }static bool checkrespRate(float respRate)
    { 
         return ((respRate < 30 || respRate > 95) ?false:true);
            
    }
}