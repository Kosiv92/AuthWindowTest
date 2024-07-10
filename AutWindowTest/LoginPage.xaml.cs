
namespace AutWindowTest;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}        

    /// <summary>
    /// Переход на основную страницу приложения
    /// </summary>
	private void RedirectToMainPage()
	{
		var newMainPage = new MainPage();		
		App.Current.MainPage.Navigation.PushAsync(newMainPage);
        NavigationPage.SetHasNavigationBar(newMainPage, false);
        NavigationPage.SetHasBackButton(newMainPage, false);
		SetWindowsProperties(App.Current.MainPage.GetParentWindow());
	}    

    /// <summary>
    /// Изменение размеров окна программы
    /// </summary>
    /// <param name="window"></param>
    private void SetWindowsProperties(Window window)
    {
        var displayInfo = DeviceDisplay.Current.MainDisplayInfo;
        window.MinimumWidth = 400;
        window.MinimumWidth = 600;
		window.MaximumHeight = int.MaxValue;
        window.MaximumWidth = int.MaxValue;
        window.Height = displayInfo.Height / displayInfo.Density * 0.9;
        window.Width = displayInfo.Width / displayInfo.Density * 0.9;                        
    }
}