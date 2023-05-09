namespace UpxAppEdu.View;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void BtnEntrar(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new TelaInicial());
    }

    private async void BtnCadastrar(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new CadastrarUsuario());
    }
}