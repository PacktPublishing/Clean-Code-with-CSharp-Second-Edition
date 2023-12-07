using System;

namespace CH11_CodeRefactoring.RefactoredCode
{
    public class Cat : IPet
    {
        public void Walkies()
        {
            Console.WriteLine("Meow! Mistress is taking me for walk.");
        }
    }
}
