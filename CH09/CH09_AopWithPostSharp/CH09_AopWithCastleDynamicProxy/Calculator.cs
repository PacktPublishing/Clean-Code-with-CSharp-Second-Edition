using System;

namespace CH09_AopWithCastleDynamicProxy
{
    public class Calculator
    {
        public virtual int Add(int a, int b)
        {
            Console.WriteLine("Adding numbers");
            return a + b;
        }
    }
}
