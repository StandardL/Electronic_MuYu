using Electronic_MuYu.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Electronic_MuYu.Views;

public sealed partial class UndateLogsPage : Page
{
    public UndateLogsViewModel ViewModel
    {
        get;
    }

    public UndateLogsPage()
    {
        ViewModel = App.GetService<UndateLogsViewModel>();
        InitializeComponent();
    }
}
