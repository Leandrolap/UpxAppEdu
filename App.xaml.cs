using UpxAppEdu.View;

namespace UpxAppEdu;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        /*MainPage = new NavigationPage(new Login())
        {
            BarTextColor = Color.FromRgb(255, 255, 255),
            BarBackgroundColor = Color.FromArgb("#6495ED")
        };*/

        MainPage = new Login();
    }
}
