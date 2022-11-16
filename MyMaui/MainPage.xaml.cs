using MyMaui.Business.Models;
using MyMaui.Business.Services;

namespace MyMaui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            IGameServices service = new GameServices();
            GameModel model = await service.GetGame();
            lblTest.Text = model.Title;
        }
    }
}