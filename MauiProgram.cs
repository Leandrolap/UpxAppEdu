using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Plugin.Maui.Audio;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace UpxAppEdu;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkitMediaElement()
            .UseSkiaSharp()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("Mairy-Extralight.otf", "MairyExtralight");
				fonts.AddFont("Mairy-Regular.otf", "MairyRegular");
			});

        builder.Services.AddSingleton(AudioManager.Current);
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
