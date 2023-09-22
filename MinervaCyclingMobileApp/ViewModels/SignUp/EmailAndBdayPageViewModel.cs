using MinervaCyclingMobileApp.Interfaces;
using MinervaCyclingMobileApp.Views.SignUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.ViewModels.SignUp
{
    public class EmailAndBdayPageViewModel : ViewModelBase
    {
        #region Fields

        private readonly INavigationService _navigationService;

        

        #endregion Fields

        #region Properties

        public Command GoBack { get; set; }
        public Command NextPage { get; set; }

        #endregion Properties

        #region Constructor

        public EmailAndBdayPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            GoBack = new Command(GoBackCommand);
            NextPage = new Command(NextPageCommand);
        }

        

        #endregion Constructor

        #region Methods

        private void GoBackCommand(object obj)
        {
            _navigationService.GoBack();
        }

        private void NextPageCommand(object obj)
        {
            _navigationService.NavigateTo(nameof(CreatePasswordPage));
        }

        #endregion Methods
    }
}
