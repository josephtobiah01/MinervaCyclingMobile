using Microsoft.Extensions.Logging;
using MinervaCyclingMobile.CustomControls;
using MinervaCyclingMobile.Data;
using MinervaCyclingMobile.Platforms;

namespace MinervaCyclingMobile
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
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
                });
            

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<WeatherForecastService>();

            Microsoft.Maui.Handlers.ElementHandler.ElementMapper.AppendToMapping("Classic", (handler, view) =>
            {
                if (view is CustomEntry)
                {
                    CustomEntryMapper.Map(handler, view);
                }
            });

            return builder.Build();
        }
    }
}