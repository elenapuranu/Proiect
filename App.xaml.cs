using System;
using Proiect.Data;
using System.IO;

namespace Proiect;

public partial class App : Application
{
	static TicketListDatabase database;
	public static TicketListDatabase Database
	{
		get
		{
			if (database == null)
			{
				database = new TicketListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Ticket.db3"));
			}
			return database;
		}
	}
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
