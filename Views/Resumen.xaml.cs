using Microsoft.Maui.Controls;

namespace glasluisaExamen.Views
{
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string apellido, string va, DateTime fecha, string ciudad, string montoInicial, string cuotaMensual)
        {
            InitializeComponent();
            lblUsuarioConectado.Text = usuario;
            lblNombre.Text = nombre;
            lblApellido.Text = apellido;
            lblVA.Text = va;
            lblFecha.Text = fecha.ToShortDateString();
            lblCiudad.Text = ciudad;
            lblMontoInicial.Text = montoInicial;
            lblCuotaMensual.Text = cuotaMensual;

            decimal monto = 300m;
            decimal pagoInicial = monto * 0.15m;
            decimal saldoRestante = monto - pagoInicial;
            decimal total = pagoInicial + ((saldoRestante * 1.05m) * 3);

            lblPagoTotal.Text = total.ToString("0.00");
        }

        private async void btnCerrarSesion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
