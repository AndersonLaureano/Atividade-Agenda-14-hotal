namespace MauiAppHotel.Views
{
    public partial class Experiencias : ContentPage
    {
        public Experiencias()
        {
            InitializeComponent();
        }

        private async void Voltar_Clicked(
            object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}