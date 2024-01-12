namespace Proiect;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
		.ConfigureEssentials(essentials =>
         {
             essentials.UseMapServiceToken("ewMTcbWI1W8zTxSoS57t~MqJRJ1vmUhP4mjZxOmoXTQ~At8d0WLdk70A5V8qfLKs7bmU2NQvwbRClMADrIsetKyTwSkW_KwWTlnMpnl9_maT");
         });

        return builder.Build();
	}
}
