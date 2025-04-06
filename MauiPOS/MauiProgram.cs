using CommunityToolkit.Maui;
using MauiPOS.Data; 
using MauiPOS.Repositories; 
using Microsoft.Extensions.Logging;

namespace MauiPOS;

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
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif
		builder.Services
			   .AddSingleton<DatabaseService>()
			   .AddSingleton<MainPage>();
        builder.Services.AddSingleton<DatabaseService>();
        builder.Services.AddSingleton<MenuItemsRepository>();
        builder.Services.AddSingleton<HomeRepository>();
        builder.Services.AddSingleton<OrdersRepository>();
        builder.Services.AddSingleton<SettingsRepository>();
        return builder.Build();
	}
}
