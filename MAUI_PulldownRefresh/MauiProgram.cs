using Microsoft.Extensions.Logging;
using MAUI_PulldownRefresh.Data;
using MAUI_PulldownRefresh.PulldownRefresh;

namespace MAUI_PulldownRefresh;

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
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<WeatherForecastService>();

		// DI for the RefreshPage service
        builder.Services.AddSingleton<RefreshPage>();

        return builder.Build();
	}
}
