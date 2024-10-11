namespace Hafta_3_Kontroller
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage =  new NavigationPage(new LoginPage()); //AppShell();
        }
    }
}
