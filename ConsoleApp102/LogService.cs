using System;
using System.Threading.Tasks;

namespace ConsoleApp102
{
    public class LogService :  Logger, ILogService
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
