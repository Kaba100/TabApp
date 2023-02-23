using TabApp.Pages;

namespace TabApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("MessagePage",typeof(MessagePage));
	}
}
