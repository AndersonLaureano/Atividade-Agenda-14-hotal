namespace MauiAppHotel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Abrir tela de contratação
        private async void Reservar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(
                new Views.ContratacaoHospedagem()
            );
        }

        // Abrir tela de quartos disponíveis
        private async void Quartos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(
                new Views.QuartosDisponiveis()
            );
        }

        // Abrir tela de experiências do hotel
        private async void Experiencias_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(
                new Views.Experiencias()
            );
        }
    }
}