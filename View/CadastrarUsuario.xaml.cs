using UpxAppEdu.Service;

namespace UpxAppEdu.View;

public partial class CadastrarUsuario : ContentPage
{
	public CadastrarUsuario()
	{
		InitializeComponent();
	}

    public async void OnClikedCadastrar(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(EntryNome.Text) && String.IsNullOrEmpty(EntryEmail.Text) && String.IsNullOrEmpty(EntrySenha.Text))
        {
            await Application.Current.MainPage.DisplayAlert("Aten��o", "Existe campos vazios.", "Ok");
            return;
        }
        else if (EntryCSenha.Text != EntrySenha.Text)
        {
            await Application.Current.MainPage.DisplayAlert("Aten��o", "Senhas n�o s�o iguais", "Ok");
            return;
        }
        else
        
            DBLocal.Email = EntryEmail.Text;
            DBLocal.NomedoUsuario = EntryNome.Text;
            DBLocal.Senha = EntrySenha.Text;

         //App.Current.MainPage = new NavigationPage(new Login());
        await Application.Current.MainPage.DisplayAlert("Parab�ns", "Cadastro realizado com sucesso, retorne para a tela de login", "Ok");

            
    }
}