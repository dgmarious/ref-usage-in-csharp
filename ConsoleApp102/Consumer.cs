﻿using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ConsoleApp102
{
    class Consumer :IConsumer
    {
        private readonly Logger _logger;

        public Consumer(Logger loger)
        {
            _logger = loger;
        }


        /// <summary>
        /// Initializes the queue and start consuming from it. If we did not pass the queue by reference, the consumer class would maintain new instance of the queue which will eventually be empty
        /// </summary>
        /// <param name="queue"></param>
        /// <returns></returns>
        public Task Consume(ref ConcurrentBag<string> queue)
        {
            queue = new ConcurrentBag<string>();
            while (true)
            {


                if (queue.IsEmpty)
                {
                    _logger.Log("Waiting for producer...", "Consumer");
                    Task.Delay(1000).Wait();
                   continue;

                }

                queue.TryTake(out var produced);

                _logger.Log(produced,"Consumer");
               
                
            }

        }
    }
}