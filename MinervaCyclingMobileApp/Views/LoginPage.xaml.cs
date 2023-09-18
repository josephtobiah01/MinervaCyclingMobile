using MinervaCyclingMobileApp.ViewModels;
using MinervaCyclingMobileApp.Views.SignUp;

namespace MinervaCyclingMobileApp.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel vm)
	{
		InitializeComponent();
        this.BindingContext = vm;
	}
}