namespace UpxAppEdu.View;

public partial class Agenda : ContentPage
{
	public Agenda()
	{
		InitializeComponent();
    }

	private void Calendario()
	{
        DtAgenda.Date = DateTime.Now;

    }
}