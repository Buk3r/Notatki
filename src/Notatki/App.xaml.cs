using Notatki.Views;

namespace Notatki
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            //MainPage = new NavigationPage(new NotesListPage());
        }
    }
}
