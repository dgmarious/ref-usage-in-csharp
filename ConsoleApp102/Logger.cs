using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace ConsoleApp102
{
   public abstract class Logger
    {
        public virtual void Log(object info, string caller = "")
        {
            throw new NotImplementedException();
        }

        protected void Enqueue(string message)
        {
            Entries.Enqueue(message);
        }

       protected static ConcurrentQueue<string> Entries = new ConcurrentQueue<string>();
    }
}