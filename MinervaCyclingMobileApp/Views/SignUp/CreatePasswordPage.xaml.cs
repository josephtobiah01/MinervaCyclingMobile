using MinervaCyclingMobileApp.ViewModels.SignUp;

namespace MinervaCyclingMobileApp.Views.SignUp;

public partial class CreatePasswordPage : ContentPage
{
	public CreatePasswordPage(CreatePasswordPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}