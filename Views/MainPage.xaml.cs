using System.Diagnostics;
using ABI.Microsoft.UI.Xaml;
using Electronic_MuYu.Services;
using Electronic_MuYu.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;
using Windows.Media.Core;
using Windows.Media.Playback;

namespace Electronic_MuYu.Views;

public sealed partial class MainPage : Page
{

    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();

        Knock_Sound.MediaPlayer.RealTimePlayback = true; //低延迟模式

        //GongDeNumsOOBE gongDeNumsOOBE = new GongDeNumsOOBE();
        //string totalGongde = string.Empty;
        //gongDeNumsOOBE.ReadGongDe(totalGongde);

        
    }

    private void Knock_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        Knock_Sound.MediaPlayer.Play();

        // 功德计数
        var text = GongDe_Counter.Text;
        var counter = long.Parse(text);
        counter++;
        text = counter.ToString();
        GongDe_Counter.Text = text;
    }

    private void Save_Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        LoadingFileProgressRing.IsActive = true;
        LoadingFileProgressRing.Visibility = Visibility.Visible;
    }

    private void Read_Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        LoadingFileProgressRing.IsActive = false;
        LoadingFileProgressRing.Visibility = Visibility.Collapsed;

        // 从文件中读取
        var totalGongde = string.Empty;
        totalGongde = GongDeNumsOOBE.ReadGongDe().Result.ToString();

        if (totalGongde == "FAILED")
            totalGongde = "读取失败";
        LoadingFileProgressRing.IsActive = false;
        TotalGongDe_Counter.Text = totalGongde;
    }
}
