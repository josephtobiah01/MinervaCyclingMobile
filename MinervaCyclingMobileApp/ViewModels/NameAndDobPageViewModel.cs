using MinervaCyclingMobileApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.ViewModels
{
    public class NameAndDobPageViewModel : ViewModelBase
    {

        #region Fields

        private readonly INavigationService _navigationService;

        #endregion Fields

        #region Properties


        public Command GoBack { get; set; }





        #endregion Properties

        #region Constructor

        public NameAndDobPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            GoBack = new Command(GoBackCommand);
        }



        #endregion Constructor

        #region Methods

        private void GoBackCommand()
        {
            _navigationService.GoBack();
        }


        #endregion Methods

    }

}

