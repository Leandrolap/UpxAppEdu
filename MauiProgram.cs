using Microsoft.Extensions.Logging;

namespace UpxAppEdu;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("Mairy-Extralight.otf", "MairyExtralight");
				fonts.AddFont("Mairy-Regular.otf", "MairyRegular");
			});

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
