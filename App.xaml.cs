using UpxAppEdu.View;

namespace UpxAppEdu;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new AppShell();
    }
}
