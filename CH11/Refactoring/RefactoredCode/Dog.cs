using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH11_CodeRefactoring.RefactoredCode
{
    internal class Dog : IPet
    {
        public void Walkies()
        {
            Console.WriteLine("Woof, woof! Master's taking me walkies.");
        }
    }
}
