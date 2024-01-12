using Proiect.Models;
namespace Proiect;

public partial class EventEntryPage : ContentPage
{
	public EventEntryPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetEventsAsync();
    }
    async void OnEventAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EventPage
        {
            BindingContext = new Event()
        });
    }
    async void OnListViewItemSelected(object sender,
   SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new EventPage
            {
                BindingContext = e.SelectedItem as Event
            });
        }
    }

}