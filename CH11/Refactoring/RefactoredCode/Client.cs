using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH11_CodeRefactoring.RefactoredCode
{
    public class Client
    {
        public void Operation()
        {
            Target target = new Adapter();
            target.Operation();
        }
    }
}
