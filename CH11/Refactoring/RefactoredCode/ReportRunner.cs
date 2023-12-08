using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CH11_CodeRefactoring.RefactoredCode
{
    public class ReportRunner
    {
        public void RunReport(Report report)
        {
            var reportName = $"CH11_CodeRefactoring.RefactoredCode.{report}Report";
            var type = Type.GetType(reportName);
            var factory = Activator.CreateInstance(Type.GetType(reportName) ?? throw new InvalidOperationException()) as IReportFactory;
            factory?.Run();
        }
    }
}
