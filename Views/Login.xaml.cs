using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace glasluisaExamen.Views
{
    public partial class Login : ContentPage
    {
        private readonly Dictionary<string, string> usuarios = new Dictionary<string, string>
        {
            { "estudiante2024", "uisrael2024" },
            { "examen1", "parcial1" },
            { "NombreEstudiante", "2024" }
        };

        public Login()
        {
            InitializeComponent();
        }

        private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (usuarios.TryGetValue(usuario, out string contraseniaCorrecta) && contraseña == contraseniaCorrecta)
            {
                await Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                await DisplayAlert("Error", "Datos incorrectos", "OK");
            }
        }

        private async void btnAcercaDe_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Acercade());
        }
    }
}
