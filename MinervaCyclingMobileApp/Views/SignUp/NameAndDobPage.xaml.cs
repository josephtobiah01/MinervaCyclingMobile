using MinervaCyclingMobileApp.ViewModels;

namespace MinervaCyclingMobileApp.Views.SignUp;

public partial class NameAndDobPage : ContentPage
{
	public NameAndDobPage(NameAndDobPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}

}