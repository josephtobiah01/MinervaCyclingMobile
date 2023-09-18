using MinervaCyclingMobileApp.Interfaces;
using MinervaCyclingMobileApp.Views.SignUp;

namespace MinervaCyclingMobileApp.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        #region Fields

        private readonly INavigationService _navigationService;
        private readonly IAuthenticationService _authenticationService;
        private string _email;
        private string _password;
        

        #endregion Fields

        #region Properties

        public Command SignUp { get; set; }
        public Command Login { get; set; }
        public string Email
        {
            get { return _email; }
            set { SetPropertyValue(ref _email, value); }
        }

        public string Password
        {
            get { return _password; }
            set { SetPropertyValue(ref _password, value); }
        }

        #endregion Properties

        #region Constructor

        public LoginPageViewModel(
            INavigationService navigationService,
            IAuthenticationService authenticationService)
        {
            _navigationService = navigationService;
            _authenticationService = authenticationService;

            SignUp = new Command(SignUpCommand);
            Login = new Command(LoginCommand);
            _authenticationService = authenticationService;
        }

        private async void LoginCommand()
        {
            bool isAuthenticated = await _authenticationService.Login(Email, Password);

            if (isAuthenticated)
            {
                await _navigationService.NavigateTo(nameof(NameAndDobPage));
            }
            else
            {
                ShowAlert("Oops", "Your Email or Password is incorrect");
            }
        }


        #endregion Constructor

        #region Methods

        private void SignUpCommand()
        {
            _navigationService.NavigateTo(nameof(NameAndDobPage));
        }
        #endregion Methods
    }
}
