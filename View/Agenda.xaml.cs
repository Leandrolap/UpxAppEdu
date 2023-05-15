using XCalendar.Core.Models;

namespace UpxAppEdu.View;

public partial class Agenda : ContentPage
{
	public Agenda()
	{
		InitializeComponent();

        BindingContext = new MainPageViewModel();
        //DataAtual.Date = DateTime.Now;
    }
}