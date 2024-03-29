using CommunityToolkit.Maui.Core.Primitives;
using CommunityToolkit.Maui.Views;
using UpxAppEdu.Service;

namespace UpxAppEdu.View;

public partial class TelaInicial : ContentPage
{
	public TelaInicial()
	{
		InitializeComponent();

        LblNome.Text = DBLocal.NomedoUsuario;
    }

    private void OnClickedComunicacao(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Interacao());
    }

    private void OnClickSobre(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Sobre());
    }

    private void OnClickRotina(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Rotina());
    }

    private void OnClickAgenda(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Agenda());
    }

    private void OnClickedMusic(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Musica());
    }

    private void OnClickedGame(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Jogo());
    }

    private void OnClickProfile(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Perfil());
    }
}