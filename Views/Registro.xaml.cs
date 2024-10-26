public partial class Registro : ContentPage
{
    private object monthlyPaymentEntry;

    public string Username { get; private set; }

    public Registro(string username)
    {
        InitializeComponent();
        Username = username;
        BindingContext = this;
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        double initialAmount = Convert.ToDouble(initialAmountEntry.Text);
        double totalCost = 300;
        double payment = (totalCost - (totalCost * 0.15)) / 3 * 1.05;
        monthlyPaymentEntry.Text = payment.ToString("F2");
    }

    private async void OnSummaryClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SummaryPage(/* parámetros necesarios */));
    }
}
