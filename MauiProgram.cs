using SkiaSharp.Views.Maui.Controls.Hosting;
using CommunityToolkit.Maui;

namespace UpxAppEdu;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().UseSkiaSharp().ConfigureFonts(fonts =>
        {
            fonts.AddFont("Mairy-Extralight.otf", "MairyExtralight");
            fonts.AddFont("Mairy-Regular.otf", "MairyRegular");
        }).UseMauiCommunityToolkit();
        return builder.Build();
    }
}