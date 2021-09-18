using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ConsoleApp102
{
     interface IProducer
    {
        void Produce(ref ConcurrentBag<string> queue);
    }
}