using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto>lista_quartos= new List<Quarto>()
        { 
            new Quarto()
            {
                Descricao = "Suíte Master",
                ValorDiariaAldulto = 150.0,
                ValorDiariaCrianca = 70.0
            },
             new Quarto()
            {
                Descricao = "Suíte Mega",
                ValorDiariaAldulto = 100.0,
                ValorDiariaCrianca = 50.0
            },
              new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAldulto = 70.0,
                ValorDiariaCrianca = 45.0
            },
               new Quarto()
            {
                Descricao = "Suíte Simplista",
                ValorDiariaAldulto = 30.0,
                ValorDiariaCrianca = 20.0
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.contratacaoHospedagem());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 600;
            return window;

        }
    }
}
