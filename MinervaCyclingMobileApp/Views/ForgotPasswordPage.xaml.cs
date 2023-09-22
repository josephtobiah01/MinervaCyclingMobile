using MinervaCyclingMobileApp.ViewModels;

namespace MinervaCyclingMobileApp.Views;

public partial class ForgotPasswordPage : ContentPage
{
	public ForgotPasswordPage(ForgotPasswordPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}