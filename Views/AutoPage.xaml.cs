using Electronic_MuYu.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace Electronic_MuYu.Views;

public sealed partial class AutoPage : Page
{
    private int counter;
    private string count;

    private bool isRunning;
    public AutoViewModel ViewModel
    {
        get;
    }

    public AutoPage()
    {
        ViewModel = App.GetService<AutoViewModel>();
        InitializeComponent();


        counter = 0;
        count = counter.ToString();
    }


    private async Task UpdateCounterAsync()
    {
        while (isRunning)
        {
            counter++;
            count = counter.ToString();
            GongDe_Counter.Text = count;
            await Task.Delay(1250); // 1秒的延迟
        }
    }
    private async void Auto_Knock_Start_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        if (!isRunning)
        {
            isRunning = true;
            await UpdateCounterAsync();
        }
    }

    private void Auto_Knock_Stop_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        if (isRunning)
        {
            isRunning = false;
        }
    }

    private void Read_Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }

    private void Save_Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {

    }
}
