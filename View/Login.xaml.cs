using UpxAppEdu.Service;

namespace UpxAppEdu.View;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void BtnEntrar(object sender, EventArgs e)
    {
        if (EntryEmail.Text != DBLocal.Email && EntrySenha.Text != DBLocal.Senha)
        {
            await Application.Current.MainPage.DisplayAlert("Atenção", "E-mail ou senha não conferem", "Ok");
            return;
        }
        else

        App.Current.MainPage = new NavigationPage(new TelaInicial());
    }

    private async void BtnCadastrar(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new CadastrarUsuario());
    }
}