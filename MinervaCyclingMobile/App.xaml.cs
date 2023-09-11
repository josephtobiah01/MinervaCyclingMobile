using MinervaCyclingMobile.CustomControls;
using MinervaCyclingMobile.Views;


namespace MinervaCyclingMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            

            MainPage = new AppShell();
        }
    }
}