using CommunityToolkit.Maui.Core.Primitives;

namespace UpxAppEdu.View;

public partial class Musica : ContentPage
{
	public Musica()
	{
		InitializeComponent();
	}

    private void OnClikedMusic01(object sender, EventArgs e)
    {
        MidiaAudio.Stop();
        if (MidiaAudio.CurrentState == MediaElementState.Stopped || MidiaAudio.CurrentState == MediaElementState.Paused)
        {
            MidiaAudio.Play();
        }
    }
}