using UpxAppEdu.Service;

namespace UpxAppEdu.View;

public partial class Perfil : ContentPage
{
	public Perfil()
	{
		InitializeComponent();
		Preenchimento();

    }

	private void Preenchimento()
	{
		TxtNome.Text = DBLocal.NomedoUsuario;
        TxtEmail.Text = DBLocal.Email;

    }
}