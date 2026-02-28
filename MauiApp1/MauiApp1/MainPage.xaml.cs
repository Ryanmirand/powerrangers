namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Shell.SetSearchHandler(this, new Search());
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Task.Delay(100);
        await myScroll.ScrollToAsync(0, 0, animated: true);
    }
}
