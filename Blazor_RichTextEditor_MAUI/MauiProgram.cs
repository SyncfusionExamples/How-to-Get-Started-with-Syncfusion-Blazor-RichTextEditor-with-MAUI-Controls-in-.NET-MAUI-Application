using Blazor_RichTextEditor_MAUI.Data;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using Syncfusion.Maui.Core.Hosting;

namespace Blazor_RichTextEditor_MAUI
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Services.AddSyncfusionBlazor();
            builder.ConfigureSyncfusionCore();
            builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<WeatherForecastService>();

            return builder.Build();
        }
    }
}