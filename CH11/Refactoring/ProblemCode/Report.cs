using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH11_CodeRefactoring.ProblemCode
{
    [Flags]
    public enum Report
    {
        StaffShiftPattern,
        EndofMonthSalaryRun,
        HrStarters,
        HrLeavers,
        EndofMonthSalesFigures,
        YearToDateSalesFigures
    }
}
