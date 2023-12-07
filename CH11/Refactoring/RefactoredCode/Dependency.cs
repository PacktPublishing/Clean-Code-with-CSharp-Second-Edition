using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH11_CodeRefactoring.RefactoredCode
{
    public class Dependency : IService
    {
        public void Operation()
        {
            Console.WriteLine("Dependency.Operation() has executed.");
        }
    }
}
