using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ConsoleApp102
{
    class App
    {
        private readonly IProducer _producer;
        private readonly IConsumer _consumer;
        private readonly ILogService _logService;
        private ConcurrentBag<string> _queue;

        public App(IProducer producer, IConsumer consumer, ILogService logService)
        {
            _producer = producer;
            _consumer = consumer;
            _logService = logService;
        }
        public void Run()
        {
            Task[] tasks = { new Task(()=> _producer.Produce(ref _queue)),new Task(()=> _consumer.Consume(ref _queue)), new Task(() => _logService.WriteLogs()) };


            Parallel.ForEach(tasks, item => item.Start());

            

            Task.Delay(-1).Wait();
        }
    }
}

 
