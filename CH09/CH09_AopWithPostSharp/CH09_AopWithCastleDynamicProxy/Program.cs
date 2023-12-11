using Castle.DynamicProxy;
using System;

namespace CH09_AopWithCastleDynamicProxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a proxy generator
            ProxyGenerator generator = new ProxyGenerator();
            // Create the target object
            Calculator calculator = new Calculator();
            // Create the proxy with the logging aspect
            Calculator proxy = generator.CreateClassProxy<Calculator>(new LoggingAspect());
            // Call the method on the proxy
            int result = proxy.Add(3, 5);
            Console.WriteLine($"Result: {result}");
        }
    }
}
