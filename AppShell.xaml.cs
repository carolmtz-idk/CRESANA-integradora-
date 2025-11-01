namespace CRESANA;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute("login", typeof(CRESANA.Views.LoginPage));
        Routing.RegisterRoute("main", typeof(CRESANA.Views.MainPage));
    }
}
