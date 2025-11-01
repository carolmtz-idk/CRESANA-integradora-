namespace CRESANA;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
        // Forzar login al iniciar:
        Dispatcher.Dispatch(async () =>
        {
            try { await Shell.Current.GoToAsync("//login"); } catch { }
        });
    }
}
