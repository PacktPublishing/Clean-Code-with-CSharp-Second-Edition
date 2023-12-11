using CH4.Validators;

namespace CH4;

public  class ItemsUpdateView
{
    public ItemsUpdateView(Entities context, ItemsView itemView)
    { 
        InitializeComponent();
        ArgumentValidator.NotNull("", itemView);
        // ### implementation omitted ###
    }

    private void InitializeComponent()
    {

    }
}
