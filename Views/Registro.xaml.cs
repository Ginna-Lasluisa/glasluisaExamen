using System;
using Microsoft.Maui.Controls;

namespace glasluisaExamen.Views
{
    public partial class Registro : ContentPage
    {
        private string usuarioConectado;
        private object txtNombre;
        private object txtApellido;
        private object pkVA;
        private object datePicker;
        private object pkCiudad;
        private object txtMontoInicial;
        private object txtCuotaMensual;

        public Registro(string usuario)
        {
            InitializeComponent();
            usuarioConectado = usuario;
            lblUsuarioConectado.Text = $"Usuario Conectado: {usuarioConectado}";
        }

        private void btnCalcularPago_Clicked(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMontoInicial.Text, out decimal montoInicial))
            {
                decimal total = 300m;
                decimal porcentajeInicial = 0.15m;
                decimal pagoInicial = total * porcentajeInicial;
                decimal saldoRestante = total - pagoInicial;
                decimal cuota = (saldoRestante * 1.05m) / 3;

                txtCuotaMensual.Text = cuota.ToString("0.00");
            }
            else
            {
                DisplayAlert("Error", "Por favor ingrese un monto válido.", "OK");
            }
        }

        private async void btnVerResumen_Clicked(object sender, EventArgs e)
        {
            var resumen = new Resumen(usuarioConectado, txtNombre.Text, txtApellido.Text, pkVA.SelectedItem?.ToString(), datePicker.Date, pkCiudad.SelectedItem?.ToString(), txtMontoInicial.Text, txtCuotaMensual.Text);
            await Navigation.PushAsync(resumen);
        }
    }
}
