using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH11_CodeRefactoring.RefactoredCode
{
    public class Adaptee
    {
        public void AdapteeOperation()
        {
            Console.WriteLine($"AdapteeOperation() has just executed.");
        }
    }
}
