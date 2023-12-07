using CrossCuttingConcerns.Exceptions;
using CrossCuttingConcerns.Instrumentation;
using CrossCuttingConcerns.ResourcePooling;
using CrossCuttingConcerns.Security;

using static CrossCuttingConcerns.Configuration.Settings;

namespace TestHarness
{
    internal class Program
    {
        private static readonly ConcreteDecorator ConcreteDecorator = new ConcreteDecorator(new ConcreteSecureComponent());

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //var harness = new TestClass();
            //Console.WriteLine(harness.GetCachedItem());
            //Console.WriteLine(harness.GetCachedItem());
            //Thread.Sleep(TimeSpan.FromSeconds(1));
            //Console.WriteLine(harness.GetCachedItem());

            new Credentials("End", "User");
            DoSecureWork();

            //var pool = new ResourcePool<Course>(() => new Course());
            //var course = pool.Get();
            //pool.Return(course);

            //Console.WriteLine(GetAppSetting("Greeting"));
            //"Greeting".SetAppSettings("Goodbye, my friends!");
            //Console.WriteLine(GetAppSetting("Greeting"));

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void DoSecureWork()
        {
            AddData();
        }

        [ExceptionAspect]
        private static void AddData()
        {
            ConcreteDecorator.AddData("Hello, world!");
        }
    }
}