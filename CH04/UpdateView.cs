using System.Diagnostics;
using System;

namespace CH4;

public class UpdateView
{
    public UpdateView DataContext { get; }

    private readonly DataItem _dataItem;
    private readonly MyEntities _context;
    private TextBox nameTextBox;
    private TextBox DescriptionTextBox;
    public UpdateView(MyEntities context, DataItem dataItem)
    {
        InitializeComponent();
        try
        {
            DataContext = this;
            _dataItem = dataItem;
            _context = context;
            nameTextBox.Text = _dataItem.Name;
            DescriptionTextBox.Text = _dataItem.Description;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            throw;
        }
    }

    private void InitializeComponent()
    {

    }
}