using Electronic_MuYu.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Electronic_MuYu.Views;

public sealed partial class AutoPage : Page
{
    public AutoViewModel ViewModel
    {
        get;
    }

    public AutoPage()
    {
        ViewModel = App.GetService<AutoViewModel>();
        InitializeComponent();
    }

    private void Auto_Knock_Start_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void Auto_Knock_Stop_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void Read_Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void Save_Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }
}
