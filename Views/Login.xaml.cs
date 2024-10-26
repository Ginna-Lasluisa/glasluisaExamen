public partial class LoginPage : ContentPage
{
    private readonly Dictionary<string, string> users = new()
    {
        { "estudiante2024", "uisrael2024" },
        { "examen1", "parcial1" },
        { "NombreEstudiante", "2024" }
    };

    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        var username = usernameEntry.Text;
        var password = passwordEntry.Text;

        if (users.TryGetValue(username, out var correctPassword) && correctPassword == password)
        {
            await Navigation.PushAsync(new Registro(username));
        }
        else
        {
            await DisplayAlert("Error", "Datos incorrectos", "OK");
        }
    }

    private async void OnAboutClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AboutPage());
    }
}
