using WeatherApp.ViewModel;

namespace WeatherApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		this.BindingContext = new MainViewModel();
	}
}

