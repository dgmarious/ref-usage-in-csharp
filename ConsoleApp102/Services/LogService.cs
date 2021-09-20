using System;
using ConsoleApp102.Utils;

namespace ConsoleApp102.Services
{
    public  class LogService :  Logger, ILogService
    {


        public void WriteLogs()
        {
            while (true)
            {

                if (!Entries.IsEmpty)
                {
                    Entries.TryDequeue(out var log);

                    Console.WriteLine(log);
                }
                
            }
        }

    }
}
