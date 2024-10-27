using Microsoft.Maui.Controls;

namespace glasluisaExamen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Establece la página principal de la aplicación como una NavigationPage
            MainPage = new NavigationPage(new Views.Login());
        }
    }
}
