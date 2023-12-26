using Proiect.Models;
namespace Proiect;

public partial class ListEntryPage : ContentPage
{
	public ListEntryPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetTicketAsync();
    }
    async void OnTicketAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListPage
        {
            BindingContext = new Ticket()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ListPage
            {
                BindingContext = e.SelectedItem as Ticket
            });
        }
    }

    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var tlist = (Ticket)BindingContext;
        tlist.Date = DateTime.UtcNow;
        await App.Database.SaveTicketAsync(tlist);
        await Navigation.PopAsync();
    }

    async void OnDeleteButtonClicked(object sender,EventArgs e)
    {
        var tlist = (Ticket)BindingContext;
        await App.Database.DeleteTicketAsync(tlist);
        await Navigation.PopAsync();
    }
}