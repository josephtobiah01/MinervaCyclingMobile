using MinervaCyclingMobileApp.ViewModels.SignUp;

namespace MinervaCyclingMobileApp.Views.SignUp;

public partial class NameAndDobPage : ContentPage
{
	public NameAndDobPage(NameAndDobPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}

}