using System;
using Microsoft.Maui.Controls;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCravingFabClicked(object sender, EventArgs e)
    {
        RecommendationResult.IsVisible = false; // reset previous result
        CravingOverlay.IsVisible = true;
    }

    private void OnCloseOverlayClicked(object sender, EventArgs e)
    {
        CravingOverlay.IsVisible = false;
    }

    private void OnFindRestoClicked(object sender, EventArgs e)
    {
        if (CravingPicker.SelectedIndex == -1 || MallPicker.SelectedIndex == -1)
        {
            ResultText.Text = "Please select both options!";
            RecommendationResult.IsVisible = true;
            return;
        }

        string chosenCraving = CravingPicker.SelectedItem.ToString();
        string chosenMall = MallPicker.SelectedItem.ToString();
        string recommendedResto = "";

        if (chosenCraving == "Fried Chicken" || chosenCraving == "Burgers & Fries")
        {
            recommendedResto = $"Jollibee at Robinsons {chosenMall} (Level 1)";
        }
        else if (chosenCraving == "Pizza & Pasta")
        {
            recommendedResto = $"Greenwich at Robinsons {chosenMall} (Level 3)";
        }
        else if (chosenCraving == "Filipino Rice Meals")
        {
            recommendedResto = $"Max's Restaurant at Robinsons {chosenMall} (Level 2)";
        }
        else
        {
            recommendedResto = $"Food Court Hub at Robinsons {chosenMall}";
        }

        ResultText.Text = recommendedResto;
        RecommendationResult.IsVisible = true;
    }
}
