using System;
using System.Collections.Concurrent;

namespace ConsoleApp102.Utils
{
   public abstract class Logger
    {
        

        protected void Enqueue(string message)
        {
            Entries.Enqueue(message);
        }

       protected static ConcurrentQueue<string> Entries = new ConcurrentQueue<string>();
    }
}