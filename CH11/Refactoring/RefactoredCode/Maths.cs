namespace CH11_CodeRefactoring.RefactoredCode
{
    internal class Maths
    {
        public T Add<T>(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            return a + b;
        }
    }
}
