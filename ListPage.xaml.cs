using Proiect.Models;
namespace Proiect;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var tlist = (Ticket)BindingContext;
        tlist.Date = DateTime.UtcNow;
        await App.Database.SaveTicketAsync(tlist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var tlist = (Ticket)BindingContext;
        await App.Database.DeleteTicketAsync(tlist);
        await Navigation.PopAsync();
    }
}