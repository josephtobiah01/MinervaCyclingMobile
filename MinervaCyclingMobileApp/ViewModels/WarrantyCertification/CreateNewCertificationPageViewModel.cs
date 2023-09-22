using DevExpress.Maui.Controls;
using MinervaCyclingMobileApp.Interfaces;
using MinervaCyclingMobileApp.Models.ApiResponse;

namespace MinervaCyclingMobileApp.ViewModels.WarrantyCertification
{
    public class CreateNewCertificationPageViewModel : ViewModelBase
    {
        #region Fields

        private readonly INavigationService _navigationService;
        private readonly IGetShopsService _getShopsService;
        private bool _isOpenShopsSheetOpen;
        private List<string> _shops;

        private BottomSheetState _openShopsSheetState;
        #endregion Fields

        #region Properties

        public Command GoBack { get; set; }
        public Command GetShops { get; set; }
        public Command OpenShopsSheet { get; set; }

        public List<string> Shops
        {
            get { return _shops; }
            set { SetPropertyValue(ref _shops, value); }
        }

        public bool IsOpenShopsSheetOpen
        {
            get { return _isOpenShopsSheetOpen; }
            set { SetPropertyValue(ref _isOpenShopsSheetOpen, value); }
        }

        public BottomSheetState OpenShopsSheetState
        {
            get { return _openShopsSheetState; }
            set { SetPropertyValue(ref _openShopsSheetState, value); }
        }

        #endregion Properties

        #region Constructor

        public CreateNewCertificationPageViewModel(
            INavigationService navigationService,
            IGetShopsService getShopsService)
        {
            _navigationService = navigationService;
            _getShopsService = getShopsService;

            GoBack = new Command(GoBackCommand);
            GetShops = new Command(GetShopsCommand);
            OpenShopsSheet = new Command(OpenShopsSheetCommand);

            Initialize();
        }

        

        #endregion Constructor

        #region Methods

        public void Initialize()
        {
            IsOpenShopsSheetOpen = false;
            OpenShopsSheetState = BottomSheetState.Hidden;
            
        }
        private void GoBackCommand(object obj)
        {
            _navigationService.GoBack();
        }

        private async void OpenShopsSheetCommand()
        {
            IsOpenShopsSheetOpen = true;

            OpenShopsSheetState = BottomSheetState.HalfExpanded;

            List<ShopDetailsResponse.ShopDetails> shopDetailsResponses = await _getShopsService.GetShops();

            Shops = new List<string>(shopDetailsResponses.Select(shop => shop.ShopName));
            
        }

        private void GetShopsCommand(object obj)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}
