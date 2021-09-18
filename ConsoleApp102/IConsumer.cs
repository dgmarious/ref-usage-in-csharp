using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ConsoleApp102
{
     interface IConsumer
    {
        Task Consume(ref ConcurrentBag<string> queue);
    }
}