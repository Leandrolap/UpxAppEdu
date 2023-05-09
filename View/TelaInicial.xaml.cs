using CommunityToolkit.Maui.Core.Primitives;
using CommunityToolkit.Maui.Views;

namespace UpxAppEdu.View;

public partial class TelaInicial : ContentPage
{
	public TelaInicial()
	{
		InitializeComponent();
    }

    private void OnItemConfiguracoes(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Configuracoes());
    }

    private void OnClikedFood(object sender, EventArgs e)
    {
        MidiaAudio.Stop();
        if (MidiaAudio.CurrentState == MediaElementState.Stopped || MidiaAudio.CurrentState == MediaElementState.Paused)
        {
            MidiaAudio.Play();
        }
    }

    private void OnClikedLigar(object sender, EventArgs e)
    {
        MidiaAudio1.Stop();
        if (MidiaAudio1.CurrentState == MediaElementState.Stopped || MidiaAudio1.CurrentState == MediaElementState.Paused)
        {
            MidiaAudio1.Play();
        }
    }

    private void OnClikedAgua(object sender, EventArgs e)
    {
        MidiaAudio2.Stop();
        if (MidiaAudio2.CurrentState == MediaElementState.Stopped || MidiaAudio2.CurrentState == MediaElementState.Paused)
        {
            MidiaAudio2.Play();
            
        }
    }
}