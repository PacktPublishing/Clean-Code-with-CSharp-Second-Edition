using Castle.Core.Interceptor;
using System;

namespace CH09_AopWithCastleDynamicProxy
{
    public class LoggingAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine($"Before method {invocation.Method.Name}");

            // Invoke the original method
            invocation.Proceed();

            Console.WriteLine($"After method {invocation.Method.Name}");
        }
    }
}
