using System;

namespace CH11_CodeRefactoring.RefactoredCode
{
    internal class Maths
    {
        public T Add<T>(T x, T y) where T : struct // Add a value type constraint, assuming you only want to support only value types
        {
            // Ensure that T supports the + operator
            if (typeof(T).GetMethod("op_Addition") == null)
            {
                throw new InvalidOperationException("Type T must support the + operator.");
            }

            return (dynamic)x + (dynamic)y;
        }
    }
}
