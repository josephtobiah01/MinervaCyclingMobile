using MinervaCyclingMobileApp.ViewModels.SignUp;

namespace MinervaCyclingMobileApp.Views.SignUp;

public partial class EmailAndBdayPage : ContentPage
{
	public EmailAndBdayPage(EmailAndBdayPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}