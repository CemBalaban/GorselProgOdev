using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui.Markup;
using CommunityToolkit.Maui;
using GorselProgOdev.Pages;
using GorselProgOdev.ViewModels;


namespace GorselProgOdev
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkitMarkup()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<App>();
            builder.Services.AddSingleton<AppShell>();
            builder.Services.AddTransientWithShellRoute<Hesap, HesapView>($"//{nameof(Hesap)}");

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
