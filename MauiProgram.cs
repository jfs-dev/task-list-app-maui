using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using task_list_app_maui.ViewModels;
using task_list_app_maui.Views;

namespace task_list_app_maui;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<TarefasViewModel>();
		
		builder.Services.AddSingleton<TarefasPendentesView>();
		builder.Services.AddSingleton<TarefasConcluidasView>();

		return builder.Build();
	}
}
