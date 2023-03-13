using Electronic_MuYu.Helpers;

namespace Electronic_MuYu;

public sealed partial class MainWindow : WindowEx
{
    public MainWindow()
    {
        InitializeComponent();

        AppWindow.SetIcon(Path.Combine(AppContext.BaseDirectory, "Assets/SmallTile.scale-100.png"));
        Content = null;
        Title = "AppDisplayName".GetLocalized();
    }
}
