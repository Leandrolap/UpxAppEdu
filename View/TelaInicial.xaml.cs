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
            //MediaSource.FromResource("embed://comer.mp3");
            MidiaAudio.IsVisible = true;
            MidiaAudio.Play();
        //MidiaAudio.Source = "embed://comer.mp3";
        
        
        MidiaAudio.IsVisible = false;
        MidiaAudio.Stop();

    }
}