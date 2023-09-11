using MinervaCyclingMobileApp.Views;

namespace MinervaCyclingMobileApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
	}
}