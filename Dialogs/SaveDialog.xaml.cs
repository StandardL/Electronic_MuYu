using Electronic_MuYu.Helpers;
using Electronic_MuYu.Services;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Windows.UI;

namespace Electronic_MuYu.Dialogs;

public sealed partial class SaveDialog : ContentDialog
{
    public SaveDialog()
    {

        this.InitializeComponent();
        IsPrimaryButtonEnabled = false;
    }

    private void SaveDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
    {

    }


}