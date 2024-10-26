public partial class SummaryPage : ContentPage
{
    public SummaryPage()
    {
        InitializeComponent();
        // Asignar datos a los bindings
    }

    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync(); // Vuelve a la ventana de login
    }
}
