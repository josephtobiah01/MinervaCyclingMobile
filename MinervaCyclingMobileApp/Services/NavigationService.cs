using MinervaCyclingMobileApp.Interfaces;
using MinervaCyclingMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Services
{
    public class NavigationService : INavigationService
    {
        private readonly IServiceProvider _serviceProvider;

        public NavigationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected INavigation Navigation
        {
            get
            {
                if (Shell.Current?.Navigation != null)
                {
                    INavigation navigation = Shell.Current.Navigation;
                    return navigation;
                }
                else
                {
                    INavigation navigation = Application.Current.MainPage.Navigation;
                    return navigation;
                }
            }
        }

        public async Task NavigateTo(string page, Dictionary<string, object> parameter = null)
        {
            var pg = RegisterForNavigation.GetRegistered(page);
            var toPage = (Page)_serviceProvider.GetService(pg);

            if (toPage is not null)
            {
                //Subscribe to the toPage's NavigatedTo event
                toPage.NavigatedTo += Page_NavigatedTo;

                //Get VM of the toPage
                var toViewModel = GetPageViewModelBase(toPage);

                //Call navigatingTo on VM, passing in the paramter
                if (toViewModel is not null)
                    await toViewModel.OnNavigatingTo(parameter);

                //Navigate to requested page
                await Navigation.PushAsync(toPage, true);

                //Subscribe to the toPage's NavigatedFrom event
                toPage.NavigatedFrom += Page_NavigatedFrom;
            }
            else
                throw new InvalidOperationException($"Unable to resolve type {page}");
        }



        public async Task NavigateTo<T>(Dictionary<string, object> parameter = null) where T : Page
        {
            var toPage = ResolvePage<T>();

            if (toPage is not null)
            {
                //Subscribe to the toPage's NavigatedTo event
                toPage.NavigatedTo += Page_NavigatedTo;

                //Get VM of the toPage
                var toViewModel = GetPageViewModelBase(toPage);

                //Call navigatingTo on VM, passing in the paramter
                if (toViewModel is not null)
                    await toViewModel.OnNavigatingTo(parameter);

                //Navigate to requested page
                await Navigation.PushAsync(toPage, true);

                //Subscribe to the toPage's NavigatedFrom event
                toPage.NavigatedFrom += Page_NavigatedFrom;


            }
            else
                throw new InvalidOperationException($"Unable to resolve type {typeof(T).FullName}");
        }


        private async void Page_NavigatedFrom(object? sender, NavigatedFromEventArgs e)
        {
            //To determine forward navigation, we look at the 2nd to last item on the NavigationStack
            //If that entry equals the sender, it means we navigated forward from the sender to another page
            bool isForwardNavigation = Navigation.NavigationStack.Count > 1
                && Navigation.NavigationStack[^2] == sender;

            if (sender is Page thisPage)
            {
                if (!isForwardNavigation)
                {
                    thisPage.NavigatedTo -= Page_NavigatedTo;
                    thisPage.NavigatedFrom -= Page_NavigatedFrom;
                }

                await CallNavigatedFrom(thisPage, isForwardNavigation);
            }
        }

        private ViewModelBase? GetPageViewModelBase(Page? p)
       => p?.BindingContext as ViewModelBase;

        private T? ResolvePage<T>() where T : Page
            => _serviceProvider.GetService<T>();

        private Task CallNavigatedFrom(Page p, bool isForward)
        {
            var fromViewModel = GetPageViewModelBase(p);

            if (fromViewModel is not null)
                return fromViewModel.OnNavigatedFrom(isForward);
            return Task.CompletedTask;
        }

        private async void Page_NavigatedTo(object? sender, NavigatedToEventArgs e)
            => await CallNavigatedTo(sender as Page);

        private Task CallNavigatedTo(Page? p)
        {
            var fromViewModel = GetPageViewModelBase(p);

            if (fromViewModel is not null)
                return fromViewModel.OnNavigatedTo();
            return Task.CompletedTask;
        }

        public async Task GoBack()
        {
            await Navigation.PopAsync();
        }
    }

    public static class RegisterForNavigation
    {
        private static Dictionary<string, Type> _pages = new Dictionary<string, Type>();
        public static void Register<TView>() where TView : Page
        {
            _pages.Add(typeof(TView).Name, typeof(TView));
        }

        public static Type GetRegistered(string name)
        {
            return _pages.FirstOrDefault(x => x.Key == name).Value;
        }
    }
}

