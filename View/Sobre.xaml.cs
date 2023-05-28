using CommunityToolkit.Maui.Views;

namespace UpxAppEdu.View;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private void OnClickDev(object sender, EventArgs e)
    {
		this.ShowPopup(new PopupDev());
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }
}