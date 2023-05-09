namespace UpxAppEdu.View;

public partial class CadastrarUsuario : ContentPage
{
	public CadastrarUsuario()
	{
		InitializeComponent();
	}

    private async void OnClikedCadastrar(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Login());
    }
}