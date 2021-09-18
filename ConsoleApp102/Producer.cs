using System.Collections.Concurrent;

namespace ConsoleApp102
{
    class Producer: IProducer

    {
        private readonly Logger _logger;

        public Producer(Logger logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Initializes the queue and continue to add items into it until exit. if the queue was not passed by reference, the producer will maintain a separate instance of the queue and which no consumer can access
        /// </summary>
        /// <param name="queue"></param>
        public void Produce(ref ConcurrentBag<string> queue )
        {
            queue = new ConcurrentBag<string>();


            for (int produced = 0; produced < 1000000; produced++)
            {
               
               
              
                queue.Add(produced.ToString());
              


            }

            _logger.Log("Finished producing", "Producer");
            

        }


    }
}