using UpxAppEdu.Data;
using UpxAppEdu.Model;

namespace UpxAppEdu.View;

public partial class Rotina : ContentPage
{
	public Rotina()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        TodoItemDatabase database = await TodoItemDatabase.Instance;
        listView.ItemsSource = await database.GetItemsAsync();
    }

    async void OnItemAdded(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddItem
        {
            BindingContext = new TodoItem()
        });
    }

    async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new AddItem
            {
                BindingContext = e.SelectedItem as TodoItem
            });
        }
    }
}