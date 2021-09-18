using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp102
{
     class ConsoleLogger : Logger
    { 
        
       public override void Log(object info, [CallerMemberName] string caller = "")
        {
            
                base.Enqueue($"{ caller}: >> { DateTime.Now} | { info}");
             
        }
    }
}