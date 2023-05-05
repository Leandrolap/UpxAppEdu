using UpxAppEdu.Data;
using UpxAppEdu.Model;

namespace UpxAppEdu.View;

public partial class AddItem : ContentPage
{
	public AddItem()
	{
		InitializeComponent();
	}

    async void OnSaveCliked(object sender, EventArgs e)
    {
        var todoItem = (TodoItem)BindingContext;
        TodoItemDatabase database = await TodoItemDatabase.Instance;
        await database.SaveItemAsync(todoItem);
        await Navigation.PopAsync();
    }

    async void OnDeleteCliked(object sender, EventArgs e)
    {
        var todoItem = (TodoItem)BindingContext;
        TodoItemDatabase database = await TodoItemDatabase.Instance;
        await database.DeleteItemAsync(todoItem);
        await Navigation.PopAsync();

    }

    async void OnCancelarCliked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}