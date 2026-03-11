

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

    private void Button_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Hai", "You clicked on Los Banos", "Okie");
    }
    private void Button2_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Hai", "You clicked on Manila", "Okie");
    }

    private void Button3_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Hai", "You clicked on Galleria", "Okie");
    }

    private void Button4_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Hai", "You clicked on Magnolia", "Okie");
    }

    private void Button5_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Hai", "You clicked on Cainta", "Okie");
    }

    private void Button6_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Hai", "You clicked on Antipolo", "Okie");
    }
}
