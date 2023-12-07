using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH11_CodeRefactoring.RefactoredCode
{
    public class Target
    {
        public virtual void Operation()
        {
            Console.WriteLine("Target.Operation() has executed.");
        }
    }
}
