using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using MinervaCyclingMobileApp.CustomControls;
using MinervaCyclingMobileApp.Data;
using MinervaCyclingMobileApp.Interfaces;
using MinervaCyclingMobileApp.Services;
using MinervaCyclingMobileApp.ViewModels;
using MinervaCyclingMobileApp.ViewModels.SignUp;
using MinervaCyclingMobileApp.ViewModels.WarrantyCertification;
using MinervaCyclingMobileApp.Views;
using MinervaCyclingMobileApp.Views.SignUp;
using MinervaCyclingMobileApp.Views.WarrantyCertification;
using DevExpress.Maui;

namespace MinervaCyclingMobileApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
                    fonts.AddFont("Roboto-Medium.ttf", "RobotoMedium");
                    fonts.AddFont("Roboto-Thin.ttf", "RobotoThin");
                    fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
                    fonts.AddFont("Roboto-Light.ttf", "RobotoLight");
                    fonts.AddFont("Roboto-Black.ttf", "RobotoBlack");
                    fonts.AddFont("Roboto-Italic.ttf", "RobotoItalic");
                    fonts.AddFont("HelveticaNeue-Regular.otf", "HelveticaNeueRegular");
                    fonts.AddFont("HelveticaNeue-Italic.ttf", "HelveticaNeueItalic");
                    fonts.AddFont("HelveticaNeue67-MediumCondensed.otf", "HelveticaNeueMediumCondesed");
                    fonts.AddFont("HelveticaNeue97-BlackCondensed.otf", "HelveticaNeueBlackCondensed");
                    fonts.AddFont("HelveticaNeue-CondensedBold.ttf", "HelveticaNeueCondesedBold");
                    fonts.AddFont("faregular.ttf", "FAR");
                    fonts.AddFont("fasolid.ttf", "FAS");
                    fonts.AddFont("fabrands.ttf", "FAB");
                })
                .UseDevExpress()
                .ConfigureMauiHandlers((handlers) => 
                {
//#if ANDROID

//                    handlers.AddHandler(typeof(CustomEntry), typeof(MinervaCyclingMobileApp.Platforms.Android.CustomEntryMapper));
//#elif iOS
//                    handlers.AddHandler(typeof(CustomEntry), typeof(MinervaCyclingMobileApp.Platforms.iOS.CustomEntryMapper))

//#endif
                });
                
            

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif


            Microsoft.Maui.Handlers.ElementHandler.ElementMapper.AppendToMapping("Classic", (handler, view) =>
            {
                if (view is CustomEntry)
                {
#if ANDROID
                    Platforms.Android.CustomEntryMapper.Map(handler, view);
#elif iOS
                    Platforms.iOS.CustomEntryMapper.Map(handler, view);
#endif
                }
                else if (view is CustomPicker)
                {
#if ANDROID
                    Platforms.Android.CustomPickerMapper.Map(handler, view);
#elif iOS
                    Platforms.iOS.CustomPickerMapper.Map(handler, view);
#endif
                }
            });


            SetupServices(builder.Services);
            RegisterNavigation();

            builder.Services.AddSingleton<WeatherForecastService>();

            builder.Services.AddTransient<LoginPage>();
            builder.Services.AddTransient<LoginPageViewModel>();
            
            builder.Services.AddTransient<NameAndDobPage>();
            builder.Services.AddTransient<NameAndDobPageViewModel>();

            builder.Services.AddTransient<EmailAndBdayPage>();
            builder.Services.AddTransient<EmailAndBdayPageViewModel>();

            builder.Services.AddTransient<ForgotPasswordPage>();
            builder.Services.AddTransient<ForgotPasswordPageViewModel>();

            builder.Services.AddTransient<CreatePasswordPage>();
            builder.Services.AddTransient<CreatePasswordPageViewModel>();

            builder.Services.AddTransient<WarrantyCertificationTypePage>();
            builder.Services.AddTransient<WarrantyCertificationTypePageViewModel>();

            builder.Services.AddTransient<CreateNewCertificationPage>();
            builder.Services.AddTransient<CreateNewCertificationPageViewModel>();

            return builder.Build();
        }

        private static void SetupServices(IServiceCollection services)
        {
            services.AddSingleton<INavigationService, NavigationService>();
            services.AddSingleton<IAuthenticationService, AuthenticationService>();
            services.AddSingleton<IGetShopsService, GetShopsService>();
            services.AddSingleton<ISelectedImageService, SelectedImageService>();
            services.AddSingleton<IGetBikeIssuesService, GetBikeIssuesService>();
            services.AddSingleton<IGetShopPromosService, GetShopPromosService>();
            services.AddSingleton<IGetRepairCentersService, GetRepairCentersService>();
            services.AddSingleton<IGetCertificationsByUserService, GetCertificationsByUserService>();
            services.AddSingleton<ICreateCertificationService, CreateCertificationService>();
            services.AddSingleton<ICreateRequestService, CreateRequestService>();
            services.AddSingleton<IGetRequestsService, GetRequestsService>();
            services.AddSingleton<ICreateShopOrderService, CreateShopOrderService>();
            services.AddSingleton<IGetOrdersService, GetOrdersService>();
        }


        private static void RegisterNavigation()
        {
            RegisterForNavigation.Register<LoginPage>();
            RegisterForNavigation.Register<NameAndDobPage>();
            RegisterForNavigation.Register<EmailAndBdayPage>();
            RegisterForNavigation.Register<CreatePasswordPage>();
            RegisterForNavigation.Register<ForgotPasswordPage>();
            RegisterForNavigation.Register<WarrantyCertificationTypePage>();
            RegisterForNavigation.Register<CreateNewCertificationPage>();

        }
    }
}