namespace Hafta_3_Kontroller;

public partial class LoginPage : ContentPage
{
    private void Button_Clicked(object sender, EventArgs e)
    {
        //if (!......)
        //{
        //	return ;
        //}

        App.Current.MainPage = new AppShell();
    }


    private void Kaydolma_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RegistrationPage());
    }
}