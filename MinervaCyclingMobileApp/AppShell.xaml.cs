using MinervaCyclingMobileApp.Views;
using MinervaCyclingMobileApp.Views.SignUp;

namespace MinervaCyclingMobileApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
		Routing.RegisterRoute(nameof(NameAndDobPage), typeof(NameAndDobPage));	
	}
}