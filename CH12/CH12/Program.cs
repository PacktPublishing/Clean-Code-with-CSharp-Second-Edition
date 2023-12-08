using CH12;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace CH12
{
    internal class Program
    {
        private static Lazy<int> lazyValue = new Lazy<int>(() => ComputeValue());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ImperativeExample();
            FunctionalExample();
            StateExample();
            ImmutableStateExample();
            HighOrderFunctionWithFunctionParametersExample();

            AsyncProcessingExample();

            Shape shape = new Rectangle { Width = 3, Height = 4 };
            double area = CalculateArea(shape);
            Console.WriteLine($"Area: {area}");

            CurriedFunctionExample();
            PartialApplicationExample();

            int number = 5;
            int result = Factorial(number);
            Console.WriteLine($"Factorial of {number} is {result}");
        }

        static void ImperativeExample()
        {
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum of numbers from 1 to 10: " + sum);
        }

        static void FunctionalExample()
        {
            var numbers = Enumerable.Range(1, 10);
            int sum = numbers.Sum();

            Console.WriteLine("Sum of numbers from 1 to 10: " + sum);
        }

        static void StateExample()
        {
            Person person1 = new Person();
            person1.Name = "John";
            person1.Age = 30;
        }

        static void ImmutableStateExample()
        {
            ImmutablePerson person1 = new ImmutablePerson("John", 30);
            ImmutablePerson person2 = person1 with { Age = 31 };
        }

        static void HighOrderFunctionWithFunctionParametersExample()
        {
            // Example usage
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // High-order function: TransformList
            var squaredNumbers = TransformList(numbers, x => x * x);
            // Print the original and transformed lists
            Console.WriteLine("Original numbers: " + string.Join(", ", numbers));
            Console.WriteLine("Squared numbers: " + string.Join(", ", squaredNumbers));
        }

        // High-order function that applies a transformation to each element of a list
        static List<TOutput> TransformList<TInput, TOutput>(List<TInput> inputList, Func<TInput, TOutput> transformFunc)
        {
            // Using LINQ to project each element of the input list using the provided transformation function
            return inputList.Select(transformFunc).ToList();
        }

        public static Func<int, int, int> GetMathOperation(string operation)
        {
            switch (operation)
            {
                case "add":
                    return (a, b) => a + b;
                case "subtract":
                    return (a, b) => a - b;
                case "multiply":
                    return (a, b) => a * b;
                case "divide":
                    return (a, b) => b != 0 ? a / b : throw new ArgumentException("Cannot divide by zero.");
                default:
                    throw new ArgumentException("Invalid operation.");
            }
        }

        public static int PerformOperation(Func<int, int, int> operation, int a, int b)
        {
            return operation(a, b);
        }

        public Option<int> TryParseInt(string input)
        {
            if (int.TryParse(input, out int result))
                return Option<int>.Some(result);
            else
                return Option<int>.None();
        }

        static void FunctionalPipelineExample()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            List<int> result = numbers
                .Where(x => x % 2 == 0)       // Filter out the even numbers
                .Select(x => x * x)           // Transform the remaining numbers into their squares
                .OrderByDescending(x => x)    // Sort the squared numbers in descending order
                .ToList();
        }

        static async Task TplDataFlowParallelDataTransformationExampleAsync()
        {
            // Create a data buffer block to store the input data
            var bufferBlock = new BufferBlock<int>();
            // Create two transform blocks for parallel data transformations
            var transformBlock1 = new TransformBlock<int, string>(async x =>
            {
                // Simulate a time-consuming transformation
                await Task.Delay(100);
                return $"Transform1: {x * 2}";
            });
            var transformBlock2 = new TransformBlock<int, string>(async x =>
            {
                // Simulate another time-consuming transformation
                await Task.Delay(50);
                return $"Transform2: {x + 5}";
            });
            // Create an action block to process the final results
            var actionBlock = new ActionBlock<string>(result =>
            {
                Console.WriteLine(result);
            });
            // Link the blocks to form a pipeline
            var options = new DataflowLinkOptions { PropagateCompletion = true };
            bufferBlock.LinkTo(transformBlock1, options);
            bufferBlock.LinkTo(transformBlock2, options);
            Task.WhenAll(transformBlock1.Completion, transformBlock2.Completion)
                .ContinueWith(_ => actionBlock.Complete());

            // Post data to the buffer block
            for (int i = 1; i <= 10; i++)
            {
                bufferBlock.Post(i);
            }
            // Mark the buffer block as complete
            bufferBlock.Complete();
            // Wait for the pipeline to complete
            await actionBlock.Completion;
            Console.WriteLine("Pipeline completed.");
        }
        
        private static int ComputeValue()
        {
            // Some expensive computation
            Console.WriteLine("Computing the value...");
            return 42;
        }

        static void LazyEvaluation()
        {
            Console.WriteLine("Before accessing the value.");

            // The computation is not executed until we access the Value property.
            int value = lazyValue.Value;

            Console.WriteLine($"Value: {value}");

            // The computation is executed only once, subsequent accesses use the cached result.
            int cachedValue = lazyValue.Value;

            Console.WriteLine($"Cached Value: {cachedValue}");
        }
        public static double CalculateArea(Shape shape)
        {
            switch (shape)
            {
                case Circle circle:
                    return Math.PI * circle.Radius * circle.Radius;
                case Rectangle rectangle:
                    return rectangle.Width * rectangle.Height;
                case Triangle triangle when IsRightAngled(triangle):
                    double s = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
                    return Math.Sqrt(s * (s - triangle.SideA) * (s - triangle.SideB) * (s - triangle.SideC));
                default:
                    throw new ArgumentException("Unsupported shape type.");
            }
        }

        public static bool IsRightAngled(Triangle triangle)
        {
            return Math.Pow(triangle.SideA, 2) + Math.Pow(triangle.SideB, 2) == Math.Pow(triangle.SideC, 2)
                || Math.Pow(triangle.SideB, 2) + Math.Pow(triangle.SideC, 2) == Math.Pow(triangle.SideA, 2)
                || Math.Pow(triangle.SideC, 2) + Math.Pow(triangle.SideA, 2) == Math.Pow(triangle.SideB, 2);
        }

        static void CurriedFunctionExample()
        {
            // Curried function
            Func<int, Func<int, int>> addCurried = x => y => x + y;
            // Usage
            var addWith5 = addCurried(5);
            int result = addWith5(3); // Result: 8
        }

        static void PartialApplicationExample()
        {
            // Original function
            Func<int, int, int> add = (x, y) => x + y;
            // Partial application
            Func<int, int> addWith5 = x => add(x, 5);
            // Usage
            int result = addWith5(3); // Result: 8
        }

        static async Task AsyncProcessingExample()
        {
            List<int> inputNumbers = Enumerable.Range(1, 10).ToList();
            // Async data processing pipeline
            var result = await ProcessDataAsync(inputNumbers,
                async data => await DoubleAsync(data),
                async data => await AddFiveAsync(data),
                async data => await SquareAsync(data)
            );
            Console.WriteLine("Result: " + string.Join(", ", result));
        }

        static async Task<List<int>> ProcessDataAsync(List<int> data, params Func<List<int>, Task<List<int>>>[] processors)
        {
            List<int> result = new List<int>(data);

            foreach (var processor in processors)
            {
                List<Task<List<int>>> processingTasks = new List<Task<List<int>>>();

                processingTasks.Add(processor(result));

                result = (await Task.WhenAll(processingTasks)).SelectMany(list => list).ToList();
            }

            return result;
        }

        static async Task<List<int>> DoubleAsync(List<int> data)
        {
            await Task.Delay(100); // Simulate asynchronous operation
            return data.Select(x => x * 2).ToList();
        }
        static async Task<List<int>> AddFiveAsync(List<int> data)
        {
            await Task.Delay(100); // Simulate asynchronous operation
            return data.Select(x => x + 5).ToList();
        }

        static async Task<List<int>> SquareAsync(List<int> data)
        {
            await Task.Delay(100); // Simulate asynchronous operation
            return data.Select(x => x * x).ToList();
        }

        static int Factorial(int n)
        {
            // Base case
            if (n == 0)
                return 1;

            // Recursive call
            return n * Factorial(n - 1);
        }
    }
} 
