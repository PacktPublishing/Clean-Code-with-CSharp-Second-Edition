using System;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace CH12_Async
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Create some sample data
            int[] data = new int[10];
            Random random = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(1, 100);
            }

            // Create the dataflow blocks
            var multiplyByTwo = new TransformBlock<int, int>(x => x * 2);
            var addFive = new TransformBlock<int, int>(x => x + 5);
            var printResult = new ActionBlock<int>(x => Console.WriteLine(x));

            // Link the blocks together
            var options = new DataflowLinkOptions { PropagateCompletion = true };
            multiplyByTwo.LinkTo(addFive, options);
            addFive.LinkTo(printResult, options);

            // Post data to the first block
            foreach (var item in data)
            {
                multiplyByTwo.Post(item);
            }

            // Mark the first block as complete
            multiplyByTwo.Complete();

            // Wait for the last block to complete
            await printResult.Completion;

            // Print a message
            Console.WriteLine("Dataflow completed.");
        }
    }
}