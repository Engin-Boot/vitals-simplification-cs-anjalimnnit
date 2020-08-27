using System;

class VitalsChecker
{
     public static bool vitalsAreOk(float bpm, float spo2, float respRate) {
       return !(checkbpm(bpm)||checkspo2(spo2)||checkrespRate(respRate));
    }
    static bool checkbpm(float bpm)
    { 
         if(bpm < 70)
         {  
             console.WriteLine("Beat per heart is less than 70");
             return true;
         } 
         if( bpm > 150)
    {   console.WriteLine("Beat per heart is greater than 150");
        return true;
        
    }
    return false;

    }
    static bool checkspo2(float spo2)
    { 
         if(spo2 < 90)
         { console.WriteLine("Oxygen Saturation level is less than 90");
         return true;
        
         }
         return false;
        
    }static bool checkrespRate(float respRate)
    { 
         if(respRate < 30)
         {
              console.WriteLine("Respiration Rate level is less than 30");
            return true;
         } 
         if(respRate > 95)
         {
              console.WriteLine("Respiration Rate  level is greater than 95");
              return true;
         }
         return false;
            
    }
}