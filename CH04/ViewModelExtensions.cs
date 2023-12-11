using System.Linq;

namespace CH4;

public static class ViewModelExtensions
{
    public static decimal GetAmountByName(this ViewModel viewModel, string name)
    {
        return viewModel.ExpenseLines
        .FirstOrDefault(e => e.Name.Equals(name))
        ?.Amount ?? 0m;
    }
}
