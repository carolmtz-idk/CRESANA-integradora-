using CRESANA.Services;
using CRESANA.Views;

namespace CRESANA;

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
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Servicios
        builder.Services.AddSingleton<FirebaseService>();

        // Páginas (transient para que refresquen datos al volver)
        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<PatientsListPage>();
        builder.Services.AddTransient<PatientFormPage>();

        return builder.Build();
    }
}
