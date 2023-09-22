using MinervaCyclingMobileApp.Views;
using MinervaCyclingMobileApp.Views.SignUp;
using MinervaCyclingMobileApp.Views.WarrantyCertification;

namespace MinervaCyclingMobileApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
		Routing.RegisterRoute(nameof(NameAndDobPage), typeof(NameAndDobPage));
		Routing.RegisterRoute(nameof(EmailAndBdayPage), typeof(EmailAndBdayPage));
		Routing.RegisterRoute(nameof(CreatePasswordPage), typeof(CreatePasswordPage));
		Routing.RegisterRoute(nameof(ForgotPasswordPage), typeof(ForgotPasswordPage));
		Routing.RegisterRoute(nameof(WarrantyCertificationTypePage), typeof(WarrantyCertificationTypePage));
		Routing.RegisterRoute(nameof(CreateNewCertificationPage), typeof(CreateNewCertificationPage));
	}
}