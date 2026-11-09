using MauiAppHotel.Models;
using System.Globalization;

namespace MauiAppHotel.Views
{
    public partial class QuartosDisponiveis : ContentPage
    {
        public QuartosDisponiveis()
        {
            InitializeComponent();

            var app = (App)Application.Current!;
            var cultura = new CultureInfo("pt-BR");

            foreach (Quarto quarto in app.lista_quartos)
            {
                Border cartao = new Border
                {
                    BackgroundColor = Colors.White,
                    Stroke = Color.FromArgb("#E5DED2"),
                    StrokeThickness = 1,
                    Padding = 18,
                    StrokeShape = new RoundRectangle
                    {
                        CornerRadius = 15
                    }
                };

                VerticalStackLayout conteudo = new VerticalStackLayout
                {
                    Spacing = 12
                };

                Label categoria = new Label
                {
                    Text = "ACOMODAÇÃO",
                    FontSize = 10,
                    CharacterSpacing = 2,
                    TextColor = Color.FromArgb("#A18455")
                };

                Label nome = new Label
                {
                    Text = quarto.Descricao,
                    FontSize = 21,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.FromArgb("#243B53"),
                    LineBreakMode = LineBreakMode.WordWrap
                };

                Label descricao = new Label
                {
                    Text = "Conforto e tranquilidade para sua estadia.",
                    FontSize = 13,
                    TextColor = Color.FromArgb("#777D83")
                };

                BoxView linha = new BoxView
                {
                    HeightRequest = 1,
                    Color = Color.FromArgb("#E5DED2")
                };

                Grid precos = new Grid
                {
                    ColumnDefinitions =
                    {
                        new ColumnDefinition(GridLength.Star),
                        new ColumnDefinition(GridLength.Star)
                    },
                    ColumnSpacing = 10
                };

                VerticalStackLayout adulto = new VerticalStackLayout
                {
                    Spacing = 4
                };

                adulto.Children.Add(new Label
                {
                    Text = "ADULTO",
                    FontSize = 10,
                    TextColor = Color.FromArgb("#8A8A83")
                });

                adulto.Children.Add(new Label
                {
                    Text = quarto.ValorDiariaAdulto.ToString("C2", cultura),
                    FontSize = 17,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.FromArgb("#243B53")
                });

                VerticalStackLayout crianca = new VerticalStackLayout
                {
                    Spacing = 4
                };

                crianca.Children.Add(new Label
                {
                    Text = "CRIANÇA",
                    FontSize = 10,
                    TextColor = Color.FromArgb("#8A8A83")
                });

                crianca.Children.Add(new Label
                {
                    Text = quarto.ValorDiariaCrianca.ToString("C2", cultura),
                    FontSize = 17,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.FromArgb("#243B53")
                });

                precos.Children.Add(adulto);
                precos.Children.Add(crianca);

                Grid.SetColumn(crianca, 1);

                Button reservar = new Button
                {
                    Text = "Escolher esta suíte",
                    BackgroundColor = Color.FromArgb("#C9A66B"),
                    TextColor = Color.FromArgb("#243B53"),
                    FontAttributes = FontAttributes.Bold,
                    FontSize = 14,
                    CornerRadius = 11,
                    HeightRequest = 48,
                    HorizontalOptions = LayoutOptions.Fill
                };

                reservar.Clicked += async (sender, args) =>
                {
                    await Navigation.PushAsync(
                        new ContratacaoHospedagem()
                    );
                };

                conteudo.Children.Add(categoria);
                conteudo.Children.Add(nome);
                conteudo.Children.Add(descricao);
                conteudo.Children.Add(linha);
                conteudo.Children.Add(precos);
                conteudo.Children.Add(reservar);

                cartao.Content = conteudo;

                ListaQuartos.Children.Add(cartao);
            }
        }

        private async void Voltar_Clicked(
            object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}