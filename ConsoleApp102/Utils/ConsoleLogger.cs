using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp102.Utils
{
     class ConsoleLogger : Logger, ILogger
    { 
        
       public  void Log(object info, [CallerMemberName] string caller = "")
        {
            
                base.Enqueue($"{ caller}: >> { DateTime.Now} | { info}");
             
        }
    }
}