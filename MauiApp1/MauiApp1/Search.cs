using Microsoft.Maui.Controls;

namespace MauiApp1;

public class Search : SearchHandler
{

    private List<string> items = new List<string>
    {
            "Antipolo",
            "Cainta",
            "Magnolia",
            "Galleria",
            "Manila",
            "Los Banos"
   
    };
    public Search()
    {
        Placeholder = "Search";
    }

    protected override void OnQueryChanged(string oldValue, string newValue)
    {
       
        ItemsSource = null;
    }

    protected override async void OnItemSelected(object item)
    {
        
        await Application.Current.MainPage.DisplayAlert("Info", "Something was selected", "OK");
    }
}
