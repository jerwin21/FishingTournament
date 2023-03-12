using CommunityToolkit.Maui;
using FishingTournamentApp.ViewModels;
using FishingTournamentApp.Views;
using Syncfusion.Maui.Core.Hosting;

namespace FishingTournamentApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});


        builder.Services.AddSingleton<MyTournamentsViewModel>();
		builder.Services.AddSingleton<MyTournamentsView>();
        builder.Services.AddSingleton<UserTournamentViewModel>();
        builder.Services.AddSingleton<UserTournamentView>();

		return builder.Build();
	}
}
