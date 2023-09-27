using DevExpress.Maui.Controls;
using MinervaCyclingMobileApp.Interfaces;
using MinervaCyclingMobileApp.Models.ApiResponse;
using System.Collections.ObjectModel;
using Timers = System.Timers;


namespace MinervaCyclingMobileApp.ViewModels.WarrantyCertification
{
    public class CreateNewCertificationPageViewModel : ViewModelBase
    {
        #region Fields

        private readonly INavigationService _navigationService;
        private readonly IGetShopsService _getShopsService;
        private readonly ISelectedImageService _selectedImageService;
        private bool _isOpenShopsSheetOpen;
        private ObservableCollection<string> _shops;
        private ObservableCollection<string> _originalShopsList;
        private string _datePickerButtonText;
        private DateTime _selectedDate = DateTime.Now;
        private bool _isPopupOpen = false;
        private BottomSheetState _openShopsSheetState;
        private BottomSheetState _openSelectedImageSheetState;
        private string _searchBarText;
        private ImageSource _selectedImage;
        private string _displayedImage;


        #endregion Fields

        #region Properties

        public Command OpenCalendar { get; set; }
        public Command GoBack { get; set; }
        public Command GetShops { get; set; }
        public Command OpenShopsSheet { get; set; }
        public Command SelectedDateChanged { get; set; }
        public Command UploadPhoto { get; set; }
        public Command CapturePhoto { get; set; }

        Timers.Timer SearchTimer = null;    

        public DateTime SelectedDate
        {
            get { return _selectedDate; }
            set { SetPropertyValue(ref _selectedDate, value); }
        }

        public ObservableCollection<string> Shops
        {
            get { return _shops; }
            set { SetPropertyValue(ref _shops, value); }
        }

        public ObservableCollection<string> OriginalShopsList
        {
            get { return _originalShopsList; }
            set { SetPropertyValue(ref _originalShopsList, value); }
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

        public BottomSheetState OpenSelectedImageSheetState
        {
            get { return _openSelectedImageSheetState; }
            set { SetPropertyValue(ref _openSelectedImageSheetState, value); }
        }

        public string DatePickerButtonText
        {
            get { return _datePickerButtonText; }
            set { SetPropertyValue(ref _datePickerButtonText, value); }
        }

        public bool IsPopupOpen
        {
            get { return _isPopupOpen; }
            set { SetPropertyValue(ref _isPopupOpen, value); }
        }

        public string SearchBarText
        {
            get { return _searchBarText; }
            set
            {
                SetPropertyValue(ref _searchBarText, value);
                SearchTimer?.Stop();
                SearchTimer?.Start();
            }
        }

        public ImageSource SelectedImage
        {
            get { return _selectedImage; }
            set { SetPropertyValue(ref _selectedImage, value); }
        }

        private string DisplayedImage
        {
            get { return _displayedImage; }
            set { SetPropertyValue(ref _displayedImage, value); }
        }



        #endregion Properties

        #region Constructor

        public CreateNewCertificationPageViewModel(
            INavigationService navigationService,
            IGetShopsService getShopsService,
            ISelectedImageService selectedImageService)
        {
            _navigationService = navigationService;
            _getShopsService = getShopsService;
            _selectedImageService = selectedImageService;

            GoBack = new Command(GoBackCommand);
            OpenShopsSheet = new Command(OpenShopsSheetCommand);
            SelectedDateChanged = new Command(SelectedDateChangedCommand);
            OpenCalendar = new Command(OpenCalendarCommand);
            UploadPhoto = new Command(UploadPhotoCommand);
            CapturePhoto = new Command(CapturePhotoCommand);
            

            Initialize();
        }

        #endregion Constructor

        #region Methods

        public async void Initialize()
        {
            IsOpenShopsSheetOpen = false;

            OpenShopsSheetState = BottomSheetState.Hidden;

            await SetDate(SelectedDate);

            SearchTimer = new Timers.Timer();
            SearchTimer.Elapsed += SearchTimer_Elapsed;
            SearchTimer.Interval = 1200;

        }

        private void SearchTimer_Elapsed(object sender, Timers.ElapsedEventArgs e)
        {
            SearchCollection();
        }

        private void GoBackCommand(object obj)
        {
            _navigationService.GoBack();
        }

        private void OpenCalendarCommand(object obj)
        {
            IsPopupOpen = true;
        }
        private async void OpenShopsSheetCommand()
        {
            IsOpenShopsSheetOpen = true;

            OpenShopsSheetState = BottomSheetState.HalfExpanded;

            List<ShopDetailsResponse.ShopDetails> shopDetailsResponses = await _getShopsService.GetShops();

            OriginalShopsList = new ObservableCollection<string>(shopDetailsResponses.Select(shop => shop.ShopName));

            Shops = new ObservableCollection<string>(OriginalShopsList);
        }

       

        private void SelectedDateChangedCommand()
        {
            SetDate(SelectedDate);
        }

        public Task SetDate(DateTime? DateInput)
        {

            string formattedDate = string.Empty;

            string numberSuffix = string.Empty;

            string monthShort = string.Empty;

            if (DateInput != null)
            {
                SelectedDate = DateInput.GetValueOrDefault();

                monthShort = SelectedDate.ToString("MMM");

                numberSuffix = GetDayNumberSuffix(SelectedDate);

                formattedDate = string.Format("{0} {1}, {2}", SelectedDate.Day + numberSuffix, monthShort, SelectedDate.DayOfWeek);

                DatePickerButtonText = formattedDate;

                IsPopupOpen = false;
            }


            return Task.CompletedTask;
        }

        private string GetDayNumberSuffix(DateTime date)
        {
            int day = date.Day;

            switch (day)
            {
                case 1:
                case 21:
                case 31:
                    return "st";

                case 2:
                case 22:
                    return "nd";

                case 3:
                case 23:
                    return "rd";

                default:
                    return "th";
            }
        }

        private void SearchCollection()
        {
            try
            {
                if (OriginalShopsList == null) return;

                var searchEntered = SearchBarText;

                if (string.IsNullOrEmpty(searchEntered))
                {
                    foreach (var shop in OriginalShopsList)
                    {
                        if (!Shops.Contains(shop))
                            Shops.Add(shop);
                    }
                }
                else
                {
                    searchEntered = searchEntered.ToLowerInvariant();

                    var filteredItems = OriginalShopsList
                        .Where(x => x != null && x.ToLowerInvariant().Contains(searchEntered))
                        .ToList();


                    Shops = new ObservableCollection<string>(filteredItems);

                }

                OpenShopsSheetState = BottomSheetState.Hidden;
                OpenShopsSheetState = BottomSheetState.HalfExpanded;
            }
            catch(Exception ex)
            {
                ShowAlert("Woops", $"{ex.Message}");
            }
        }

        private async void UploadPhotoCommand()
        {
            var result = await _selectedImageService.UploadPhoto();

            if (result != null)
            {
                SelectedImage = result;
            }

            OpenSelectedImageSheetState = BottomSheetState.HalfExpanded;
        }

        private async void CapturePhotoCommand()
        {
            var result = await _selectedImageService.CapturePhoto();

            if (result != null)
            {
                SelectedImage = result;
            }

            OpenSelectedImageSheetState = BottomSheetState.HalfExpanded;
        }

        #endregion Methods
    }
}
