namespace InClassPresTriviaF24.Modules.Views;

public partial class MainMenu : ContentPage
{
	public MainMenu()
	{
		InitializeComponent();
	}

    private void NewGameClicked(object sender, EventArgs e)
    {
		App.Current.MainPage = new Modules.Views.GamePage();
    }

    private void LeaderboardsClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new Modules.Views.LeaderboardsPage();
    }

    private void ExitGameClicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }
}