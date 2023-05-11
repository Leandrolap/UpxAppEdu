using CommunityToolkit.Maui.Core.Primitives;
using CommunityToolkit.Maui.Views;

namespace UpxAppEdu.View;

public partial class TelaInicial : ContentPage
{
	public TelaInicial()
	{
		InitializeComponent();
    }

    private void OnClickedComunicacao(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Comunicacao());
    }
}