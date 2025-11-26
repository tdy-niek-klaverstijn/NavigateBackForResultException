namespace UnoApp5.Presentation;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class TestModal : ContentDialog
{
    public TestModal()
    {
        this.InitializeComponent();
    }

    private async void OnGotFocus(object sender, RoutedEventArgs e)
    {
        //if (
        //    sender is Control control
        //    && Enum.TryParse(control.Name, out FocusedSettingsElement focusedElement)
        //    && ((SettingsViewModel)DataContext).Model is SettingsModel viewModel
        //)
        //{
        //    await viewModel.FocusedElement.Update(current => focusedElement, default);
        //}
    }
}
