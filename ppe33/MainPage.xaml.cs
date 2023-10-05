using Microsoft.Maui.Hosting;

namespace ppe33;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        DeviceDisplay.Current.MainDisplayInfoChanged += Current_MainDisplayChanged;
    }

    private void Current_MainDisplayChanged(object sender, DisplayInfoChangedEventArgs e)
    {
        if (DeviceDisplay.MainDisplayInfo.Orientation == DisplayOrientation.Landscape)
        {
            Image.Source = "ss1.svg";
            const double aspectRatio = 1600 / 1441.0; // Aspect ratio of the original image
            Image.WidthRequest = Math.Max(DeviceDisplay.Current.MainDisplayInfo.Height * aspectRatio, DeviceDisplay.Current.MainDisplayInfo.Width);



        }
        if (DeviceDisplay.MainDisplayInfo.Orientation == DisplayOrientation.Portrait)
        {
            Image.Source = "ss2.svg";
            const double aspectRatio = 1600 / 1441.0; // Aspect ratio of the original image
            Image.WidthRequest = Math.Max(DeviceDisplay.Current.MainDisplayInfo.Height * aspectRatio, DeviceDisplay.Current.MainDisplayInfo.Width);

        }
    }

    private void Green_OnClicked(object sender, EventArgs e)
    {
        BackgroundColor = Colors.Green;
        Label.Text = $"{ppe33.Resources.AppResources.Hello} {Green.Text}";
        Label.IsVisible = true;
    }

    private void Red_OnClicked(object sender, EventArgs e)
    {
        BackgroundColor = Colors.Red;
        Label.Text = $"{ppe33.Resources.AppResources.Hello} {Red.Text}";
        Label.IsVisible = true;
    }

    private void Blue_OnClicked(object sender, EventArgs e)
    {
        BackgroundColor = Colors.Blue;
        Label.Text = $"{ppe33.Resources.AppResources.Hello} {Blue.Text}";
        Label.IsVisible = true;

    }
}

