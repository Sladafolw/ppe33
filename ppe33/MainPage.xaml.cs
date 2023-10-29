using MetroLog.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Hosting;

namespace ppe33;

public partial class MainPage : ContentPage
{
    ILogger<MainPage> logger;

    public MainPage(ILogger <MainPage> _logger )
	{
		InitializeComponent();
        logger= _logger;
        BindingContext=new LogController();
        DeviceDisplay.Current.MainDisplayInfoChanged += Current_MainDisplayChanged;
    }

    private void Current_MainDisplayChanged(object sender, DisplayInfoChangedEventArgs e)
    {
        if (DeviceDisplay.MainDisplayInfo.Orientation == DisplayOrientation.Landscape)
        {
            Image.Source = "dotnet_bot.svg";
            logger.LogInformation($"DisplayOrientation Landscape");

        }
        if (DeviceDisplay.MainDisplayInfo.Orientation == DisplayOrientation.Portrait)
        {
            Image.Source = "sdsa.svg";
            logger.LogInformation($"DisplayOrientation Portrait");

        }
    }
    private void Green_OnClicked(object sender, EventArgs e)
    {
        BackgroundColor = Colors.Green;
        Label.Text = $"{ppe33.Resources.AppResources.Hello} {Green.Text}";
        Label.IsVisible = true;
        logger.LogInformation($"Button clicked Green");
        
    }

    private void Red_OnClicked(object sender, EventArgs e)
    {
        BackgroundColor = Colors.Red;
        Label.Text = $"{ppe33.Resources.AppResources.Hello} {Red.Text}";
        Label.IsVisible = true;
        logger.LogInformation($"Button clicked Red");
    }

    private void Blue_OnClicked(object sender, EventArgs e)
    {
        BackgroundColor = Colors.Blue;
        Label.Text = $"{ppe33.Resources.AppResources.Hello} {Blue.Text}";
        Label.IsVisible = true;
        logger.LogInformation($"Button clicked Blue");
    }

    private void Im_Clicked(object sender, EventArgs e)
    {
        Image.Source = "dsdf.svg";
        logger.LogInformation($"Image button clicked");
    }
}

