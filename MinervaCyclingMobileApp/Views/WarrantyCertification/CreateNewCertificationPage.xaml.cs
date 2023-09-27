using MinervaCyclingMobileApp.ViewModels.WarrantyCertification;

namespace MinervaCyclingMobileApp.Views.WarrantyCertification;

public partial class CreateNewCertificationPage : ContentPage
{
	public CreateNewCertificationPage(CreateNewCertificationPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}

    
}